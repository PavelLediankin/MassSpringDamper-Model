
using System.Windows.Forms.DataVisualization.Charting;

namespace ModelVisualaizer
{
    partial class SegmentParamsGraphForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraphName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartK)).BeginInit();
            this.SuspendLayout();
            // 
            // chartC
            // 
            chartArea1.Name = "ChartArea1";
            this.chartC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartC.Legends.Add(legend1);
            this.chartC.Location = new System.Drawing.Point(36, 98);
            this.chartC.Name = "chartC";
            this.chartC.Size = new System.Drawing.Size(367, 310);
            this.chartC.TabIndex = 23;
            this.chartC.Text = "chart2";
            // 
            // chartK
            // 
            chartArea2.Name = "ChartArea1";
            this.chartK.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartK.Legends.Add(legend2);
            this.chartK.Location = new System.Drawing.Point(419, 98);
            this.chartK.Name = "chartK";
            this.chartK.Size = new System.Drawing.Size(367, 310);
            this.chartK.TabIndex = 22;
            this.chartK.Text = "chart1";
            // 
            // GraphName
            // 
            this.GraphName.AutoSize = true;
            this.GraphName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.GraphName.Location = new System.Drawing.Point(33, 43);
            this.GraphName.Name = "GraphName";
            this.GraphName.Size = new System.Drawing.Size(55, 15);
            this.GraphName.TabIndex = 24;
            this.GraphName.Text = "Graph_1";
            // 
            // SegmentParamsGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 487);
            this.Controls.Add(this.GraphName);
            this.Controls.Add(this.chartC);
            this.Controls.Add(this.chartK);
            this.Name = "SegmentParamsGraphForm";
            this.Text = "SegmentParamsGraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartK;
        private System.Windows.Forms.Label GraphName;
    }
}