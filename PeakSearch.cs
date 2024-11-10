using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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
        public float[,] findPeaks(int thresHold, int quantityPeak)
        {
            float[,] peaksData = new float[510, 2]; // массив куда будем помещать пиковые значения
            float[,] rezultData = new float[quantityPeak, 2];
            int peakCount = 0; // счетчик пиковых значений

            for (int i = 0; i < data.GetLength(0); i += 5) // 5 - это отрезки на которые делится ось х чтобы пиковые значения были не слишком близко
            {
                float peakX = float.NaN; // пиковое значение по оси X
                float peakY = float.NaN; // пиковое значение по оси У

                float maxPeakValue = float.MinValue;// стартовое максимальное значение(по дефолту стоит наименьшее возможное значение)
                for (int j = i; j < i + 5 && j < data.GetLength(0); j++) //если текущее значение больше максимального и больше порога записываем значения в переменные
                {
                    if (data[j, 1] > maxPeakValue && data[j, 1] >= thresHold)
                    {
                        maxPeakValue = data[j, 1];
                        peakX = data[j, 0];
                        peakY = data[j, 1];
                    }
                }

                if (!float.IsNaN(peakX) && peakCount < peaksData.GetLength(0))
                {
                    peaksData[peakCount, 0] = peakX;
                    peaksData[peakCount, 1] = peakY;
                    peakCount++;
                }
            }

            // Пузырьковая сортировка по второму столбцу (по убыванию)
            for (int i = 0; i < peaksData.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < peaksData.GetLength(0) - i - 1; j++)
                {
                    if (peaksData[j, 1] < peaksData[j + 1, 1])
                    {
                        // Меняем местами строки
                        for (int k = 0; k < peaksData.GetLength(1); k++)
                        {
                            float temp = peaksData[j, k];
                            peaksData[j, k] = peaksData[j + 1, k];
                            peaksData[j + 1, k] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < quantityPeak; i++)
            {
                rezultData[i,0] = peaksData[i,0];
                rezultData[i,1] = peaksData[i,1];
            }


            return rezultData;
        }
    }
}


