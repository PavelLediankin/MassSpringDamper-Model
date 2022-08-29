using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MassSpringDamperModel;

namespace ModelVisualaizer
{
    public partial class Form1 : Form
    {
        private LinkedList<SpringDamperParameters> parameters = new LinkedList<SpringDamperParameters>();
        private List<LinkedList<SpringDamperParameters>> parametersGroups = 
            new List<LinkedList<SpringDamperParameters>>();
        private List<List<SimulationResult>> results = new List<List<SimulationResult>>();
        private List<PositionTime> positions;
        private bool simulationException = false;

        public Form1()
        {
            InitializeComponent();
            button1.Hide();
            Reset.Hide();
        }
        
        private void Simulate(LinkedList<SpringDamperParameters> parameters)
        {
            try
            {
                var settings = new SimulationSettings(
                   double.Parse(DeltaT.Text),
                   double.Parse(Start.Text),
                   double.Parse(Stop.Text));
                var m = double.Parse(mass.Text);
                var pos = double.Parse(Position.Text);
                var v = double.Parse(V.Text);
                var model = new MassSpringDamper(
                    parameters, m, pos, v);
                results.Add(Simulate(model, settings, pos, v));
            }
            catch (Exception e)
            {
                var dialog = new ThreadExceptionDialog(e);
                dialog.ShowDialog();
                simulationException = true;

            }
        }

        private List<SimulationResult> Simulate(MassSpringDamper model, SimulationSettings settings, double pos, double v)
        {
            var result = new List<SimulationResult>();
            result.Add(new SimulationResult(pos,v)); 
            if(positions == null)
                result.AddRange(model.Simulate(settings));
            else
                result.AddRange(model.Simulate(settings, positions));
            return result;
        }

        private void HideSettings()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            DeltaT.Hide();
            Start.Hide();
            Stop.Hide();

            mass.Hide();
            V.Hide();
            Position.Hide();
            MinPos.Hide();

            AddPos.Hide();
        }
   
        public void ResetAll()
        {
            parameters = new LinkedList<SpringDamperParameters>();
            parametersGroups = new List<LinkedList<SpringDamperParameters>>();
            results = new List<List<SimulationResult>>();
            positions = null;

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            DeltaT.Show();
            Start.Show();
            Stop.Show();

            mass.Show();
            V.Show();
            Position.Show();
            MinPos.Show();

            AddPos.Show();
            AddParameters.Show();
            Load.Show();
            button1.Hide();
            Reset.Hide();
        }

        public void ResetPositions(List<PositionTime> positions)
        {
            if (positions == null || positions.Count == 0)
                positions = null;
            this.positions = positions;
        }
   
        public void Resimulate()
        {
            results = new List<List<SimulationResult>>();
            foreach(var param in parametersGroups)
            {
                Simulate(param);
            }
        }

        #region Interactions

        private void button1_Click(object sender, EventArgs e)
        {
            if(parameters == null)
            {
                HideSettings();
                AddParameters.Show();
                button1.Hide();
                return;
            }
            Simulate(parameters);
            if (simulationException)
            {
                simulationException = false;
                return;
            }

            parametersGroups.Add(parameters);
            parameters = new LinkedList<SpringDamperParameters>();

            HideSettings();
            AddParameters.Show();
            button1.Hide();

            Load.Hide();
        }

        private void AddParameters_Click(object sender, EventArgs e)
        {
            var form = new SegmentParametersForm(this, parameters);
            form.Show();
            Hide();
            button1.Show();
            AddParameters.Hide();
            Reset.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            var form = new ChartsForm(this, results, parametersGroups);
            results = new List<List<SimulationResult>>();
            form.Show();
            Hide();
        }

        private void AddPos_Click(object sender, EventArgs e)
        {
            positions = new List<PositionTime>();
            var form = new PositionsForm(this, positions);
            form.Show();
            Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var dialog = ConfigsManager.ConfigSaveDialog;
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var config = new SettingsConfig()
                {
                    DeltaT = double.Parse(DeltaT.Text),
                    Start = double.Parse(Start.Text),
                    Stop = double.Parse(Stop.Text),
                    Mass = double.Parse(mass.Text),
                    Pos = double.Parse(Position.Text),
                    V = double.Parse(V.Text)
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
                var conf = ConfigsManager.LoadBaseSettings(dialog.FileName);
                if (conf == null)
                    return;
                DeltaT.Text = conf.DeltaT.ToString();
                Start.Text = conf.Start.ToString();
                Stop.Text = conf.Stop.ToString();
                mass.Text = conf.Mass.ToString();
                Position.Text = conf.Pos.ToString();
                V.Text = conf.V.ToString();
            }
        }

        #endregion
    }
}
