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
    public partial class ChartsForm : Form
    {
        private readonly Form1 mainForm;
        private List<List<SimulationResult>> results = new List<List<SimulationResult>>();
        private List<LinkedList<SpringDamperParameters>> parametersGroups =
            new List<LinkedList<SpringDamperParameters>>();

        public ChartsForm(Form1 mainForm, List<List<SimulationResult>> results, 
            List<LinkedList<SpringDamperParameters>> parametersGroups)
        {
            InitializeComponent();
            this.results = results;
            this.mainForm = mainForm;
            this.parametersGroups = parametersGroups;
            for (var i = 0; i < this.results.Count; i++)
            {
                FillGraph(this.results[i], i, GetColor(i));
                listBox1.Items.Add($"Graph_{i}");
            }
            AddAxis();
            FormClosing += OnClosingEvent;
        }

        private void OnClosingEvent(object sender, EventArgs e) 
            => mainForm.Show();

        private void AddAxis()
        {
            chart1.ChartAreas[0].AxisX = new Axis() { Title = "шаг симуляции(кадр)" };
            chart1.ChartAreas[0].AxisY = new Axis() { Title = "x, м" };

            chart2.ChartAreas[0].AxisX = new Axis() { Title = "шаг симуляции(кадр)" };
            chart2.ChartAreas[0].AxisY = new Axis() { Title = "v, м/с" };
        }

        private void FillGraph(List<SimulationResult> results, int paramsNumber, Color color)
        {
            var x1 = new List<double>(results.Capacity);
            for (var i = 0; i < results.Count; i++)
                x1.Add(i);
            var y1 = results.Select(r => r.Position)
                .ToList();
            var y2 = results.Select(r => r.Velocity)
                .ToList();

            var s1 = new Series($"Position_{paramsNumber}");
            var s2 = new Series($"Velocity_{paramsNumber}");
            s1.ChartType = SeriesChartType.Spline;
            s2.ChartType = SeriesChartType.Spline;
            s2.Color = color;
            s1.Color = color;
            s1.Points.DataBindXY(x1, y1);
            s2.Points.DataBindXY(x1, y2);

            chart1.Series.Add(s1);
            chart2.Series.Add(s2);
        }

        private Color GetColor(int colorNumber)
        {
            Color color;
            switch (colorNumber)
            {
                case 0:
                    color = Color.Red;
                    break;
                case 1:
                    color = Color.Green;
                    break;
                case 2:
                    color = Color.Blue;
                    break;
                case 3:
                    color = Color.Purple;
                    break;
                case 4:
                    color = Color.Yellow;
                    break;
                default:
                    var rnd = new Random();
                    int r = rnd.Next(256);
                    int g = rnd.Next(256);
                    int b = rnd.Next(256);
                    color = Color.FromArgb(r, g, b);
                    break;
            }
            return color;
        }

        private void ResetPositions()
        {
            var form = new PositionsForm(this, positions);
            form.FormClosed += PositionsResetEvent;
            form.Show();
            Hide();
        }

        private void PositionsResetEvent(object sender, EventArgs e)
        {
            mainForm.ResetPositions(positions);
            BackToMainForm();
        }

        private void BackToMainForm()
        {
            mainForm.Resimulate();
            mainForm.Show();
            Close();
        }

        #region Interactions

        private List<PositionTime> positions;

        private void Back_Click(object sender, EventArgs e)
        {
            if (DeletePos.Checked)
            {
                positions = new List<PositionTime>();
                ResetPositions();
                return;
            }
            BackToMainForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var k = listBox1.SelectedIndex;
            if (k == -1)
                return;
            listBox1.Items.RemoveAt(k);
            parametersGroups.RemoveAt(k);
            results.RemoveAt(k);

            chart1.Series.Clear();
            chart2.Series.Clear();
            for (var i = 0; i < results.Count; i++)
            {
                FillGraph(results[i], i, GetColor(i));
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            results = new List<List<SimulationResult>>();
            mainForm.Show();
            mainForm.ResetAll();
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = listBox1.SelectedIndex;
            if (i < 0)
                return;
            var name = listBox1.SelectedItem.ToString();
            var form = new SegmentParamsGraphForm(name, parametersGroups[i]);
            form.Show();
        }

        #endregion
    }
}
