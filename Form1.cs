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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        ExtTrigger ExtTrigger = new ExtTrigger();
        private HP2000Wrapper wrapper = new HP2000Wrapper();
        private dynamic spectrometer = new SpectrometerWork();        
        private float[,] data; // получение данных со спектрометра
        private bool ContinuousScanningFlag; // флаг для работы с автоматическим сканированием
        private dynamic plotView;
        
        private bool waveCorCheck;
        private bool nonlinCheck;
        private bool darkSpectCheck;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // =======работа с графиком========
            waveLengthToolStripMenuItem.Checked = true;// по дефолту отрисовываем график с длинами волн на оси Х
            plotView = new OxyPlotSchedule(spectrometer.saveData());// подключение графика
                                                                         
            var addPlot = plotView.Addplot();// ф-ция отрисовки графика
            plotView.hidePlot();// убираем старые значения  
            Controls.Add(addPlot);// Добавляем PlotView на форму
            

            // =======работа со спектрометром========
            // подключение спектрометра
            bool openSpectr = wrapper.openSpectraMeter();

            // если спектрометр не подключен запрещаем сканирование
            if (openSpectr != true)
            {
                oneScanBtn.Enabled = false;
                ContinScanBtn.Enabled = false;
                stopScanBtn.Enabled = false;
                clearCurveBtn.Enabled = false;
                notificationsLabel.Text = "Не удалось подключиться к спектрометру.";
                MessageBox.Show("Спектрометр не подключен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                wrapper.initialize(); // инициализируем спектрометр
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
            }




           
            ExtTrigger.onExtTriggerCheckBox.Checked = Properties.Settings.Default.onExtTriggerState;//определяем состояние чекбокса котороый отвечает за внений триггер
        }

        //одиночное сканирование
        private void oneScanBtn_Click(object sender, EventArgs e)
        {
            int timeMicros = int.Parse(timeMicrosInput.Text);// время сканирования
            int average = int.Parse(averageInput.Text); // усредненное сканирование
            int filter = int.Parse(filterInput.Text); // фильтр
            float[,] tempData = new float[511, 2];
            
            // в цикле реализуем усредненое сканирование 
            for(int i=1;i<=average;i++)
            {
                notificationsLabel.Text = spectrometer.loadData(timeMicros);//загружаем данные в спектрометр
                spectrometer.readyData(notificationsLabel, progressBar1);//проверяем данные на готовность

                //условие по которому определяем в каком виде сохрянять данные(в пикселях или длинах волн)
                if (waveLengthToolStripMenuItem.Checked == true)
                {
                    data = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, true);// сохраняем данные в файл с длинами волн
                }
                else
                {
                    data = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, false);// сохраняем данные в файл с пикселями
                }

                // складываем полученные значения в промежуточном массиве
                for(int j=0;j<511;j++)
                {
                    tempData[j, 0] += data[j, 0];
                    tempData[j, 1] += data[j, 1];
                }
                
            }
            // сумму значений делим на их количество (находим среднее арифметическое)
            for(int i=0;i<511;i++)
            {
                data[i, 1] = tempData[i, 1]/average ;
            }


            plotView.updatePlot(data, pixelXToolStripMenuItem.Checked, waveLengthToolStripMenuItem.Checked);// выводим новый график

            // внешний триггер
            if (ExtTrigger.onExtTriggerCheckBox.Checked == true)
            {
                notificationsLabel.Text = "Внешний триггер подключен.";
                wrapper.getExtTrigSpectrum(timeMicros);
                spectrometer.readyData(notificationsLabel, progressBar1);//проверяем данные на готовность
                //условие по которому определяем в каком виде сохрянять данные(в пикселях или длинах волн)
                if (waveLengthToolStripMenuItem.Checked == true)
                {
                    data = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, true);// сохраняем данные в файл с длинами волн
                }
                else
                {
                    data = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck,false);// сохраняем данные в файл с пикселями
                }

                plotView.updatePlot(data, pixelXToolStripMenuItem.Checked, waveLengthToolStripMenuItem.Checked);// выводим новый график

                wrapper.stopexttrig();// закрываем внешний триггер
            }
            else
            {
                notificationsLabel.Text = "Внешний триггер не подключен.";
            }

            // если кнопка в меню которая отвечает за автоматическое сохранение активна сохраняем данные автоматом
            if (automaticSaveToolStripMenuItem.Checked == true)
            {
                new LoadAndSaveReadyData().automaticSaveData(data);
            }
        }
 
        // непрерывное сканирование. Асинхронно выполняем одиночное сканирование в цикле до тех пор пока не изменим флаг
        async private void ContinScanBtn_Click(object sender, EventArgs e)
        {
            ContinuousScanningFlag = true;
            await Task.Run(() =>
            {
                while (ContinuousScanningFlag == true)
                {
                    oneScanBtn_Click(null, EventArgs.Empty);
                }
                
            });
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

            if (openSpectr != true)
            {
                notificationsLabel.Text = "Не удалось подключиться к спектрометру.";
            }
            else
            {
                oneScanBtn.Enabled = true;
                ContinScanBtn.Enabled = true;
                stopScanBtn.Enabled = true;
                clearCurveBtn.Enabled = true;
                wrapper.initialize(); // инициализируем спектрометр
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
            }

            

        }

        // кнопка убирает линию графика
        private void clearCurveBtn_Click(object sender, EventArgs e)
        {
            plotView.hidePlot();// убираем старые значения
        }

        // событие обрабатывает загрузку сторонних файлов 
        private void loadSpectralDataMenuItem_Click(object sender, EventArgs e)
        {
            string pathReadyData = new LoadAndSaveReadyData().LoadReadyData();//получаем путь до нужного файла
            data = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
            plotView.updatePlot(data);// выводим новый график
            
        }

        // событие обрабатывает ручное сохранение спеткральных данных 
        private void manualSaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoadAndSaveReadyData().SaveReadyData(data);// сохраняем данные
        }

        //событие переключает флаг автоматического сохранения
        private void automaticSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            automaticSaveToolStripMenuItem.Checked = !automaticSaveToolStripMenuItem.Checked;//переключение автоматического сохранения
        }

        // событие обрабатывает поиск пиковых занчений
        private void findPeakBtn_Click(object sender, EventArgs e)
        {
            int thresHold = int.Parse(thresholdInput.Text);// порог поиска
            int quantityPeak = int.Parse(quantityPeakInput.Text);// ширина поиска
            plotView.AddPeakAnnotations(thresHold, quantityPeak);
        }

       
        //событие обрабатывает переключение оси Х на пиксели
        private void pixelXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(filterInput.Text);// парсим значение фильтра для метода сохранения новых данных
            
            pixelXToolStripMenuItem.Checked = true;// устанавливает флаг отображения данных в пикселях в положение truе      
            waveLengthToolStripMenuItem.Checked = false;//устанавливает флаг отображения данных в длинах влон в положение false

            data = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, false);// вызываем метод сохранения данных для изменения и сохранения уже отсканированных спектральных данных
            

            plotView.updatePlot(data, true, false);// обновляем график


        }

        //событие обрабатывает переключение оси Х на длины волн
        private void waveLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(filterInput.Text);// парсим значение фильтра для метода сохранения новых данных
            waveLengthToolStripMenuItem.Checked = true;//устанавливает флаг отображения данных в длинах волн в положение truе   
            pixelXToolStripMenuItem.Checked = false;// устанавливает флаг отображения данных в пикселях в положение false

            data = spectrometer.saveData(filter, darkSpectCheck, nonlinCheck, waveCorCheck, true);// сохраняем данные в файл
            
            plotView.updatePlot(data, false, true);// обновляем график


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
            ExtTrigger = new ExtTrigger();
            ExtTrigger.Show();
        }
    }
}
