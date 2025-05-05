

using System;

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
            float[,] peaksData = new float[512, 2]; // массив куда будем помещать пиковые значения
            float[,] rezultData = new float[quantityPeak, 2];
            int peakCount = 0; // счетчик пиковых значений

            for (int i = 0; i < data.GetLength(0); i += 5) // делим ось X на отрезки
            {
                float peakX = float.NaN; // пиковое значение по оси X
                float peakY = float.NaN; // пиковое значение по оси Y
                float peakValue = float.MinValue; // максимальное значение

                for (int j = i; j < i + 5 && j < data.GetLength(0); j++)
                {
                    // Если значение больше текущего максимума и больше порога
                    if (data[j, 1] > peakValue && data[j, 1] >= thresHold)
                    {
                        peakValue = data[j, 1];
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

            // Пузырьковая сортировка по убыванию значений (второй столбец)
            for (int i = 0; i < peakCount - 1; i++)
            {
                for (int j = 0; j < peakCount - i - 1; j++)
                {
                    if (peaksData[j, 1] < peaksData[j + 1, 1])
                    {
                        for (int k = 0; k < peaksData.GetLength(1); k++)
                        {
                            float temp = peaksData[j, k];
                            peaksData[j, k] = peaksData[j + 1, k];
                            peaksData[j + 1, k] = temp;
                        }
                    }
                }
            }

            // Формируем результат
            for (int i = 0; i < quantityPeak && i < peakCount; i++)
            {
                rezultData[i, 0] = peaksData[i, 0];
                rezultData[i, 1] = peaksData[i, 1];
            }

            return rezultData;
        }
    }
}


