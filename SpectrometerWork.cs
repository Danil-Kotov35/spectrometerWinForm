using HP2000_wrapper;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    // =====Класс работающий с библиотекой спектрометра
    internal class SpectrometerWork
    {
        dynamic wrapper = new HP2000Wrapper();

        // загрузка данных в спектрометр. на вход идёт время сканирования 
        public string loadData(int timeMicros)
        {

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
        public void readyData(Label notificationsLabel)
        {
            int dataReadyFlag = 0;// флаг готовности
            // в цикле проверяем готовность данных
            while (dataReadyFlag != 1)
            {
                dataReadyFlag = wrapper.getSpectrumDataReadyFlag();//метод который проверяет готовность    
            }
            
            notificationsLabel.Text = "Данные спектрометра готовы!";

            
        }

        //метод который сохраняет полученные данные в массив из которого будет происходить чтение и отрисовка на графике
        public float[,] processingData(int filter = 0, bool darkSpectraCor = false, bool nonLinearCor = false, bool waverformCor = false, bool XwaveLength = true)
        {

            Spectrum data;

            data = wrapper.ReadSpectrum();// массив с данными спектрометра(у)
            float[] filterData = wrapper.dataProcess(data.array, filter, darkSpectraCor, nonLinearCor, waverformCor);// метод обрабатывает сырые значения со спеткрометра с учетом фильтров            
            float[,] rezultData = new float[512, 2];
            if (data.valid_flag == SpectrumDataValidFlag.SPECTRUMDATA_VALID)
            {
                if (XwaveLength == true)// условие проверяет ось какого вида мы используем в данный момент
                {
                    float[] wavelengthArray = wrapper.getWavelength();// массив с длинами волн(х) 
                    
                    // Запись данных
                    for (int i = 0; i < 512; i++) 
                    {
                        rezultData[i, 0] = wavelengthArray[i];
                        rezultData[i, 1] = filterData[i];
                    }
                    
                }
                else
                {
                    
                     // Запись данных
                     for (int i = 0; i < 512; i++)
                     {
                         rezultData[i, 0] = i;
                         rezultData[i, 1] = filterData[i];

                     }
                    
                }
                data.array = null;
                return rezultData;
            }
            else
            {
                return null;
            }
            
        }   
    }
}



