using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using HP2000_wrapper;
using System.Threading;
using System.IO;

using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {

        private HP2000Wrapper wrapper = new HP2000Wrapper();
        
        private dynamic spectrometer = new SpectrometerWork();        
       
        private float[,] data; // получение данных со спектрометра
        private float[,] dataWaveLen;
        private float[,] dataPixel;
        private float[,] downloadedData;
        private float[,] darkModeData = new float[512,2];

        private bool ContinuousScanningFlag; // флаг для работы с автоматическим сканированием
        private dynamic plotView;
        
        private bool waveCorCheck;
        private bool nonlinCheck;
        private bool darkSpectCheck;
        private int qtLines;
        private int qtCount = 0;
        private bool isOpen;

        public Form1()
        {
            InitializeComponent();
            ApplyDarkTitleBar();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // =======работа с графиком========
            axesWaveLenBtn.Checked = true;// по дефолту отрисовываем график с длинами волн на оси Х
            plotView = new OxyPlotSchedule(spectrometer.saveData());// подключение графика
            
            var addPlot = plotView.Addplot();// ф-ция отрисовки графика
            plotView.hidePlot(); // необходим для корректного отображения загруженных данных
            Controls.Add(addPlot);// Добавляем PlotView на форму
            

            // =======работа со спектрометром========
            // подключение спектрометра
            isOpen = wrapper.openSpectraMeter();
            
            //spectrometer.statusSpectrometer(StatusPanel,true);

            // если спектрометр не подключен запрещаем сканирование
            if (isOpen != true)
            {
                oneScanBtn.Enabled = false;
                ContinScanBtn.Enabled = false;
                stopScanBtn.Enabled = false;
                closeSpectrometerBtn.Enabled = false;
                infoSpectrometerBtn.Enabled=false;
                notificationsLabel.Text = "Не удалось подключиться к спектрометру.";
                MessageBox.Show("Спектрометр не подключен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                wrapper.initialize(); // инициализируем спектрометр               
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
                onSpectrometer.Enabled = false;
            }

            quantityLines.SelectedIndex = 0;// выставляем дефолтное количесство линий графика

            



        }

        //одиночное сканирование
        private async void oneScanBtn_Click(object sender, EventArgs e)
        {
          await spectrometerScanning();
        }

        // непрерывное сканирование. Асинхронно выполняем одиночное сканирование в цикле до тех пор пока не изменим флаг
        async private void ContinScanBtn_Click(object sender, EventArgs e)
        {
            ContinuousScanningFlag = true;
            int intervalScan = int.Parse(ScanIntervalInput.Text);
            while (ContinuousScanningFlag == true)
            {
                ContinScanBtn.Checked = true;
                await spectrometerScanning();
                await Task.Delay(intervalScan);
                
            }
            ContinScanBtn.Checked = false;
            

        }

        // устанавливает флаг на окончание автоматического сканирования
        private void stopScanBtn_Click(object sender, EventArgs e)
        {
            ContinuousScanningFlag = false;
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
                wrapper.initialize(); // инициализируем спектрометр
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
                isOpen = true;
                onSpectrometer.Enabled = false;
                closeSpectrometerBtn.Enabled = true;
                infoSpectrometerBtn.Enabled = true;
            }
        }

        // кнопка очищает график
        private void clearCurveBtn_Click(object sender, EventArgs e)
        {
            
            dataWaveLen = null;
            dataPixel = null;
            downloadedData = null;
            plotView.hidePlot();// убираем старые значения 
            

        }

        // событие обрабатывает загрузку сторонних файлов 
        private void loadSpectralDataMenuItem_Click(object sender, EventArgs e)
        {
            string pathReadyData = new LoadAndSaveReadyData().LoadReadyData();//получаем путь до нужного файла
            if (pathReadyData != null)
            {   
                downloadedData = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
                plotView.updatePlot(downloadedData, true);// выводим новый график
            }
            parameterPanel.Visible = false;

        }

        // событие обрабатывает ручное сохранение спеткральных данных 
        private void manualSaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoadAndSaveReadyData().SaveReadyData(data);// сохраняем данные
            parameterPanel.Visible = false;
        }



        // событие обрабатывает поиск пиковых значений
        private void findPeakBtn_Click(object sender, EventArgs e)
        {
            if(thresholdInput.Text != "" && quantityPeakInput.Text != "" && Regex.IsMatch(thresholdInput.Text, @"^\d+$") && Regex.IsMatch(quantityPeakInput.Text, @"^\d+$"))
            {
                int thresHold = int.Parse(thresholdInput.Text);// порог поиска
                int quantityPeak = int.Parse(quantityPeakInput.Text);// ширина поиска
                plotView.AddPeakAnnotations(thresHold, quantityPeak);
            }
            else
            {
                MessageBox.Show("некорректные значения!!!");
            }
        }

       
        //событие обрабатывает переключение оси Х на пиксели
        private void pixelXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(filterInput.Text);// парсим значение фильтра для метода сохранения новых данных

            pixelXToolStripMenuItem.Checked = true;// устанавливает флаг отображения данных в пикселях в положение truе      
            axesWaveLenBtn.Checked = false;//устанавливает флаг отображения данных в длинах влон в положение false


            if (dataPixel != null)
            {                
                plotView.updatePlot(dataPixel, false, false);// обновляем график
            }

            if (downloadedData != null)
            {
                for (int i = 0; i < downloadedData.GetLength(0); i++)
                {
                    downloadedData[i, 0] = i;
                }
                plotView.updatePlot(downloadedData, true, false);// обновляем график
            }
            plotView.changeAxes(false); // изменяем ось на пиксели
        }

        //событие обрабатывает переключение оси Х на длины волн
        private void waveLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(filterInput.Text);// парсим значение фильтра для метода сохранения новых данных

            axesWaveLenBtn.Checked = true;//устанавливает флаг отображения данных в длинах волн в положение truе   
            pixelXToolStripMenuItem.Checked = false;// устанавливает флаг отображения данных в пикселях в положение false



            float[] wavelengthArray = wrapper.getWavelength();
            if (dataWaveLen != null)
            {
                
                plotView.updatePlot(dataWaveLen, false, true);// обновляем график
            }

            if (downloadedData != null)
            {
                for (int i = 0; i < downloadedData.GetLength(0); i++)
                {
                    downloadedData[i, 0] = wavelengthArray[i];
                }
                plotView.updatePlot(downloadedData, true, true);// обновляем график
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

        async private Task spectrometerStatus()
        {
            await Task.Run(async() =>
            {
                while (true)
                {
                    
                    if (wrapper.openSpectraMeter() == true)
                    {
                        StatusPanel.BackColor = Color.Green; // Устанавливаем зелёный
                    }
                    else
                    {
                        StatusPanel.BackColor = Color.Red; // Устанавливаем красный
                    }
                    
                    await Task.Delay(1000);
                }

            });
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



        private void darkModeBtn_Click(object sender, EventArgs e)
        {
            darkModeBtn.Checked = !darkModeBtn.Checked;
            if (darkModeBtn.Checked )
            {
                oneScanBtn_Click(null, EventArgs.Empty);

            }
            
            darkModeData = data;
            
        }

        private void loadDarkModeBtn_Click(object sender, EventArgs e)
        {
            darkModeBtn.Checked = true;
            string pathReadyData = new LoadAndSaveReadyData().LoadReadyData();//получаем путь до нужного файла
            if (pathReadyData != null)
            {
                downloadedData = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
                darkModeData = downloadedData;
               
            }
        }

        private void saveDarkMode_Click(object sender, EventArgs e)
        {
            new LoadAndSaveReadyData().SaveReadyData(darkModeData);// сохраняем данные
        }



        private void parameterQuit_Click(object sender, EventArgs e)
        {
            parameterPanel.Visible = false;
        }

        async private Task spectrometerScanning()
        {

            await Task.Run(async() =>
            {
                float[,] tempData = new float[512, 2];

                if (averageInput.Text != "" && timeMicrosInput.Text != "" && filterInput.Text != "") // && Regex.IsMatch(timeMicrosInput.Text, @"^\d+$") && Regex.IsMatch(averageInput.Text, @"^\d+$") && Regex.IsMatch(filterInput.Text, @"^\d+$")
                {
                    int timeMicros = int.Parse(timeMicrosInput.Text);// время сканирования
                    int average = int.Parse(averageInput.Text); // усредненное сканирование
                    int filter = int.Parse(filterInput.Text); // фильтр
                    if (filter > 6)
                    {
                        MessageBox.Show("Установите значение фильтра от 0 до 5");
                    }
                    progressBar1.Maximum = average;
                    progressBar1.Value = 0;

                    // в цикле реализуем усредненое сканирование 
                    for (int i = 1; i <= average; i++)
                    {
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
                                oneScanBtn.Enabled = false;
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
                            //spectrometer.readyData(notificationsLabel);
                            while(wrapper.getSpectrumDataReadyFlag()!=1)
                            {
                                wrapper.getSpectrumDataReadyFlag();
                            }
                            if (wrapper.getSpectrumDataReadyFlag() == 1)
                            {
                                notificationsLabel.Text = $"данные спектрометра готовы";
                            }

                        }

                        dataWaveLen = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, true);// сохраняем данные с длинами волн
                        dataPixel = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, false);// сохраняем данные с пикселями

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
                }
                else
                {
                    MessageBox.Show("Некорректные значения!!!");
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
                plotView.updatePlot(data, false, axesWaveLenBtn.Checked, qtLines);// выводим новый график
                plotView.changeAxes(axesWaveLenBtn.Checked);

                // если кнопка в меню которая отвечает за автоматическое сохранение активна сохраняем данные автоматом
                if (automaticSaveToolStripMenuItem.Checked == true)
                {
                    new LoadAndSaveReadyData().automaticSaveData(data);
                }

                tempData = null;
                
                
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
    }
}




