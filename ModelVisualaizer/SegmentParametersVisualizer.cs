using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MassSpringDamperModel;

namespace ModelVisualaizer
{
    public class SegmentParametersVisualizer
    {
        public SegmentParametersVisualizer()
        {
        }

        public static void FillPositionsGraphs(List<PositionTime> positions, Chart chart)
        {
            var x1 = new List<double>();
            var y1 = new List<double>();
            foreach (var p in positions)
            {
                x1.Add(p.Time);
                y1.Add(p.Position);
            }

            chart.Series.Clear();

            var s1 = new Series($"Positions");
            s1.ChartType = SeriesChartType.Point;
            s1.Color = Color.Blue;
            s1.Points.DataBindXY(x1, y1);

            chart.Series.Add(s1);
        }

        public static void FillParametersGraphs(LinkedList<SpringDamperParameters> parameters, Chart chartK, Chart chartC)
        {
            var firstPoint = true;
            var x1 = new List<double>();
            var y1 = new List<double>();
            var y2 = new List<double>();
            foreach (var n in parameters)
            {
                if (firstPoint)
                {
                    var t1 = n.WorkingSegment.StartPosition;
                    x1.Add(t1);
                    y1.Add(n.K * t1);
                    y2.Add(n.C * t1);
                    firstPoint = false;
                }
                var t2 = n.WorkingSegment.EndPosition;
                x1.Add(t2);
                y1.Add(n.K * t2);
                y2.Add(n.C * t2);
            }

            FillCharts(chartK, chartC, x1, y1, y2);
        }

        private static void FillCharts(Chart chartK, Chart chartC, List<double> x1, List<double> y1, List<double> y2)
        {
            chartK.Series.Clear();
            chartC.Series.Clear();

            var s1 = new Series($"Stiffness(K)");
            var s2 = new Series($"Damping(C)");
            s1.ChartType = SeriesChartType.FastLine;
            s2.ChartType = SeriesChartType.FastLine;
            s2.Color = Color.Red;
            s1.Color = Color.Blue;
            s1.Points.DataBindXY(x1, y1);
            s2.Points.DataBindXY(x1, y2);

            chartK.Series.Add(s1);
            chartC.Series.Add(s2);
        }
    }
}
