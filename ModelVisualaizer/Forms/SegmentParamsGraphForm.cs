using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MassSpringDamperModel;

namespace ModelVisualaizer
{
    public partial class SegmentParamsGraphForm : Form
    {
        public SegmentParamsGraphForm(string graphName, LinkedList<SpringDamperParameters> parameters)
        {
            InitializeComponent();
            GraphName.Text = graphName;
            SegmentParametersVisualizer.FillParametersGraphs(parameters, chartK, chartC);

            AddAxis();
            chartC.Legends[0].Docking = Docking.Top;
            chartK.Legends[0].Docking = Docking.Top;
        }

        private void AddAxis()
        {
            chartC.ChartAreas[0].AxisX = new Axis() { Title = "x, м/с" };
            chartC.ChartAreas[0].AxisY = new Axis() { Title = "F, Н" };

            chartK.ChartAreas[0].AxisX = new Axis() { Title = "x, м" };
            chartK.ChartAreas[0].AxisY = new Axis() { Title = "F, Н" };
        }
    }
}
