using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HP2000_wrapper;
using System.IO;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Globalization;

namespace WindowsFormsApp1
{
    internal class GetData
    {
        public float[,] Data(string filePath)
        {
            // читаем данные
            //string filePath = "spectrum_data.txt";
            string[] lines = File.ReadAllLines(filePath);
            float[,] data = new float[lines.Length, 2];
            Console.WriteLine(lines[0]);
            for (int i = 0; i < lines.Length; i++)
            {
                string row = lines[i];
                string[] rowSplit = row.Split('\t');

                data[i, 0] = float.Parse(rowSplit[0], CultureInfo.InvariantCulture);// x
                data[i, 1] = float.Parse(rowSplit[1], CultureInfo.InvariantCulture);// y
            }
            return data;
        }
    }
}
