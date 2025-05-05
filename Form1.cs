using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using HP2000_wrapper;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.Linq.Expressions;
using System.IO;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {

        private HP2000Wrapper wrapper = new HP2000Wrapper();
        
        private SpectrometerWork spectrometer = new SpectrometerWork();

        private OxyPlotSchedule plotView;

        private float[,] data; // получение данных со спектрометра
        private float[,] dataWaveLen; // данные для отображения на графике длин волн
        private float[,] dataPixel; // данные для отображения на графике пиксели
        private float[,] downloadedData; // данные со сторонних файлов
        private float[,] referenceData; // данные для построения эталонного графика
        private float[,] darkModeData = new float[512,2]; // данные для вычета темногого спектра

        private bool ContinuousScanningFlag; // флаг для работы с автоматическим сканированием
                
        private bool waveCorCheck; // переменная коррекции измерения
        private bool nonlinCheck; // переменная коррекции измерения
        private bool darkSpectCheck; // переменная коррекции измерения
        private int qtLines; // количество кривых
        private int qtCount = 0; // счетчик количества кривых
        private int qtCountForDownolad = 0; // счетчик количества кривых для сторонних данных
        private bool isOpen; // переменная отображает статус спектрометра, включен он или нет
        private bool fixedSize;

        private CancellationTokenSource cts;
        public event Action OnRKeyPressed;

        public Form1()
        {
            InitializeComponent();    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyDarkTitleBar(); // темная тема для тайтлбара

            this.KeyDown += OnKeyDown;
            this.KeyPreview = true;
            this.FormClosing += Form1_FormClosing;

            // =======работа с графиком========
            axesWaveLenBtn.Checked = true;// по дефолту отрисовываем график с длинами волн на оси Х
            plotView = new OxyPlotSchedule(spectrometer.processingData());// подключение графика
            
            var addPlot = plotView.addplot();// метод отрисовки графика
            
            Controls.Add(addPlot);// Добавляем PlotView на форму
            

            // =======работа со спектрометром========
            // подключение спектрометра
            isOpen = wrapper.openSpectraMeter();                      

            // если спектрометр не подключен запрещаем сканирование
            if (isOpen != true)
            {
                // отключаем кнопки если спектрометр не подключен для предотвращения ошибок
                oneScanBtn.Enabled = false;
                ContinScanBtn.Enabled = false;
                stopScanBtn.Enabled = false;
                closeSpectrometerBtn.Enabled = false;
                infoSpectrometerBtn.Enabled=false;
                darkModeBtn.Enabled = false;
                loadDarkModeBtn.Enabled=false;
                saveDarkMode.Enabled=false;
                notificationsLabel.Text = "Не удалось подключиться к спектрометру.";
                MessageBox.Show("Спектрометр не подключен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                wrapper.initialize(); // инициализируем спектрометр               
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
                onSpectrometer.Enabled = false; // отключаем кнопку подключения спектрометра
            }

            if (reportModeCheckBox.Checked == false)
            {
                StAStSwitch.Enabled = false;
                chanelComboBox1.Enabled = false;
                SavePathTextBox.Enabled = false;
                BrowseButton.Enabled = false;
                reportButton.Enabled = false;
            }

            reportModeCheckBox.CheckedChanged += reportModeCheckBox_CheckedChanged;



            reportModeCheckBox.Checked = Properties.Settings.Default.reportModeCheckBox;
            timeMicrosInput.Text = Properties.Settings.Default.timeMicrosInput;
            ScanIntervalInput.Text = Properties.Settings.Default.ScanIntervalInput;
            averageInput.Text = Properties.Settings.Default.averageInput;
            thresholdInput.Text = Properties.Settings.Default.thresholdInput;
            quantityPeakInput.Text = Properties.Settings.Default.quantityPeakInput;
            filterInput.SelectedIndex = Properties.Settings.Default.filterInput;
            quantityLoadGraph.SelectedIndex = Properties.Settings.Default.quantityLoadGraph;
            quantityLines.SelectedIndex = Properties.Settings.Default.quantityLines;
            chanelComboBox1.SelectedIndex = Properties.Settings.Default.chanelComboBox1;
            StAStSwitch.Checked = Properties.Settings.Default.StAStSwitch;
            SavePathTextBox.Text = Properties.Settings.Default.LastFolderPath;

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Получаем текущую раскладку клавиатуры
            var currentInputLanguage = InputLanguage.CurrentInputLanguage;
            string currentLayout = currentInputLanguage.Culture.TwoLetterISOLanguageName;
            if (e.KeyCode == Keys.R || (e.KeyCode == Keys.K && currentLayout == "ru"))
            {
                
                plotView.plotViewKeyDown();
            }
        }

 
        //одиночное сканирование
        private async void oneScanBtn_Click(object sender, EventArgs e)
        {
            cts?.Dispose(); // Освобождаем старый токен, если он существует
            cts = new CancellationTokenSource(); // Создаём новый источник токенов
            var token = cts.Token;
            // проверка на пустоту и ввод данных больше нуля
            bool conditionScan = averageInput.Text != "" && timeMicrosInput.Text != "" && filterInput.Text != "" && int.Parse(averageInput.Text) >= 0 && int.Parse(timeMicrosInput.Text) >= 0 && int.Parse(filterInput.Text) >= 0;
            
                if (conditionScan)
                {
                    await spectrometerScanning(token);
                    oneScanBtn.Enabled = true;
                    ContinScanBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Некорректные значения!");
                }
            
            
        }

        // непрерывное сканирование. Асинхронно выполняем одиночное сканирование в цикле до тех пор пока не изменим флаг
        async private void ContinScanBtn_Click(object sender, EventArgs e)
        {
            ContinuousScanningFlag = true;
            int intervalScan = int.Parse(ScanIntervalInput.Text);
            bool conditionScan = averageInput.Text != "" && timeMicrosInput.Text != "" && filterInput.Text != "" && int.Parse(averageInput.Text) >= 0 && int.Parse(timeMicrosInput.Text) >= 0 && int.Parse(filterInput.Text) >= 0 && intervalScan >= 0;
            if (conditionScan)
            {
                while (ContinuousScanningFlag == true)
                {
                    ContinScanBtn.Checked = true;
                    cts = new CancellationTokenSource(); // Создаём новый источник токенов
                    var token = cts.Token;
                    await spectrometerScanning(token); 
                    await Task.Delay(intervalScan);
                    
                }
            }
            else
            {
                MessageBox.Show("Некорректные значения!!!");
            }
            ContinScanBtn.Checked = false;
            oneScanBtn.Enabled = true;
            ContinScanBtn.Enabled = true;
        }

        // устанавливает флаг на окончание автоматического сканирования
        private void stopScanBtn_Click(object sender, EventArgs e)
        {
            ContinuousScanningFlag = false;
            cts?.Cancel();
            cts.Dispose();
            cts = null;
            oneScanBtn.Enabled = true;
            ContinScanBtn.Enabled= true;
            
            progressBar1.Value = 0;

        }

        // кнопка повторного подключения спектрометра если он по каким-либо причинам отвалился или программа была включена до подключения спектрометра в компьютер
        private void onSpectrometer_Click(object sender, EventArgs e)
        {
            bool openSpectr = wrapper.openSpectraMeter();
            

            if (isOpen != true)
            {
                notificationsLabel.Text = "Не удалось подключиться к спектрометру.";
            }
            else
            {

                oneScanBtn.Enabled = true;
                ContinScanBtn.Enabled = true;
                stopScanBtn.Enabled = true;
                darkModeBtn.Enabled = true;
                loadDarkModeBtn.Enabled = true;
                saveDarkMode.Enabled = true;
                onSpectrometer.Enabled = false;
                closeSpectrometerBtn.Enabled = true;
                infoSpectrometerBtn.Enabled = true;
                wrapper.initialize(); // инициализируем спектрометр
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
                isOpen = true;
                
            }
        }

        // кнопка очищает график
        private void clearCurveBtn_Click(object sender, EventArgs e)
        {
            
            dataWaveLen = null;
            dataPixel = null;
            downloadedData = null;
            referenceData = null;
            plotView.hidePlot();// убираем старые значения 
            referenceChartBtn.Checked = false;
            qtCount = 0;
            qtCountForDownolad = 0;

        }
        private void referenceChartBtn_Click(object sender, EventArgs e)
        {
            if(referenceData != null)
            {
                referenceChartBtn.Checked = !referenceChartBtn.Checked;
                plotView.toggleVisibleReferenceChart();
            }
            else
            {
                notificationsLabel.Text = "Подключите эталонный график";
            }
        }
        private void referenceChartLoadBtn_Click(object sender, EventArgs e)
        {
            string pathReadyData = new LoadAndSaveReadyData().loadReadyData();//получаем путь до нужного файла
            if (pathReadyData != null)
            {
                referenceData = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
                if (referenceData != null)
                {
                    plotView.updatePlot(fixedSizeBtn.Checked, referenceData, "reference", true);// выводим новый график
                    if (referenceData[511, 0] == 511)
                    {
                        plotView.changeAxes(false);// меняем ось на Х на пикслели
                        pixelXToolStripMenuItem.Checked = true;//активируем кнопку 
                        axesWaveLenBtn.Checked = false;
                    }
                    else
                    {
                        plotView.changeAxes(true);
                        pixelXToolStripMenuItem.Checked = false;
                        axesWaveLenBtn.Checked = true;
                    }
                    parameterPanel.Visible = false;
                }

            }
            referenceChartBtn.Checked = true;
        }

        // событие обрабатывает загрузку сторонних файлов
        private void loadBtn_Click(object sender, EventArgs e)
        {
            int qtLoadGraph = int.Parse(quantityLoadGraph.Text);
            if (qtCountForDownolad >= qtLoadGraph)
            {
                qtCountForDownolad = 0;

            }
            qtCountForDownolad++;

            string pathReadyData = new LoadAndSaveReadyData().loadReadyData();//получаем путь до нужного файла
            if (pathReadyData != null)
            {
                downloadedData = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
                if (downloadedData != null)
                {
                    
                    plotView.updatePlot(fixedSizeBtn.Checked, downloadedData, "load", qtLoadGraph: qtLoadGraph);// выводим новый график
                    plotView.dataForSearchPeaks(downloadedData, qtCountForDownolad);
                    if (downloadedData[511, 0] == 511)
                    {
                        plotView.changeAxes(false);// меняем ось на Х на пикслели
                        pixelXToolStripMenuItem.Checked = true;//активируем кнопку 
                        axesWaveLenBtn.Checked = false;
                    }
                    else
                    {
                        plotView.changeAxes(true);
                        pixelXToolStripMenuItem.Checked = false;
                        axesWaveLenBtn.Checked = true;
                    }
                    parameterPanel.Visible = false;
                }

            }
            else
            {
                qtCountForDownolad--;
            }
        }
        // событие обрабатывает ручное сохранение спеткральных данных 
        private void saveBtn_Click(object sender, EventArgs e)
        {
            new LoadAndSaveReadyData().saveData(data);// сохраняем данные
            parameterPanel.Visible = false;
        }



        // событие обрабатывает поиск пиковых значений
        private void findPeakBtn_Click(object sender, EventArgs e)
        {
            if(thresholdInput.Text != "" && quantityPeakInput.Text != "" && Regex.IsMatch(quantityPeakInput.Text, @"^\d+$"))
            {
                int thresHold = int.Parse(thresholdInput.Text);// порог поиска
                int quantityPeak = int.Parse(quantityPeakInput.Text);// количество пиковых значений
                plotView.addPeakAnnotations(thresHold, quantityPeak, qtCount, qtCountForDownolad);
                
            }
            else
            {
                MessageBox.Show("некорректные значения!!!");
            }
        }

       
        //событие обрабатывает переключение оси Х на пиксели
        private void pixelXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qtCount = 1;
            int filter = int.Parse(filterInput.Text);// парсим значение фильтра для метода сохранения новых данных

            pixelXToolStripMenuItem.Checked = true;// устанавливает флаг отображения данных в пикселях в положение truе      
            axesWaveLenBtn.Checked = false;//устанавливает флаг отображения данных в длинах влон в положение false


            if (dataPixel != null)
            {                
                plotView.updatePlot(fixedSizeBtn.Checked,dataPixel, "scan", false);// обновляем график
            }

            if (downloadedData != null)
            {
                for (int i = 0; i < downloadedData.GetLength(0); i++)
                {
                    downloadedData[i, 0] = i;
                }
                plotView.updatePlot(fixedSizeBtn.Checked, downloadedData, "load", false);// обновляем график
            }

            if(referenceData != null)
            {
                for (int i = 0; i < referenceData.GetLength(0); i++)
                {
                    referenceData[i, 0] = i;
                }
                plotView.updatePlot(fixedSizeBtn.Checked, referenceData, "reference", false);// обновляем график
            }
            plotView.changeAxes(false); // изменяем ось на пиксели
        }

        //событие обрабатывает переключение оси Х на длины волн
        private void waveLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qtCount = 1;
            int filter = int.Parse(filterInput.Text);// парсим значение фильтра для метода сохранения новых данных

            axesWaveLenBtn.Checked = true;//устанавливает флаг отображения данных в длинах волн в положение truе   
            pixelXToolStripMenuItem.Checked = false;// устанавливает флаг отображения данных в пикселях в положение false



            float[] wavelengthArray = wrapper.getWavelength();
            if (dataWaveLen != null)
            {
                
                plotView.updatePlot(fixedSizeBtn.Checked,dataWaveLen, "scan", true);// обновляем график
            }

            if (downloadedData != null)
            {
                for (int i = 0; i < downloadedData.GetLength(0); i++)
                {
                    downloadedData[i, 0] = wavelengthArray[i];
                }
                plotView.updatePlot(fixedSizeBtn.Checked, downloadedData, "load", true);// обновляем график
            }
            if (referenceData != null)
            {
                for (int i = 0; i < referenceData.GetLength(0); i++)
                {
                    referenceData[i, 0] = wavelengthArray[i];
                }
                plotView.updatePlot(fixedSizeBtn.Checked, referenceData, "reference", true);// обновляем график
            }
            plotView.changeAxes(true); // изменяем ось на длины волн
        }
        


        // чекбокс коррекции Формы фолны
        private void waveformCorCh_CheckedChanged(object sender, EventArgs e)
        {
            waveCorCheck = waveformCorCh.Checked;
        }

        // чекбокс коррекции Нелинейности
        private void nonlinearCorCh_CheckedChanged(object sender, EventArgs e)
        {
            nonlinCheck = nonlinearCorCh.Checked;
        }

        // чекбокс коррекции Темного спектра
        private void darkSpectCh_CheckedChanged(object sender, EventArgs e)
        {
            darkSpectCheck = darkSpectCh.Checked;
        }
        




        private void extTriggerMenuItem_Click(object sender, EventArgs e)
        {
            
            if(extTriggerMenuItem.Checked == true) 
            {
                notificationsLabel.Text = "Внешний триггер подключен.";
            }
            else
            {
                notificationsLabel.Text = "Внешний триггер отключен";
                wrapper.stopexttrig();
            }
            
        }

        private void saveToPNGMenuItem_Click(object sender, EventArgs e)
        {
            plotView.savePlotPNG();
        }

        private void parametersBtn_Click(object sender, EventArgs e)
        {
            parameterPanel.Visible = !parameterPanel.Visible;
        }



        private void ApplyDarkTitleBar()
        {
            int DWMWA_USE_IMMERSIVE_DARK_MODE = 20; // Атрибут для темной темы
            int isDarkModeEnabled = 1; // Включить темную тему

            // Устанавливаем атрибут для текущего окна
            DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref isDarkModeEnabled, sizeof(int));
        }
        [DllImport("dwmapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);



        async private void darkModeBtn_Click(object sender, EventArgs e)
        {
            darkModeBtn.Checked = !darkModeBtn.Checked;
            if (darkModeBtn.Checked )
            {
                
                cts?.Dispose(); // Освобождаем старый токен, если он существует
                cts = new CancellationTokenSource(); // Создаём новый источник токенов
                var token = cts.Token;
                try
                {
                    await spectrometerScanning(token);
                    oneScanBtn.Enabled = true;
                    ContinScanBtn.Enabled = true;
                }
                catch (OperationCanceledException)
                {
                    notificationsLabel.Text = "Операция была отменена!";
                }

            }
            
            darkModeData = data;
   
        }

        private void loadDarkModeBtn_Click(object sender, EventArgs e)
        {
            darkModeBtn.Checked = true;
            string pathReadyData = new LoadAndSaveReadyData().loadReadyData();//получаем путь до нужного файла
            if (pathReadyData != null)
            {
                downloadedData = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
                darkModeData = downloadedData;
               
            }
            else
            {
                darkModeBtn.Checked = false;
            }
        }

        private void saveDarkMode_Click(object sender, EventArgs e)
        {
             new LoadAndSaveReadyData().saveData(data);// сохраняем данные
        }



        private void parameterQuit_Click(object sender, EventArgs e)
        {
            parameterPanel.Visible = false;
        }

        async private Task spectrometerScanning(CancellationToken token)
        {

            await Task.Run(async() =>
            {
                float[,] tempData = new float[512, 2];
                
                oneScanBtn.Enabled = false;
                ContinScanBtn.Enabled = false;
                int timeMicros = int.Parse(timeMicrosInput.Text);// время сканирования
                int average = int.Parse(averageInput.Text); // усредненное сканирование
                int filter = int.Parse(filterInput.Text); // фильтр
                
                progressBar1.Maximum = average;
                progressBar1.Value = 0;

                // в цикле реализуем усредненое сканирование 
                for (int i = 1; i <= average; i++)
                {
                    //token.ThrowIfCancellationRequested();
                    if (token.IsCancellationRequested)
                    {
                        notificationsLabel.Text = "Операция прервана!";
                        progressBar1.Value = 0;
                        return;
                    }
                    // условие на поключение триггера
                    if (extTriggerMenuItem.Checked == true)
                    {

                        int j = 0;
                        wrapper.getExtTrigSpectrum(timeMicros);

                        while (extTriggerMenuItem.Checked == true)
                        {
                            notificationsLabel.Invoke(new Action(() =>
                            {
                                notificationsLabel.Text = $"Ожидаю триггер: {j++} сек";
                            }));
                            
                            if (wrapper.getSpectrumDataReadyFlag() == 1)
                            {
                                notificationsLabel.Invoke(new Action(() =>
                                {
                                    notificationsLabel.Text = $"данные триггера готовы";
                                }));
                                break;
                            }
                            await Task.Delay(1000);
                        }
                        oneScanBtn.Enabled = true;
                    }
                    else
                    {
                        notificationsLabel.Text = spectrometer.loadData(timeMicros);//загружаем данные в спектрометр
                        
                        while(wrapper.getSpectrumDataReadyFlag()!=1)
                        {
                            wrapper.getSpectrumDataReadyFlag();
                        }
                        
                        notificationsLabel.Text = $"данные спектрометра готовы";
                    }

                    dataWaveLen = spectrometer.processingData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, true);// сохраняем данные с длинами волн
                    dataPixel = spectrometer.processingData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, false);// сохраняем данные с пикселями

                    //условие по которому определяем в каком виде сохрянять данные(в пикселях или длинах волн)
                    if (axesWaveLenBtn.Checked == true)
                    {
                        data = dataWaveLen;
                    }
                    else
                    {
                        data = dataPixel;
                    }

                    // складываем полученные значения в промежуточном массиве
                    for (int j = 0; j < 512; j++)
                    {
                        tempData[j, 0] += data[j, 0];
                        tempData[j, 1] += data[j, 1];
                    }
                    progressBar1.Value++;
                }
                // сумму значений делим на их количество (находим среднее арифметическое)
                for (int i = 0; i < 512; i++)
                {
                    data[i, 1] = tempData[i, 1] / average;
                }
                
                

                if (darkModeBtn.Checked == true)
                {
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        data[i, 1] -= darkModeData[i, 1];
                        dataPixel[i, 1] = data[i, 1];
                        dataWaveLen[i, 1] = data[i, 1];
                    }
                }
                qtLines = int.Parse(quantityLines.Text);
                if (qtCount >= qtLines)
                {
                    qtCount = 0;
                    
                }
                qtCount++;
                
                plotView.updatePlot(fixedSizeBtn.Checked,data, "scan", axesWaveLenBtn.Checked, qtLines);// выводим новый график
                plotView.dataForSearchPeaks(data, qtCount);
                plotView.changeAxes(axesWaveLenBtn.Checked);

                
                

                // если кнопка в меню которая отвечает за автоматическое сохранение активна сохраняем данные автоматом
                if (automaticSaveToolStripMenuItem.Checked || reportModeCheckBox.Checked)
                {
                    string savePath = Properties.Settings.Default.LastFolderPath;
                    new LoadAndSaveReadyData().automaticSaveData(data, reportModeCheckBox.Checked, StAStSwitch.Checked, filterInput.SelectedIndex, savePath);
                }

                tempData = null;
                downloadedData = null;
                
            });
        }

        private void closeSpectrometerBtn_Click(object sender, EventArgs e)
        {
            bool flag = wrapper.closeSpectraMeter();
            if (flag == true)
            {
                notificationsLabel.Text = "Соединение со спектрометром закрыто!";
                onSpectrometer.Enabled = true;
                closeSpectrometerBtn.Enabled = false;
                oneScanBtn.Enabled = false;
                ContinScanBtn.Enabled = false;
                stopScanBtn.Enabled = false;
                infoSpectrometerBtn.Enabled = false;
                darkModeBtn.Enabled = false;
                loadDarkModeBtn.Enabled= false;
                saveDarkMode.Enabled = false;
            }
            else
            {
                notificationsLabel.Text = "Соединение со спектрометром не было закрыто!";
            }
        }

       

        private void infoSpectrometerBtn_Click(object sender, EventArgs e)
        {
            aboutSprctrometer form2 = new aboutSprctrometer();
            form2.Show();
        }

        private void fixedSizeBtn_Click(object sender, EventArgs e)
        {
            fixedSizeBtn.Checked = !fixedSizeBtn.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем значения пользователя
            Properties.Settings.Default.timeMicrosInput = timeMicrosInput.Text; 
            Properties.Settings.Default.ScanIntervalInput = ScanIntervalInput.Text;
            Properties.Settings.Default.averageInput = averageInput.Text;
            Properties.Settings.Default.thresholdInput = thresholdInput.Text;
            Properties.Settings.Default.quantityPeakInput = quantityPeakInput.Text;
            Properties.Settings.Default.quantityLoadGraph = quantityLoadGraph.SelectedIndex;
            Properties.Settings.Default.quantityLines = quantityLines.SelectedIndex;
            Properties.Settings.Default.filterInput = filterInput.SelectedIndex;
            Properties.Settings.Default.chanelComboBox1 = chanelComboBox1.SelectedIndex;
            Properties.Settings.Default.StAStSwitch = StAStSwitch.Checked;
            Properties.Settings.Default.reportModeCheckBox = reportModeCheckBox.Checked;
            Properties.Settings.Default.Save(); // Сохраняем настройки
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            string browsePath = new LoadAndSaveReadyData().browsePath();
            if(browsePath != null)
            {
                SavePathTextBox.Text = browsePath;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reportModeCheckBox.Checked == false)
            {
                StAStSwitch.Enabled = false;
                chanelComboBox1.Enabled = false;
                SavePathTextBox.Enabled = false;
                BrowseButton.Enabled = false;
                reportButton.Enabled = false;
            }
            else
            {
                StAStSwitch.Enabled = true;
                chanelComboBox1.Enabled = true;
                SavePathTextBox.Enabled = true;
                BrowseButton.Enabled = true;
                reportButton.Enabled = true;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

            for(int i=1;i<=4;i++)
            {
                if (File.Exists(Properties.Settings.Default.LastFolderPath + $"\\ASt_ch{i}.txt") && File.Exists(Properties.Settings.Default.LastFolderPath + $"\\St_ch{i}.txt"))
                {
                    string loadPath = Properties.Settings.Default.LastFolderPath + $"\\ASt_ch{i}.txt";
                    float[,] dataASt = new GetData().Data(loadPath);
                    plotView.updatePlot(fixedSizeBtn.Checked, dataASt, "load", axesWaveLenBtn.Checked, 2, 2);

                    loadPath = Properties.Settings.Default.LastFolderPath + $"\\St_ch{i}.txt";
                    float[,] dataSt = new GetData().Data(loadPath);
                    plotView.updatePlot(fixedSizeBtn.Checked, dataSt, "load", axesWaveLenBtn.Checked, 2, 2);

                    string savePNGPath = Properties.Settings.Default.LastFolderPath + $"\\ch{i+100}.png";

                    

                    plotView.saveReportPng(savePNGPath, dataSt, dataASt);
                    plotView.CreateImageWithText(savePNGPath, Properties.Settings.Default.LastFolderPath + $"\\ch{i}.png", dataSt, dataASt);
                    
                    
                    
                    File.Delete(savePNGPath);
                }
                if(!File.Exists(Properties.Settings.Default.LastFolderPath + $"\\ASt_ch{i}.txt") && File.Exists(Properties.Settings.Default.LastFolderPath + $"\\St_ch{i}.txt"))
                {
                    MessageBox.Show($"ASt файлa в канале {i} не хватает!");
                }
                if (File.Exists(Properties.Settings.Default.LastFolderPath + $"\\ASt_ch{i}.txt") && !File.Exists(Properties.Settings.Default.LastFolderPath + $"\\St_ch{i}.txt"))
                {
                    MessageBox.Show($"St файлa в канале {i} не хватает!");
                }

            }
            plotView.hidePlot();
            MessageBox.Show("Отчет создан успешно!");

        }
    }
}




