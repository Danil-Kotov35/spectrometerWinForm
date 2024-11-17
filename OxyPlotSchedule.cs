using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using OxyPlot.Annotations;
using System.IO;
using System.Globalization;

namespace WindowsFormsApp1
{
    // класс работающий с графиком
    internal class OxyPlotSchedule
    {

        private float[,] data;//данные со спектрометра
        
        private PlotModel plotModel;
        private PlotView plotView;
        private LineSeries lineSeries;
        private LineSeries lineSeries1;
        private LinearAxis xAxis;
        private LinearAxis yAxis;

        public OxyPlotSchedule(float[,] data)
        {
            this.data = data;// получаем данные через конструктор
        }

        // метод отрисовывает таблицу на форме
        public PlotView Addplot()
        {

         
        plotModel = new PlotModel { Title = "" };//название графика

           
            xAxis = new LinearAxis // Настройка осей с сеткой
            {
                Position = AxisPosition.Bottom,
                Title = "Длина волны н / м",               
                MajorGridlineStyle = LineStyle.Solid,   // Основные линии сетки
                MinorGridlineStyle = LineStyle.Dot,      // Дополнительные линии сетки
                MinimumPadding = 0.1, //отступы для корректного отображения графика
                MaximumPadding = 0.1
            };

            yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Интенсивность",
                MajorGridlineStyle = LineStyle.Solid,  // Основные линии сетки
                MinorGridlineStyle = LineStyle.Dot, // Дополнительные линии сетки
                MinimumPadding = 0.1,
                MaximumPadding = 0.1
            };

            // Добавляем оси в модель
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);

            // Создаем серию
            lineSeries = new LineSeries
            {
                Title = "Линия спектра",
                StrokeThickness = 1
            };
            lineSeries1 = new LineSeries
            {
                Title = "Загруженные данные",
                StrokeThickness = 1
            };

            for (int i = 0; i < data.GetLength(0); i++)
            {
                float x = data[i, 0];
                float y = data[i, 1];

                lineSeries.Points.Add(new DataPoint(x, y));
            }


            // Добавляем серию в модель
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(lineSeries1);

            var plotView = new PlotView { Model = plotModel,  }; // Dock = DockStyle.Fill
            plotView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // Изменение размера
            plotView.Size = new Size(900, 490);

            // Изменение позиции
            plotView.Location = new Point(300, 50);
            
            // возвращаем дефолтные значения графика
            plotView.MouseDoubleClick += PlotView_MouseDoubleClick;
            return plotView;
        }

        
        // метод для возвращения графика к дефолтным значениям по двойному щелчку мыши
        private void PlotView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Сбрасываем диапазон осей к исходным значениям
            xAxis.Reset();
            yAxis.Reset();

            // Обновляем график
            plotModel.InvalidatePlot(true);
        }

        
        public void updatePlot(float[,] data,bool lineSeriesflag = false, bool XwaveLength = true)
        {
            
            if (data[0,1] != 0 && !lineSeriesflag) 
            {

                lineSeries.Points.Clear();         // Очистка старых данных
                lineSeries1.Points.Clear();
                plotModel.Annotations.Clear(); // Очищаем все аннотации
                this.data = data; // обновляем данные для корректного поиска пиков
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    float x = data[i, 0];
                    float y = data[i, 1];

                    lineSeries.Points.Add(new DataPoint(x, y));
                }
                plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
                
            }
            else
            {
                lineSeries1.Points.Clear();         // Очистка старых данных
                plotModel.Annotations.Clear(); // Очищаем все аннотации
                this.data = data; // обновляем данные для корректного поиска пиков
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    float x = data[i, 0];
                    float y = data[i, 1];
                    
                    lineSeries1.Points.Add(new DataPoint(x, y));
                }
                
                plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
            }
            
            if(XwaveLength == true)
            {
                plotModel.Axes[0].Title = "Длина волны н / м";
            }
            else
            {
                plotModel.Axes[0].Title = "Пиксели";
            }
            plotModel.InvalidatePlot(true);    // Обновление графика
        }


        public void AddPeakAnnotations(int thresHold,int peakWidth)
        {

            float[,] peakData = new PeakSearch(data).findPeaks(thresHold, peakWidth);//поиск пиков
            
            plotModel.Annotations.Clear(); // Очищаем все аннотации
            plotModel.InvalidatePlot(true); // Обновляем график, чтобы изменения отобразились
            
            for (int i = 0; i < peakData.GetLength(0); i++)
            {
                if (!float.IsNaN(peakData[i, 0]) && !float.IsNaN(peakData[i, 1]))
                {
                    float peakX = peakData[i, 0];
                    float peakY = peakData[i, 1];

                    // Создаем текстовую аннотацию для каждого пика
                    var annotation = new TextAnnotation
                    {
                        Text = $"({peakX}, {peakY})",   // Текст с координатами пика
                        TextPosition = new DataPoint(peakX, peakY),
                        Stroke = OxyColors.Transparent, // Без рамки
                        TextColor = OxyColors.Red,      // Цвет текста
                        FontSize = 12,
                    };

                    plotModel.Annotations.Add(annotation); // Добавляем аннотацию на график
                }
            }
            plotModel.InvalidatePlot(true); // Обновляем график после добавления аннотаций

        }

        public void hidePlot()
        {

            lineSeries.Points.Clear();
            lineSeries1.Points.Clear();
            plotModel.InvalidatePlot(true); // Обновляет график

        }

        public void savePlotPNG()
        {
            // Настройка экспорта
            var exporter = new PngExporter { Width = 950, Height = 600};


            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"; // Фильтр файлов
                saveFileDialog.Title = "Сохранить файл как";
                saveFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Data", "PNG"); // Устанавливает начальную папку
                saveFileDialog.FileName = "graph.png"; // Имя файла по умолчанию

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Экспорт в файл
                    exporter.ExportToFile(plotModel, filePath);

                    MessageBox.Show($"График сохранён в файл: {filePath}");
                }
                
            }
            
        }
    }
}
