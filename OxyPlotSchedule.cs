using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.Windows.Forms;
using System.Drawing;
using OxyPlot.Annotations;
using System.IO;
using System.Globalization;
using System.Linq;
using System;
using WindowsFormsApp1;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    // класс работающий с графиком
    internal class OxyPlotSchedule
    {

        private float[,] data;//данные со спектрометра
        private int threshold = 80;
        private Helper helper;
        private PlotModel plotModel;
        private PlotView plotView;
        private LineSeries lineSeries;
        private LineSeries lineSeries2;
        private LineSeries lineSeries3;
        private LineSeries lineSeries4;
        private LineSeries lineSeries5;
        private LineSeries lineSeriesLoadData;
        private LineSeries lineSeriesLoadData2;
        private LineSeries lineSeriesLoadData3;
        private LineSeries lineSeriesLoadData4;
        private LineSeries lineSeriesLoadData5;
        private LineSeries lineSeriesReferenceChart;
        private LinearAxis xAxis;
        private LinearAxis yAxis;
        private double xMin, xMax, yMin, yMax;
        private int countLines = 0;
        private int countLoadGraph = 0;
        private int countAnnotation = 0;//счетчик аннотаций которые может поставить пользоваталь на графике
        private string[] colorsForGraph = { "#000000", "#38D005", "#F0AC13", "#F00400", "#1317F0", "#D000F0" };

        private double xValue;
        private double yValue;


        private float[,] data1, data2, data3, data4, data5 = new float[512,2];
        
         

        public OxyPlotSchedule(float[,] data)
        {
            this.data = data;// получаем данные через конструктор
        }

        // метод отрисовывает таблицу на форме
        public PlotView addplot()
        { 
            plotModel = new PlotModel { Title = "", Background = OxyColor.Parse("#F0F0F0"), };//название графика
 
            xAxis = new LinearAxis // Настройка осей с сеткой
            {
                Position = AxisPosition.Bottom,
                Title = "Длина волны нм",               
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

            lineSeriesReferenceChart = new LineSeries
            {
                Title = "Эталонный график",
                StrokeThickness = 1,
                Color = OxyColor.FromRgb(255, 0, 0)
            };
            // Добавляем кривые в модель
            LineSeries[] lineSeriesArr = new LineSeries[5];
            LineSeries[] lineSeriesArrLoadData = new LineSeries[5];
            for (int i = 0; i < lineSeriesArr.Length; i++)
            {
                lineSeriesArr[i] = new LineSeries
                {
                    Title = $"Линия спектра {i+1}",
                    StrokeThickness = 1,
                    Color = OxyColor.Parse(colorsForGraph[i]),

                };
                lineSeriesArrLoadData[i] = new LineSeries
                {
                    Title = $"Загруженные данные {i+1}",
                    StrokeThickness = 1,
                };
                plotModel.Series.Add(lineSeriesArr[i]);
                plotModel.Series.Add(lineSeriesArrLoadData[i]);
            }

            plotModel.Series.Add(lineSeriesReferenceChart);

            lineSeries = lineSeriesArr[0];
            lineSeries2 = lineSeriesArr[1];
            lineSeries3 = lineSeriesArr[2];
            lineSeries4 = lineSeriesArr[3];
            lineSeries5 = lineSeriesArr[4];

            lineSeriesLoadData = lineSeriesArrLoadData[0];
            lineSeriesLoadData2 = lineSeriesArrLoadData[1];
            lineSeriesLoadData3 = lineSeriesArrLoadData[2];
            lineSeriesLoadData4 = lineSeriesArrLoadData[3];
            lineSeriesLoadData5 = lineSeriesArrLoadData[4];

            var plotView = new PlotView { Model = plotModel,  }; 
            plotView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // Изменение размера
            plotView.Size = new Size(880, 460);

            // Изменение позиции
            plotView.Location = new Point(290, 90);
            
            // возвращаем дефолтные значения графика
            plotView.MouseDoubleClick += plotViewMouseDoubleClick;
            
            // определение позиции мыши для отображения пользовательских координат
            plotView.MouseMove += detectMousePosition;


            // Создаём пользовательский контроллер
            var customController = new PlotController();

            // Настраиваем выделение области с использованием левой кнопки мыши
            customController.BindMouseDown(OxyMouseButton.Left, PlotCommands.ZoomRectangle);
            // Настраиваем отображение значений точки по средней кнопке мыши
            customController.BindMouseDown(OxyMouseButton.Middle, PlotCommands.PointsOnlyTrack);

            // Применяем контроллер
            plotView.Controller = customController;

            return plotView;
        }

        
        // метод для возвращения графика к дефолтным значениям по двойному щелчку мыши
        private void plotViewMouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Сбрасываем диапазон осей к исходным значениям
            plotModel.Axes[0].Minimum = double.NaN; // Для оси X
            plotModel.Axes[0].Maximum = double.NaN; // Для оси X

            plotModel.Axes[1].Minimum = double.NaN; // Для оси Y
            plotModel.Axes[1].Maximum = double.NaN; // Для оси Y

            plotModel.ResetAllAxes();
            // Обновляем график
            plotModel.InvalidatePlot(true);
        }

        
        public void updatePlot(bool fixedSize,float[,] data,string status = "load", bool XwaveLength = true,int qtLines = 1,int qtLoadGraph = 1)
        {
            if (fixedSize == true)
            {
                saveAxisBounds();
            }
                
            switch(status)
            {
                case "scan":
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
                    lineSeriesLoadData2.Points.Clear();
                    lineSeriesLoadData3.Points.Clear();
                    lineSeriesLoadData4.Points.Clear();
                    lineSeriesLoadData5.Points.Clear();
                    plotModel.Annotations.Clear(); // Очищаем все аннотации
                    this.data = data; // обновляем данные для корректного поиска пиков
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        float x = data[i, 0];
                        float y = data[i, 1];

                        switch (countLines)
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
                    break;
                case "load":
                    
                    if (countLoadGraph >= qtLoadGraph)
                    {
                        // Очистка старых данных
                        lineSeriesLoadData.Points.Clear();
                        lineSeriesLoadData2.Points.Clear();
                        lineSeriesLoadData3.Points.Clear();
                        lineSeriesLoadData4.Points.Clear();
                        lineSeriesLoadData5.Points.Clear();
                        countLoadGraph = 0;
                    }
                            
                    plotModel.Annotations.Clear(); // Очищаем все аннотации
                    this.data = data; // обновляем данные для корректного поиска пиков
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        float x = data[i, 0];
                        float y = data[i, 1];

                        switch (countLoadGraph)
                        {
                            case 0:
                                lineSeriesLoadData.Points.Add(new DataPoint(x, y));
                                break;
                            case 1:
                                lineSeriesLoadData2.Points.Add(new DataPoint(x, y));
                                break;
                            case 2:
                                lineSeriesLoadData3.Points.Add(new DataPoint(x, y));
                                break;
                            case 3:
                                lineSeriesLoadData4.Points.Add(new DataPoint(x, y));
                                break;
                            case 4:
                                lineSeriesLoadData5.Points.Add(new DataPoint(x, y));
                                break;
                        }
                        
                    }
                    
                    plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
                    countLoadGraph++;
                    break;

                case "reference":
                    lineSeriesReferenceChart.Points.Clear();
                    plotModel.Annotations.Clear(); // Очищаем все аннотации
                    this.data = data; // обновляем данные для корректного поиска пиков
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        float x = data[i, 0];
                        float y = data[i, 1];

                        lineSeriesReferenceChart.Points.Add(new DataPoint(x, y));
                    }

                    plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
                    break;

            }
            
            changeAxes();

            // фиксируем границы
            if(fixedSize == true)
            {
                fixedAxisBounds();     
            }
            else 
            {
                plotModel.Axes[0].Minimum = double.NaN; // Для оси X
                plotModel.Axes[0].Maximum = double.NaN; // Для оси X

                plotModel.Axes[1].Minimum = double.NaN; // Для оси Y
                plotModel.Axes[1].Maximum = double.NaN; // Для оси Y

            }
            plotModel.InvalidatePlot(true);    // Обновление графика
        }

        public void changeAxes(bool XwaveLength = true)
        {
            if (XwaveLength == true)
            {
                plotModel.Axes[0].Title = "Длина волны нм";
            }
            else
            {
                plotModel.Axes[0].Title = "Пиксели";
            }
            plotModel.InvalidatePlot(true);    // Обновление графика
        }

        public void addPeakAnnotations(int thresHold,int quantityPeak, int qtCount,int qtCountForDownolad)
        {
            var allData = new float[][,]
            {
                data, data1, data2, data3, data4, data5
            };
            plotModel.Annotations.Clear(); // Очищаем все аннотации
            
            for (int j = 0; j <= qtCount || j<= qtCountForDownolad; j++)
            {
                float[,] peakData = new PeakSearch(allData[j]).findPeaks(thresHold, quantityPeak);//поиск пиков
                
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
                            Text = $"({peakX.ToString("F1", CultureInfo.InvariantCulture)}\t {peakY.ToString("F0", CultureInfo.InvariantCulture)})",   // Текст с координатами пика
                            TextPosition = new DataPoint(peakX, peakY),
                            Stroke = OxyColors.Transparent, // Без рамки
                            TextColor = OxyColor.Parse(colorsForGraph[j]),      // Цвет текста
                            FontSize = 12,
                        };

                        plotModel.Annotations.Add(annotation); // Добавляем аннотацию на график
                    }
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
            lineSeriesLoadData2.Points.Clear();
            lineSeriesLoadData3.Points.Clear();
            lineSeriesLoadData4.Points.Clear();
            lineSeriesLoadData5.Points.Clear();         
            lineSeriesReferenceChart.Points.Clear();
            plotModel.Annotations.Clear();
            countLines = 0;
            countLoadGraph = 0;
            plotModel.InvalidatePlot(true); // Обновляет график

        }

        public void toggleVisibleReferenceChart()
        {
            lineSeriesReferenceChart.IsVisible = !lineSeriesReferenceChart.IsVisible; // Переключаем видимость
            plotModel.InvalidatePlot(true);               // Обновляем график
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

        public void saveReportPng(string filePath, float[,] dataSt, float[,] dataASt)
        {
            

            float[,] cutDataSt = new Helper().findArea(dataSt);
            float[,] cutDataASt = new Helper().findArea(dataASt);


            var exporter = new PngExporter { Width = 950, Height = 600 };
            var poSt = new PolygonAnnotation();
            
            for (int i = 0; i < cutDataSt.GetLength(0); i++)
            {
                poSt.Points.Add(new DataPoint(cutDataSt[i, 0], cutDataSt[i, 1]));
            }
            poSt.Points.Add(new DataPoint(cutDataSt[cutDataSt.GetLength(0) - 1, 0], cutDataSt[0, 1]));
            poSt.Fill = OxyColor.FromArgb(50, 240, 116, 39);

            var poASt = new PolygonAnnotation();
            for (int i = 0; i < cutDataASt.GetLength(0); i++)
            {
                poASt.Points.Add(new DataPoint(cutDataASt[i, 0], cutDataASt[i, 1]));
            }
            poASt.Points.Add(new DataPoint(cutDataASt[cutDataASt.GetLength(0) - 1, 0], cutDataASt[0, 1]));
            poASt.Fill = OxyColor.FromArgb(50, 80, 200, 120);

            float Ax = cutDataASt[0, 0];         

            float Bx = cutDataASt[cutDataASt.GetLength(0)-1, 0];

            float Cx = cutDataSt[0, 0];         

            float Dx = cutDataSt[cutDataSt.GetLength(0) - 1, 0];
            


            // Создаем текстовую аннотацию для каждого пика
            TextAnnotation A = new TextAnnotation
            {
                Text = $"A",   // Текст с координатами пика
                TextPosition = new DataPoint(Ax, new Helper().findConditionalZero(dataASt) - 420),
                Stroke = OxyColors.Transparent, // Без рамки
                TextColor = OxyColors.Black,      // Цвет текста
                FontSize = 16,
            };

            TextAnnotation B = new TextAnnotation
            {
                Text = $"B",   // Текст с координатами пика
                TextPosition = new DataPoint(Bx, new Helper().findConditionalZero(dataASt) - 420),
                Stroke = OxyColors.Transparent, // Без рамки
                TextColor = OxyColors.Black,      // Цвет текста
                FontSize = 16,
            };

            TextAnnotation C = new TextAnnotation
            {
                Text = $"C",   // Текст с координатами пика
                TextPosition = new DataPoint(Cx, new Helper().findConditionalZero(dataSt) - 420),
                Stroke = OxyColors.Transparent, // Без рамки
                TextColor = OxyColors.Black,      // Цвет текста
                FontSize = 16,
            };

            TextAnnotation D = new TextAnnotation
            {
                Text = $"D",   // Текст с координатами пика
                TextPosition = new DataPoint(Dx, new Helper().findConditionalZero(dataSt) - 420),
                Stroke = OxyColors.Transparent, // Без рамки
                TextColor = OxyColors.Black,      // Цвет текста
                FontSize = 16,
            };

            // Добавляем аннотацию на график
            plotModel.Annotations.Add(A);
            plotModel.Annotations.Add(B);
            plotModel.Annotations.Add(C);
            plotModel.Annotations.Add(D);
            plotModel.Annotations.Add(poSt);
            plotModel.Annotations.Add(poASt);
            plotModel.InvalidatePlot(true);

            exporter.ExportToFile(plotModel, filePath);
        }


        public void CreateImageWithText(string chartPath, string outputPath, float[,] dataSt, float[,] dataASt)
        {
            // Загружаем исходный график
            using (Bitmap chartImage = new Bitmap(chartPath))
            {
                int additionalHeight = 200; // Дополнительная высота под текст и формулы
                int width = chartImage.Width;
                int height = chartImage.Height + additionalHeight;

                // Создаем новое изображение
                using (Bitmap finalImage = new Bitmap(width, height))
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.White); // Фон белый

                    // Рисуем график
                    g.DrawImage(chartImage, new Point(0, 0));

                    // Настраиваем шрифт
                    Font textFont = new Font("Arial", 16, FontStyle.Regular);
                    Brush textBrush = Brushes.Black;


                    float[,] cutDataSt = new Helper().findArea(dataSt);
                    double areaSt = new Helper().CalculateArea(cutDataSt);


                    float[,] cutDataASt = new Helper().findArea(dataASt);
                    double areaASt = new Helper().CalculateArea(cutDataASt);

                    float Ax = cutDataASt[0, 0];
                   
                    float Bx = cutDataASt[cutDataASt.GetLength(0) - 1, 0];
                    
                    float Cx = cutDataSt[0, 0];
                    
                    float Dx = cutDataSt[cutDataSt.GetLength(0) - 1, 0];
                    


                    

                    // Рисуем текст
                    g.DrawString($"площадь", textFont, textBrush, new PointF(10, chartImage.Height + 10));
                    g.DrawString($" ASt", textFont, new SolidBrush(Color.FromArgb(80, 200, 120)), new PointF(100, chartImage.Height + 10));
                    g.DrawString($" = {areaASt.ToString("F1", new CultureInfo("ru-RU"))}", textFont, textBrush, new PointF(140, chartImage.Height + 10));
                    

                    g.DrawString($"площадь", textFont, textBrush, new PointF(10, chartImage.Height + 60));
                    g.DrawString($" St", textFont, new SolidBrush(Color.FromArgb(240, 116, 39)), new PointF(100, chartImage.Height + 60));
                    g.DrawString($" = {areaSt.ToString("F1", new CultureInfo("ru-RU"))}", textFont, textBrush, new PointF(125, chartImage.Height + 60));


                    g.DrawString($"A = {Ax}", textFont, textBrush, new PointF(400, chartImage.Height + 10));
                    g.DrawString($"B = {Bx}", textFont, textBrush, new PointF(400, chartImage.Height + 60));
                    g.DrawString($"C = {Cx}", textFont, textBrush, new PointF(400, chartImage.Height + 110));
                    g.DrawString($"D = {Dx}", textFont, textBrush, new PointF(400, chartImage.Height + 160));


                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawString($" ASt", textFont, new SolidBrush(Color.FromArgb(80, 200, 120)), new PointF(10, chartImage.Height + 120));
                    g.DrawLine(pen, 15, chartImage.Height + 145, 60, chartImage.Height + 145);
                    g.DrawString($" St", textFont, new SolidBrush(Color.FromArgb(240, 116, 39)), new PointF(16, chartImage.Height + 150));
                    g.DrawString($"=", textFont, textBrush, new PointF(65, chartImage.Height + 134));
                    g.DrawString($"{(areaSt / areaASt).ToString("F5", new CultureInfo("ru-RU"))}", textFont, textBrush, new PointF(80, chartImage.Height + 134));

                    g.DrawString($"Порог А,В = {new Helper().findConditionalZero(dataASt).ToString("F0", new CultureInfo("ru-RU"))}", textFont, textBrush, new PointF(700, chartImage.Height + 10));
                    g.DrawString($"Порог C,D = {new Helper().findConditionalZero(dataSt).ToString("F0", new CultureInfo("ru-RU"))}", textFont, textBrush, new PointF(700, chartImage.Height + 60));
                    // Сохраняем итоговое изображение
                    finalImage.Save(outputPath);
                }
            }
        }



        private void saveAxisBounds()
        {
            if (xAxis != null && yAxis != null)
            {
                xMin = xAxis.ActualMinimum;
                xMax = xAxis.ActualMaximum;
                //yMin = yAxis.ActualMinimum;
                //yMax = yAxis.ActualMaximum;
            }

        }
        private void fixedAxisBounds()
        {
            if (xAxis != null && yAxis != null)
            {
                xAxis.Minimum = xMin;
                xAxis.Maximum = xMax;
                //yAxis.Minimum = yMin;
                //yAxis.Maximum = yMax;
            }
        }

        public void dataForSearchPeaks(float[,] data,int qtCount)
        {
            
            switch (qtCount)
            {
                case 1:
                    float[,] dataTemp1 = new float[512,2];                    
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            dataTemp1[i, j] = data[i, j];
                        }
                        
                    }
                    data1 = dataTemp1;
                    break;
                case 2:
                    float[,] dataTemp2 = new float[512, 2];
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            dataTemp2[i, j] = data[i, j];
                            
                        }
                        
                    }
                    data2 = dataTemp2;
                    break;
                case 3:
                    float[,] dataTemp3 = new float[512, 2];
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            dataTemp3[i, j] = data[i, j];
                        }
                    }
                    data3 = dataTemp3;
                    break;
                case 4:
                    float[,] dataTemp4 = new float[512, 2];
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            dataTemp4[i, j] = data[i, j];
                        }
                    }
                    data4 = dataTemp4;
                    break;
                case 5:
                    float[,] dataTemp5 = new float[512, 2];
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            dataTemp5[i, j] = data[i, j];
                        }
                    }
                    data5 = dataTemp5;
                    break;
            }
            
            
        }



        private void detectMousePosition(object sender, MouseEventArgs e)
        {
            // Преобразуем экранные координаты в координаты графика
            // Получаем оси
            var xAxis = plotModel.DefaultXAxis;
            var yAxis = plotModel.DefaultYAxis;

            if (xAxis != null && yAxis != null)
            {
                //Преобразуем экранные координаты в координаты данных
                xValue = xAxis.InverseTransform(e.X);
                yValue = yAxis.InverseTransform(e.Y);
            }
            

        }

        public void plotViewKeyDown()
        {

                if(countAnnotation < 4)
                {

                    // Создаем точку данных
                    var dataPoint = new DataPoint(xValue, yValue);

                    // Добавляем аннотацию для отображения координат
                    var annotation = new TextAnnotation
                    {
                        Text = $"({dataPoint.X:F2}, {dataPoint.Y:F2})",
                        TextPosition = new DataPoint(xValue, yValue),
                        Stroke = OxyColors.Transparent, // Без рамки
                        TextColor = OxyColor.Parse("#000"), // Цвет текста
                        FontSize = 12,
                    };

                    plotModel.Annotations.Add(annotation);
                    countAnnotation++;
                }
                else
                {
                    plotModel.Annotations.Clear();
                    countAnnotation = 0;
                }
                
                plotModel.InvalidatePlot(true); // Обновляем график
            
        }

    }
}



