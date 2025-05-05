using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Helper
    {
        public float[,] cutByThreshold(float[,] data, int threshold)
        {

            int startIndex = calcStartIndex(data, threshold);
            
            int newLength = data.GetLength(0) - startIndex;
            float[,] newData = new float[newLength, 2];

            for (int i = 0; i < newLength; i++)
            {
                newData[i, 0] = data[startIndex + i, 0];
                newData[i, 1] = data[startIndex + i, 1];
            }

            return newData;
        }

        public int calcStartIndex(float[,] data, int threshold)
        {
            int startIndex = 0;
            float temp = data[0, 1];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                
                float delta = data[i, 1] - temp;
                if (delta > threshold)
                {
                    startIndex = i;
                    break;
                }
                temp = data[i, 1];
            }
            return startIndex;
        }

        public double CalculateArea(float[,] data)
        {
            double area = 0;


            

            for (int i = 0; i < data.GetLength(0) - 1; i++)
            {

                double trapezoidArea = data[i, 1] - 1530;
                area += trapezoidArea;
            }

            return area;
        }


        public float[,] findArea(float[,] data)
        {
            float[,] peakValue = new PeakSearch(data).findPeaks(0, 1);
            int peakIndex = 0;
            int startPositionIndex = 0;
            int endPositionIndex = 0;
            
            


            for(int i = 0;i < data.GetLength(0);i++)
            {
                if (data[i,1] == peakValue[0,1])
                {
                    peakIndex = i; 
                    break;
                }
            }

            float conditionalZero = findConditionalZero(data);



            for (int i = peakIndex; i >= 0; i--)
            {
                if(data[i,1] <= conditionalZero)
                {
                    startPositionIndex = i;
                    break;
                }
            }

            for (int i = peakIndex; i < data.GetLength(0); i++)
            {
                if (data[i, 1] <= conditionalZero)
                {
                    endPositionIndex = i;
                    break;
                }
                if (data[i, 1] == data[511,1])
                {
                    endPositionIndex = i;
                    break;
                }
            }
            
            float[,] cutData = new float[endPositionIndex - startPositionIndex+1,2];
            
            for (int i = startPositionIndex, j=0; i <= endPositionIndex;i++,j++)
            {
                cutData[j,1] = data[i,1];
                cutData[j,0] = data[i,0];
            }

            return cutData;
        }

        public float findConditionalZero(float[,] data)
        {
            float delta = 20;
            float sum = 0;
            for (int i = 70; i < 268; i++)
            {
                sum += data[i, 1];

            }
            float conditionalZero = sum / 197 + delta;

            return conditionalZero;
        }

    }
}
