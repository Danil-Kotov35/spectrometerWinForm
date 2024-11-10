using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP2000_wrapper;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.IO;


namespace WindowsFormsApp1
{
    // =====Класс работающий с библиотекой спектрометра
    internal class SpectrometerWork
    {
        dynamic wrapper = new HP2000Wrapper();

        // загрузка данных в спектрометр. на вход идут время сканирования и количество усреднений 
        public string loadData(int timeMicros, int average)
        {
                       
            wrapper.setAverage(average);//устанавливаем количество усреднений

            
            bool flag = wrapper.getSpectrum(timeMicros);// начинаем сбор спектральных данных

            if (flag == true)
            {
                return "Начат сбор спектра!";
            }
            else
            {
                return "Ошибка! Сбор спектра не начат!";
            }
        }

        // метод проверяет готовность спектральных данных
        public void readyData(Label notificationsLabel, System.Windows.Forms.ProgressBar progressBar1)
        {
            progressBar1.Value = 0;
            int dataReadyFlag = 0;// флаг готовности
            // в цикле проверяем готовность данных
            while (dataReadyFlag != 1)
            {
                dataReadyFlag = wrapper.getSpectrumDataReadyFlag();//метод который проверяет готовность 
                progressBar1.PerformStep();// прогрессбар
            }
            
            if (dataReadyFlag == 1)
            {
                notificationsLabel.Text = "данные спектрометра готовы!";

            }
            else
            {
                notificationsLabel.Text = "Что-то пошло не так";
            }

        }

        //метод который сохраняет полученные данные в промежуточный файл из которого будет происходить чтение и отрисовка на графике
        public void saveData(int filter, bool darkSpectraCor, bool nonLinearCor, bool waverformCor,bool Xpixel=false,bool XwaveLength=true)
        {
            
            Spectrum data;
            
            data = wrapper.ReadSpectrum();// массив с данными спектрометра(у)
            float[] filterData = wrapper.dataProcess(data.array, filter, darkSpectraCor, nonLinearCor, waverformCor);// метод обрабатывает сырые значения со спеткрометра с уцчетом фильтров
            float[,] rezultData = new float[510, 2];
            string file = "spectrum_data.txt";// имя промежуточного файла куда записываются данные со спекторометра
            if (data.valid_flag == SpectrumDataValidFlag.SPECTRUMDATA_VALID)
            {               
                if(XwaveLength == true)// условие проверяет ось какого вида мы используем в данный момент
                {
                    float[] wavelengthArray = wrapper.getWavelength();// массив с длинами волн(х) 
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        // Запись данных
                        for (int i = 0; wavelengthArray[i] < 1678; i++) // !!!жесткая привязка к длине волны надо исправить!!!
                        {
                            writer.WriteLine($"{wavelengthArray[i].ToString("F3", CultureInfo.InvariantCulture)}\t{filterData[i].ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }else if(Xpixel == true)
                {
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        // Запись данных
                        for (int i = 0; i <= 510; i++) 
                        {
                            writer.WriteLine($"{i.ToString("F3", CultureInfo.InvariantCulture)}\t{filterData[i].ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
            }   
        }
    }
}


