using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class PeakSearch
    {
        private float[,] data;
        
        public PeakSearch(float[,] data) 
        {
            this.data = data;
        }
        public float[,] findPeaks(int thresHold, int peakWidth)
        {
            float[,] peaksData = new float[512, 2]; // массив куда будем помещать пиковые значения

            int peakCount = 0; // счетчик пиковых значений
         
            for (int i = 0; i < data.GetLength(0); i += peakWidth)
            {
                float peakX = float.NaN; // пиковое значение по оси X
                float peakY = float.NaN; // пиковое значение по оси У

                float maxPeakValue = float.MinValue;// стартовое максимальное значение(по дефолту стоит наименьшее возможное значение)
                for (int j = i; j < i + peakWidth && j < data.GetLength(0); j++) //если текущее значение больше максимального и больше порога записываем значения в переменные
                {
                    if (data[j, 1] > maxPeakValue && data[j, 1] >= thresHold)
                    {
                        maxPeakValue = data[j, 1];
                        peakX = data[j,0];
                        peakY = data[j,1];               
                    }    
                }

                if(!float.IsNaN(peakX) && peakCount < peaksData.GetLength(0))
                {
                    peaksData[peakCount, 0] = peakX;
                    peaksData[peakCount, 1] = peakY;
                    peakCount++;
                }        
            }
            return peaksData;
        }
    }
}
