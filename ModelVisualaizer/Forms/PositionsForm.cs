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
    public partial class PositionsForm : Form
    {
        private readonly Form mainForm;
        private List<PositionTime> positions;
        private PositionsAdder positionsAdder;
        public PositionsForm(Form mainForm,List<PositionTime> positions)
        {
            InitializeComponent();
            this.positions = positions;
            this.mainForm = mainForm;
            positionsAdder = new PositionsAdder(positions);
            AddAxis();
            Save.Hide();

            FormClosing += OnClosingEvent;
        }

        private void OnClosingEvent(object sender, EventArgs e)
        {
            mainForm.Show();
        }

        private void AddAxis()
        {
            chartC.ChartAreas[0].AxisX = new Axis() { Title = "шаг симуляции(кадр)" };
            chartC.ChartAreas[0].AxisY = new Axis() { Title = "x, м" };
        }

        private void AddPos_Click(object sender, EventArgs e)
        {
            try
            {
                var pos = double.Parse(Position.Text);
                var time = int.Parse(Time.Text);
                positionsAdder.AddPosition(pos, time);
                SegmentParametersVisualizer.FillPositionsGraphs(positions, chartC);
                Save.Show();
            }
            catch (Exception ex)
            {
                var dialog = new ThreadExceptionDialog(ex);
                dialog.ShowDialog();
            }
        }

        private void Save_Click(object sender, EventArgs e)
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
                var config = new PositionsConfig()
                {
                    Positions = positions
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
                var conf = ConfigsManager.LoadPos(dialog.FileName);
                if (conf == null)
                    return;
                positions.Clear();
                foreach (var p in conf.Positions)
                {
                    positions.Add(p);
                }
                SegmentParametersVisualizer.FillPositionsGraphs(positions, chartC);
                Save.Show();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            positions.Clear();
            mainForm.Show();
            if (mainForm is Form1)
                (mainForm as Form1).ResetAll();
            Close();
        }
    }
}
