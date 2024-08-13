using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.ViewModels
{
    public class Charts
    {
        public ObservableCollection<ISeries> Series { get; set; }


        //Tạo ra các biểu đồ mô phỏng
        public Charts()
        {
            Series1 = new ISeries[]
            {
                new ColumnSeries<int>
                {
                    Values = new List<int> { 4, 6, 7, 5, 9, 10 },
                    Name = "Series 1",
                    Fill = new SolidColorPaint(SKColors.Cyan) 
                }
            };
       
            Series2 = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new List<double> { 63.42, 24.57, 78.92, 15.63, 93.15, 48.29, 82.74, 55.48, 70.81, 27.34, 61.87, 34.52, 79.29, 16.94, 45.81, 90.55, 11.76, 67.12, 52.47, 88.23, 33.60, 98.72, 73.54, 22.80, 56.13, 62.45, 85.41, 37.72, 29.87, 94.06, 50.23, 40.95, 18.30, 66.19, 21.77, 77.44, 60.22, 84.13, 32.58, 99.48, 47.95, 74.62, 26.40, 19.82, 68.54, 30.72, 92.77, 54.18},                 
                    Name = "Series 2",
                    LineSmoothness = 0.2f,
                    GeometrySize = 0.1,
                    Fill = null,
                    Stroke = new SolidColorPaint(SKColors.Aquamarine)
                }
            };
         
            Series3 = new ISeries[]
            {
                new LineSeries<int>
                {
                    Values = new List<int> { 56, 23, 71, 89, 15, 92, 37, 66, 84, 43, 18, 77, 50, 29, 95, 64, 80, 47, 99, 32, 40, 20, 53, 62, 75, 48, 90, 83, 38, 54, 72, 19, 61, 86, 31, 57, 93, 74, 21, 46, 58, 67, 26, 16, 60, 45, 81, 28, 69, 12, 39, 97},
                    Name = "Series 3",
                    LineSmoothness = 0.5f,
                    GeometrySize= 0.1,
                    Fill = null,
                    Stroke = new SolidColorPaint(SKColors.Green) 
                },
                new ColumnSeries<int>
                {
                    Values = new List<int> { 3, 4, 6, 2, 7, 5 },
                    Name = "Additional Column",
                    Fill = new SolidColorPaint(SKColors.Orange)
                }
            };

            Series4 = new ISeries[]
            {
                new ScatterSeries<int>
                {
                    Values = new List<int> { 4, 6, 7, 5, 9, 10, 56, 23, 71, 89, 15, 92, 37, 66, 84, 43, 18, 77, 50, 29, 95, 64, 80, 47, 99, 32  },
                    Fill = new SolidColorPaint(SKColors.Cyan),               
                    GeometrySize = 10 
                }
            };
        }

        public ISeries[] Series1 { get; set; }
        public ISeries[] Series2 { get; set; }
        public ISeries[] Series3 { get; set; }
        public ISeries[] Series4 { get; set; }
    }
}
