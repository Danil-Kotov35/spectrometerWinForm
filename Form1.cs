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

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        private HP2000Wrapper wrapper = new HP2000Wrapper();

        private dynamic spectrometer = new SpectrometerWork();

        private dynamic plotView;

        private dynamic data = new GetData(); // получение данных со спектрометра



        public Form1()
        {
            InitializeComponent();

            

            // =======работа с графиком========
            
            plotView = new OxyPlotSchedule(data.Data("spectrum_data.txt"));// подключение графика
            var addPlot = plotView.Addplot();// ф-ция отрисовки графика
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


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oneScanBtn_Click(object sender, EventArgs e)
        {
            int timeMicros = int.Parse(timeMicrosInput.Text);
            int average = int.Parse(averageInput.Text);
            
            notificationsLabel.Text = spectrometer.loadData(timeMicros, average);//загружаем данные в спектрометр
            spectrometer.readyData(notificationsLabel, progressBar1);//проверяем данные на готовность
            spectrometer.saveData();// сохраняем данные в файл
            data = new GetData().Data("spectrum_data.txt");// считываем обновленные данные из файла

            plotView.updatePlot(data);// выводим новый график


        }

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
                notificationsLabel.Text = "Успешное подключение и инициализация спектрометра.";
            }

        }

        

        private void clearCurveBtn_Click(object sender, EventArgs e)
        {
            
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wrapper.closeSpectraMeter();
        }
    }
}
