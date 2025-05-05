using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using HP2000_wrapper;
using System.Drawing;
namespace WindowsFormsApp1
{
    internal class LoadAndSaveReadyData
    {
        HP2000Wrapper wrapper = new HP2000Wrapper();
        // загрузка сторонних файлов
        public string loadReadyData() 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Properties.Settings.Default.LastUsedPath; // начальная папка имее относительный путь и начинается в директории с исполняемым файлом
                openFileDialog.Filter = "Text files (*.txt)|*.txt"; // фильтр файлов
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                // Открываем диалоговое окно и проверяем, выбрал ли пользователь файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.LastUsedPath = Path.GetDirectoryName(openFileDialog.FileName); // Сохраняем путь
                    Properties.Settings.Default.Save(); // Сохраняем изменения в настройках, при следующем запуске путь у пользователя сохранится
                    string filePath = openFileDialog.FileName;                   
                    return filePath;
                }
                return null;
            }
        }

        // ручное сохранение спектральных данных в файл
        public void saveData(float[,] data)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt"; // Фильтр файлов
                saveFileDialog.Title = "Сохранить файл как";
                saveFileDialog.InitialDirectory = Properties.Settings.Default.LastUsedPath; // Устанавливает начальную папку
                saveFileDialog.FileName = "data.txt"; // Имя файла по умолчанию

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Properties.Settings.Default.LastUsedPath = Path.GetDirectoryName(saveFileDialog.FileName); // Сохраняем путь
                    Properties.Settings.Default.Save(); // Сохраняем изменения в настройках

                    if(data != null)
                    {
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
                                for (int i = 0; i < 512; i++)
                                {
                                    writer.WriteLine($"{data[i, 0].ToString("F3", CultureInfo.InvariantCulture)}\t{data[i, 1].ToString("F2", CultureInfo.InvariantCulture)}");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данных для сохранения нет!");
                    }
                }
            }
        }

        // автоматическое сохранение
        public void automaticSaveData(float[,] data,bool reportModeChecked,bool stChecked, int channel, string savePath)
        {
            string filePath;

            if (reportModeChecked)
            {
                filePath = savePath + $"\\{(stChecked ? "ASt" : "St")}_ch{channel + 1}.txt";

            }
            else
            {
                DateTime currentDate = DateTime.Now;// используем дату для формирования имени файла и исключения повторений
                string formattedDate = currentDate.ToString("dd_MM_yyyy_HH_mm_ss");
                filePath = Path.Combine(Application.StartupPath, "data", "automatic saving") + "\\data" + formattedDate + ".txt";// имя и путь файла   
            }


            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    // Запись данных
            //    for (int i = 0; i < 10; i++)
            //    {
            //        writer.WriteLine($"test");
            //    }
            //}

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
                    for (int i = 0; i < 512; i++)
                    {
                        writer.WriteLine($"{data[i, 0].ToString("F3", CultureInfo.InvariantCulture)}\t{data[i, 1].ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }

        public string browsePath()
        {
            
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                string lastPath = Properties.Settings.Default.LastFolderPath;
                if (!string.IsNullOrEmpty(lastPath))
                {
                    dialog.SelectedPath = lastPath;   
                }
                dialog.Description = "Выберите папку";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    Properties.Settings.Default.LastFolderPath = selectedPath;
                    Properties.Settings.Default.Save();
                    return selectedPath;
                } else
                {
                    return null;
                }
                
            }
             
        }

        

    }
}
