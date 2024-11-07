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
    internal class SpectrometerWork
    {
        dynamic wrapper = new HP2000Wrapper();

        public string loadData(int timeMicros, int average)
        {
            
            wrapper.setIntegrationTime(timeMicros);
            wrapper.setAverage(average);

            // начинаем сбор спектральных данных
            bool flag = wrapper.getSpectrum(timeMicros);
            
            if (flag == true)
            {
                return "Начат сбор спектра!";
            }
            else
            {
                return "Ошибка! Сбор спектра не начат!";
            }
        }

        public void readyData(Label notificationsLabel, System.Windows.Forms.ProgressBar progressBar1)
        {

            int dataReadyFlag = 0;
            // в цикле проверяем готовность данных
            while (dataReadyFlag != 1)
            {
                dataReadyFlag = wrapper.getSpectrumDataReadyFlag();
                Thread.Sleep(500);
                progressBar1.PerformStep();// прогрессбар
                notificationsLabel.Text = "Загрузка данных спектрометра...";
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

        public void saveData(int filter,bool Xpixel=false,bool XwaveLength=true)
        {
            
            Spectrum data;
            
            data = wrapper.ReadSpectrum();// массив с данными спектрометра(у)
            float[] resultData = wrapper.dataProcess(data.array, filter, false, false, false);
            string file = "spectrum_data.txt";
            if (data.valid_flag == SpectrumDataValidFlag.SPECTRUMDATA_VALID)
            {               
                if(XwaveLength == true)
                {
                    float[] wavelengthArray = wrapper.getWavelength();// массив с длинами волн(х) 
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        // Запись данных
                        for (int i = 0; wavelengthArray[i] < 1676; i++) // !!!жесткая привязка к длине волны надо исправить!!!
                        {
                            writer.WriteLine($"{wavelengthArray[i].ToString("F3", CultureInfo.InvariantCulture)}\t{resultData[i].ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }else if(Xpixel == true)
                {
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        // Запись данных
                        for (int i = 0; i <= 510; i++) 
                        {
                            writer.WriteLine($"{i.ToString("F3", CultureInfo.InvariantCulture)}\t{resultData[i].ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
            }   
        }
    }
}
