using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class LoadAndSaveReadyData
    {
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
                else
                {
                    return "spectrum_data.txt";
                    
                }
            }
        }

        // ручное сохранение спектральных данных в файл
        public void SaveReadyData()
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
                    string content = File.ReadAllText("spectrum_data.txt");
                    // Сохранение содержимого в выбранный файл
                    File.WriteAllText(filePath, content);
                    MessageBox.Show($"Файл сохранен: {filePath}");
                }
            }
        }

        // автоматическое сохранение
        public void automaticSaveData()
        {      
            DateTime currentDate = DateTime.Now;// используем дату для формирования имени файла и исключения повторений
            string formattedDate = currentDate.ToString("dd_MM_yyyy_HH_mm_ss");
            string filePath = Path.Combine(Application.StartupPath, "data", "automatic saving") + "\\data" + formattedDate + ".txt";// имя и путь файла   
            string content = File.ReadAllText("spectrum_data.txt");// данные из промежуточного файла
            File.WriteAllText(filePath, content);
        }
    }
}
