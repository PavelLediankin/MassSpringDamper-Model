
using System.Windows.Forms.DataVisualization.Charting;

namespace ModelVisualaizer
{
    partial class PositionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddPos = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SaveConf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartC)).BeginInit();
            this.SuspendLayout();
            // 
            // chartC
            // 
            chartArea1.Name = "ChartArea1";
            this.chartC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartC.Legends.Add(legend1);
            this.chartC.Location = new System.Drawing.Point(52, 89);
            this.chartC.Name = "chartC";
            this.chartC.Size = new System.Drawing.Size(514, 308);
            this.chartC.TabIndex = 24;
            this.chartC.Text = "chart2";
            // 
            // AddPos
            // 
            this.AddPos.Location = new System.Drawing.Point(593, 154);
            this.AddPos.Name = "AddPos";
            this.AddPos.Size = new System.Drawing.Size(75, 23);
            this.AddPos.TabIndex = 25;
            this.AddPos.Text = "Add";
            this.AddPos.UseVisualStyleBackColor = true;
            this.AddPos.Click += new System.EventHandler(this.AddPos_Click);
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(677, 89);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(100, 20);
            this.Position.TabIndex = 26;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(677, 115);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 20);
            this.Time.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Position, м";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Шаг симуляции";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(593, 374);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 30;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(677, 374);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 31;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(677, 299);
            this.Load.Margin = new System.Windows.Forms.Padding(2);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(89, 24);
            this.Load.TabIndex = 33;
            this.Load.Text = "Load Config";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // SaveConf
            // 
            this.SaveConf.Location = new System.Drawing.Point(677, 255);
            this.SaveConf.Margin = new System.Windows.Forms.Padding(2);
            this.SaveConf.Name = "SaveConf";
            this.SaveConf.Size = new System.Drawing.Size(89, 24);
            this.SaveConf.TabIndex = 32;
            this.SaveConf.Text = "Save Config";
            this.SaveConf.UseVisualStyleBackColor = true;
            this.SaveConf.Click += new System.EventHandler(this.SaveConf_Click);
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.SaveConf);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.AddPos);
            this.Controls.Add(this.chartC);
            this.Name = "PositionsForm";
            this.Text = "PositionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartC;
        private System.Windows.Forms.Button AddPos;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button SaveConf;
    }
}