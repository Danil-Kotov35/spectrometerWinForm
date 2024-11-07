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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class GetData
    {
        public float[,] Data(string filePath)
        {
            // читаем данные
            string[] lines = File.ReadAllLines(filePath);
            float[,] data = new float[lines.Length, 2];
            string patternWaveLength = @"^\d{1,4}\.\d{3}\t\d{4}\.\d{2}$";// маска для проверки сторонних файлов 
            
            if (data.GetLength(0)<=512 && Regex.IsMatch(lines[0], patternWaveLength)) // 
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string row = lines[i];
                    string[] rowSplit = row.Split('\t');

                    data[i, 0] = float.Parse(rowSplit[0], CultureInfo.InvariantCulture);// x
                    data[i, 1] = float.Parse(rowSplit[1], CultureInfo.InvariantCulture);// y
                }
                return data;
            }else
            {
                MessageBox.Show($"Неверный формат файла");
                return null;
            }
        }
    }
}
