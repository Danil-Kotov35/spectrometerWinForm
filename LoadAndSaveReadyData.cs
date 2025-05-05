using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using HP2000_wrapper;
namespace WindowsFormsApp1
{
    internal class LoadAndSaveReadyData
    {
        dynamic wrapper = new HP2000Wrapper();
        // загрузка сторонних файлов
        public string LoadReadyData() 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "data"); // начальная папка имее относительный путь и начинается в директории с исполняемым файлом
                openFileDialog.Filter = "Text files (*.txt)|*.txt"; // фильтр файлов
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Открываем диалоговое окно и проверяем, выбрал ли пользователь файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;                   
                    return filePath;
                }
                return null;
            }
        }

        // ручное сохранение спектральных данных в файл
        public void SaveReadyData(float[,] data)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt"; // Фильтр файлов
                saveFileDialog.Title = "Сохранить файл как";
                saveFileDialog.InitialDirectory = Application.StartupPath; // Устанавливает начальную папку
                saveFileDialog.FileName = "data.txt"; // Имя файла по умолчанию

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;


                    if (data[0, 0] == 0.000)
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            // Запись данных
                            for (int i = 0; i < data.GetLength(0); i++)
                            {
                                writer.WriteLine($"{i.ToString("F3", CultureInfo.InvariantCulture)}\t{data[i, 1].ToString("F2", CultureInfo.InvariantCulture)}");
                            }
                        }
                    }
                    else
                    {
                        float[] wavelengthArray = wrapper.getWavelength();// массив с длинами волн(х) 
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            // Запись данных
                            for (int i = 0; wavelengthArray[i] <= 1679; i++)
                            {
                                writer.WriteLine($"{data[i, 0].ToString("F3", CultureInfo.InvariantCulture)}\t{data[i, 1].ToString("F2", CultureInfo.InvariantCulture)}");
                            }
                        }    
                    }
                }
            }
        }

        // автоматическое сохранение
        public void automaticSaveData(float[,] data)
        {      
            DateTime currentDate = DateTime.Now;// используем дату для формирования имени файла и исключения повторений
            string formattedDate = currentDate.ToString("dd_MM_yyyy_HH_mm_ss");
            string filePath = Path.Combine(Application.StartupPath, "data", "automatic saving") + "\\data" + formattedDate + ".txt";// имя и путь файла   

            if (data[0, 0] == 0.000)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Запись данных
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        writer.WriteLine($"{i.ToString("F3", CultureInfo.InvariantCulture)}\t{data[i, 1].ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            else
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Запись данных
                    for (int i = 0; data[i, 0] <= 1676; i++)
                    {
                        writer.WriteLine($"{data[i, 0].ToString("F3", CultureInfo.InvariantCulture)}\t{data[i, 1].ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }
    }
}
