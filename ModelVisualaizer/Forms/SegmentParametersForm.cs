using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MassSpringDamperModel;

namespace ModelVisualaizer
{
    public partial class SegmentParametersForm : Form
    {
        private readonly Form1 mainForm;
        private readonly LinkedList<SpringDamperParameters> parameters;
        private double previousPoint;

        public SegmentParametersForm(Form1 mainForm, LinkedList<SpringDamperParameters> parameters)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.parameters = parameters;
            AddAxis();
            chartC.Legends[0].Docking = Docking.Top;
            chartK.Legends[0].Docking = Docking.Top;

            C.Hide();
            K.Hide();
            Save.Hide();
            Finish.Hide();
            Segment2.Hide();

            FormClosing += OnClosingEvent;
        }

        private void OnClosingEvent(object sender, EventArgs e)
        {
            mainForm.Show();
        }

        private void AddAxis()
        {
            chartC.ChartAreas[0].AxisX = new Axis() { Title = "x, м/с" };
            chartC.ChartAreas[0].AxisY = new Axis() { Title = "F, Н" };

            chartK.ChartAreas[0].AxisX = new Axis() { Title = "x, м" };
            chartK.ChartAreas[0].AxisY = new Axis() { Title = "F, Н" };
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                var c = double.Parse(C.Text);
                var k = double.Parse(K.Text);
                var p1 = previousPoint;
                var p2 = double.Parse(Pos1.Text);
                previousPoint = p2;
                parameters.AddLast(new LinkedListNode<SpringDamperParameters>(
                    new SpringDamperParameters(
                        new WorkingSegment(p1, p2), c, k)));
                Segments.Text = $"{parameters.Count}";
                SegmentParametersVisualizer.FillParametersGraphs(parameters, chartK, chartC);
            }
            catch (Exception ex)
            {
                var dialog = new ThreadExceptionDialog(ex);
                dialog.ShowDialog();
            }
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            var correct = double.TryParse(Pos1.Text, out previousPoint);
            if (!correct)
                return;
            C.Show();
            K.Show();
            Save.Show();
            Finish.Show();
            Segment2.Show();

            Segment1.Hide();
            AddPoint.Hide();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void SaveConf_Click(object sender, EventArgs e)
        {
            var dialog = ConfigsManager.ConfigSaveDialog;
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var config = new SegmentsParametersConfig()
                {
                    Parameters = parameters.ToList()
                };
                ConfigsManager.Save(config, dialog.FileName);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            var dialog = ConfigsManager.ConfigLoadDialog;
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var conf = ConfigsManager.LoadParams(dialog.FileName);
                if (conf == null)
                    return;
                parameters.Clear();
                foreach(var n in conf.Parameters)
                {
                    parameters.AddLast(n);
                }
                SegmentParametersVisualizer.FillParametersGraphs(parameters, chartK, chartC);
                Segments.Text = $"{parameters.Count}";
                C.Show();
                K.Show();
                Save.Show();
                Finish.Show();
                Segment2.Show();

                Segment1.Hide();
                AddPoint.Hide();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            parameters.Clear();
            C.Hide();
            K.Hide();
            Save.Hide();
            Finish.Hide();
            Segment2.Hide();
            AddPoint.Show();
            Segments.Text = $"{parameters.Count}";

            chartC.Series.Clear();
            chartK.Series.Clear();
        }
    }
}
