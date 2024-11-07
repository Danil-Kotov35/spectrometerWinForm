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

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        private HP2000Wrapper wrapper = new HP2000Wrapper();
        private dynamic spectrometer = new SpectrometerWork();
        private dynamic plotView;
        private dynamic data = new GetData(); // получение данных со спектрометра
        private bool ContinuousScanningFlag; // флаг для работы с автоматическим сканированием



        public Form1()
        {
            InitializeComponent();

            // =======работа с графиком========
            waveLengthToolStripMenuItem.Checked = true;// по дефолту отрисовываем грфик с длинами волн
            plotView = new OxyPlotSchedule(data.Data("spectrum_data.txt"));// подключение графика            
            var addPlot = plotView.Addplot();// ф-ция отрисовки графика            
            Controls.Add(addPlot);// Добавляем PlotView на форму
            plotView.hidePlot();// убираем старые значения

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
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oneScanBtn_Click(object sender, EventArgs e)
        {
            int timeMicros = int.Parse(timeMicrosInput.Text);
            int average = int.Parse(averageInput.Text);
            int filter = int.Parse(filterInput.Text);
            
            notificationsLabel.Text = spectrometer.loadData(timeMicros, average);//загружаем данные в спектрометр
            spectrometer.readyData(notificationsLabel, progressBar1);//проверяем данные на готовность

            if (waveLengthToolStripMenuItem.Checked == true)
            {
                spectrometer.saveData(filter,false,true);// сохраняем данные в файл
            }
            else
            {
                spectrometer.saveData(filter, true, false);
            }

            data = new GetData().Data("spectrum_data.txt");// считываем обновленные данные из файла

            plotView.updatePlot(data, pixelXToolStripMenuItem.Checked, waveLengthToolStripMenuItem.Checked);// выводим новый график

            if(automaticSaveToolStripMenuItem.Checked == true)
            {
                new LoadAndSaveReadyData().automaticSaveData();// автоматическое сохранение               
            }
        }
 
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

        private void stopScanBtn_Click(object sender, EventArgs e)
        {
            ContinuousScanningFlag = false;
        }

        private void onSpectrometer_Click(object sender, EventArgs e)
        {
            bool openSpectr = wrapper.openSpectraMeter(); //wrapper.openSpectraMeter()

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
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
            }

        }

        private void clearCurveBtn_Click(object sender, EventArgs e)
        {
            plotView.hidePlot();// убираем старые значения
        }

        private void loadSpectralDataMenuItem_Click(object sender, EventArgs e)
        {
            string pathReadyData = new LoadAndSaveReadyData().LoadReadyData();//получаем путь до нужного файла
            data = new GetData().Data(pathReadyData);// считываем обновленные данные из файла
            plotView.updatePlot(data);// выводим новый график
            
        }

        private void manualSaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoadAndSaveReadyData().SaveReadyData();// сохраняем данные
        }

        private void automaticSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            automaticSaveToolStripMenuItem.Checked = !automaticSaveToolStripMenuItem.Checked;//переключение автоматического сохранения
        }

        private void findPeakBtn_Click(object sender, EventArgs e)
        {
            int thresHold = int.Parse(thresholdInput.Text);
            int peakWidth = int.Parse(peakWidthInput.Text);
            plotView.AddPeakAnnotations(thresHold, peakWidth);
        }

       

        private void pixelXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(filterInput.Text);
            
            pixelXToolStripMenuItem.Checked = true;
            
            waveLengthToolStripMenuItem.Checked = false;
            spectrometer.saveData(filter, true, false);
            data = new GetData().Data("spectrum_data.txt");// считываем обновленные данные из файла

            plotView.updatePlot(data, true, false);


        }

        private void waveLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(filterInput.Text);
            waveLengthToolStripMenuItem.Checked = true;
            
            pixelXToolStripMenuItem.Checked = false;
            spectrometer.saveData(filter, false, true);// сохраняем данные в файл
            data = new GetData().Data("spectrum_data.txt");// считываем обновленные данные из файла
            
            plotView.updatePlot(data, false, true);


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wrapper.closeSpectraMeter();
            
        }
    }
}
