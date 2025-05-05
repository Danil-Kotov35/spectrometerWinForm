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
        private LineSeries lineSeries2;
        private LineSeries lineSeries3;
        private LineSeries lineSeries4;
        private LineSeries lineSeries5;
        private LineSeries lineSeriesLoadData;
        private LinearAxis xAxis;
        private LinearAxis yAxis;
        private int countLines = 0;

        public OxyPlotSchedule(float[,] data)
        {
            this.data = data;// получаем данные через конструктор
        }

        // метод отрисовывает таблицу на форме
        public PlotView Addplot()
        {

         
        plotModel = new PlotModel { Title = "", Background = OxyColor.Parse("#D5D5D5"), };//название графика

           
            xAxis = new LinearAxis // Настройка осей с сеткой
            {
                Position = AxisPosition.Bottom,
                Title = "Длина волны н / м",               
                MajorGridlineStyle = LineStyle.Solid,   // Основные линии сетки
                MinorGridlineStyle = LineStyle.Dot,      // Дополнительные линии сетки
                MinimumPadding = 0.1, //отступы для корректного отображения графика
                MaximumPadding = 0.1,
                
                
            };

            yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Интенсивность",
                MajorGridlineStyle = LineStyle.Solid,  // Основные линии сетки
                MinorGridlineStyle = LineStyle.Dot, // Дополнительные линии сетки
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                
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

            lineSeries2 = new LineSeries
            {
                Title = "Линия спектра",
                StrokeThickness = 1,
                

            };

            lineSeries3 = new LineSeries
            {
                Title = "Линия спектра",
                StrokeThickness = 1

            };

            lineSeries4 = new LineSeries
            {
                Title = "Линия спектра",
                StrokeThickness = 1

            };

            lineSeries5 = new LineSeries
            {
                Title = "Линия спектра",
                StrokeThickness = 1

            };

            lineSeriesLoadData = new LineSeries
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
            plotModel.Series.Add(lineSeries2);
            plotModel.Series.Add(lineSeries3);
            plotModel.Series.Add(lineSeries4);
            plotModel.Series.Add(lineSeries5);
            plotModel.Series.Add(lineSeriesLoadData);

            var plotView = new PlotView { Model = plotModel,  }; // Dock = DockStyle.Fill
            plotView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // Изменение размера
            plotView.Size = new Size(880, 490);

            // Изменение позиции
            plotView.Location = new Point(290, 50);
            
            // возвращаем дефолтные значения графика
            plotView.MouseDoubleClick += PlotView_MouseDoubleClick;
            
            // Создаём пользовательский контроллер
            var customController = new PlotController();

            // Настраиваем выделение области с использованием левой кнопки мыши
            customController.BindMouseDown(OxyMouseButton.Left, PlotCommands.ZoomRectangle);
            // Настраиваем отображение значений точки по средней кнопке мыши
            customController.BindMouseDown(OxyMouseButton.Middle, PlotCommands.Track);

            // Применяем контроллер
            plotView.Controller = customController;
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

        
        public void updatePlot(float[,] data,bool lineSeriesflag = false, bool XwaveLength = true,int qtLines = 1)
        {
            
            if (data[0, 1] != 0 && !lineSeriesflag) // 
            {
                
                if (countLines >= qtLines)
                {
                    // Очистка старых данных
                    lineSeries.Points.Clear();
                    lineSeries2.Points.Clear();
                    lineSeries3.Points.Clear();
                    lineSeries4.Points.Clear();
                    lineSeries5.Points.Clear();
                    countLines = 0;
                }
                
                lineSeriesLoadData.Points.Clear();
                plotModel.Annotations.Clear(); // Очищаем все аннотации
                this.data = data; // обновляем данные для корректного поиска пиков
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    float x = data[i, 0];
                    float y = data[i, 1];

                    switch(countLines)
                    {
                        case 0:
                            lineSeries.Points.Add(new DataPoint(x, y));
                            break;
                        case 1:
                            lineSeries2.Points.Add(new DataPoint(x, y));
                            break;
                        case 2:
                            lineSeries3.Points.Add(new DataPoint(x, y));
                            break;
                        case 3:
                            lineSeries4.Points.Add(new DataPoint(x, y));
                            break;
                        case 4:
                            lineSeries5.Points.Add(new DataPoint(x, y));
                            break;
                    }   
                }
                plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
                
                countLines++;
            }
            else
            {
                lineSeriesLoadData.Points.Clear();         // Очистка старых данных
                plotModel.Annotations.Clear(); // Очищаем все аннотации
                this.data = data; // обновляем данные для корректного поиска пиков
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    float x = data[i, 0];
                    float y = data[i, 1];

                    lineSeriesLoadData.Points.Add(new DataPoint(x, y));
                }
                
                plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
            }
            changeAxes();
            plotModel.InvalidatePlot(true);    // Обновление графика
        }

        public void changeAxes(bool XwaveLength = true)
        {
            if (XwaveLength == true)
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
            lineSeries2.Points.Clear();
            lineSeries3.Points.Clear();
            lineSeries4.Points.Clear();
            lineSeries5.Points.Clear();
            lineSeriesLoadData.Points.Clear();
            plotModel.Annotations.Clear();
            countLines = 0;
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
