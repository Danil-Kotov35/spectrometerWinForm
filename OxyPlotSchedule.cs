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

namespace WindowsFormsApp1
{
    internal class OxyPlotSchedule
    {

        private float[,] data;//данные со спектрометра
        
        private PlotModel plotModel;
        private PlotView plotView;
        private LineSeries lineSeries;

        public OxyPlotSchedule(float[,] data)
        {
            this.data = data;
        }

        public PlotView Addplot()
        {

        //название графика 
        plotModel = new PlotModel { Title = "" };

            // Настройка осей с сеткой
            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Длина волны н / м",              
                MajorGridlineStyle = LineStyle.Solid,   // Основные линии сетки
                MinorGridlineStyle = LineStyle.Dot,      // Дополнительные линии сетки
                MinimumPadding = 0.1,
                MaximumPadding = 0.1
            };

            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Интенсивность",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
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

            for (int i = 0; i < data.GetLength(0); i++)
            {
                float x = data[i, 0];
                float y = data[i, 1];

                lineSeries.Points.Add(new DataPoint(x, y));
            }

            // Добавляем серию в модель
            plotModel.Series.Add(lineSeries);
            


            var plotView = new PlotView { Model = plotModel,  }; // Dock = DockStyle.Fill
            plotView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // Изменение размера
            plotView.Size = new Size(600, 450);

            // Изменение позиции
            plotView.Location = new Point(300, 250);
            return plotView;
        }

        public void updatePlot(float[,] data)
        {
            lineSeries.Points.Clear();         // Очистка старых данных

            for (int i = 0; i < data.GetLength(0); i++)
            {
                float x = data[i, 0];
                float y = data[i, 1];

                lineSeries.Points.Add(new DataPoint(x, y));
            }

            plotModel.ResetAllAxes();         // Сброс осей для автоцентровки данных
            plotModel.InvalidatePlot(true);    // Обновление графика

        }
    }
}
