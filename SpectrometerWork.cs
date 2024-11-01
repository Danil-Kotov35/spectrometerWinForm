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

        public void saveData()
        {
            
            Spectrum data;
            float[] wavelengthArray = wrapper.getWavelength();// массив с длинами волн
            data = wrapper.ReadSpectrum();
            if (data.valid_flag == SpectrumDataValidFlag.SPECTRUMDATA_VALID)
            {
                float[] resultData = wrapper.dataProcess(data.array, 1, false, false, false);
                string file = "spectrum_data.txt";
                using (StreamWriter writer = new StreamWriter(file))
                {
                    // Запись данных
                    for (int i = 0; wavelengthArray[i] < 1676; i++) // !!!жесткая привязка к длине волны надо исправить!!!
                    {
                        writer.WriteLine($"{wavelengthArray[i].ToString("F3", CultureInfo.InvariantCulture)}\t{resultData[i].ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

                Console.WriteLine("Данные спектра записаны в файл.");
            }

            else
            {
                Console.WriteLine("Произошла ошибка при записи спектра.");
            }

            
        }


    }
}
