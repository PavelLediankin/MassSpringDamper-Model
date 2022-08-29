
using System.Windows.Forms.DataVisualization.Charting;

namespace ModelVisualaizer
{
    partial class SegmentParametersForm
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
            this.Finish = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pos1 = new System.Windows.Forms.TextBox();
            this.Positions = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Segment1 = new System.Windows.Forms.Label();
            this.AddPoint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Segment2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Segments = new System.Windows.Forms.Label();
            this.chartK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SaveConf = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartC)).BeginInit();
            this.SuspendLayout();
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(203, 260);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 26);
            this.Finish.TabIndex = 0;
            this.Finish.Text = "Завершить";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(66, 260);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(118, 26);
            this.Save.TabIndex = 1;
            this.Save.Text = "Добавить сегмент";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавляйте сегменты с разными константами модели ";
            // 
            // Pos1
            // 
            this.Pos1.Location = new System.Drawing.Point(80, 106);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(57, 20);
            this.Pos1.TabIndex = 3;
            // 
            // Positions
            // 
            this.Positions.AutoSize = true;
            this.Positions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Positions.Location = new System.Drawing.Point(77, 70);
            this.Positions.Name = "Positions";
            this.Positions.Size = new System.Drawing.Size(98, 15);
            this.Positions.TabIndex = 5;
            this.Positions.Text = "Точка сегмента";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(80, 160);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(57, 20);
            this.C.TabIndex = 8;
            this.C.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Damping const(C)";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(83, 209);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Stiffness(K)";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(80, 225);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(57, 20);
            this.K.TabIndex = 11;
            this.K.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Точки сегмента идут по возрастанию";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Когда вы добавите последнюю точку сегмента нажмите кнопку завершить";
            // 
            // Segment1
            // 
            this.Segment1.AutoSize = true;
            this.Segment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Segment1.Location = new System.Drawing.Point(143, 106);
            this.Segment1.Name = "Segment1";
            this.Segment1.Size = new System.Drawing.Size(223, 15);
            this.Segment1.TabIndex = 14;
            this.Segment1.Text = "Выберите стартовую точку сегмента";
            // 
            // AddPoint
            // 
            this.AddPoint.Location = new System.Drawing.Point(372, 106);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(116, 23);
            this.AddPoint.TabIndex = 15;
            this.AddPoint.Text = "Добавить точку";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Значения выходящие за пределы сегмента относятся к первому или последнему сегмент" +
    "у";
            // 
            // Segment2
            // 
            this.Segment2.AutoSize = true;
            this.Segment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Segment2.Location = new System.Drawing.Point(141, 109);
            this.Segment2.Name = "Segment2";
            this.Segment2.Size = new System.Drawing.Size(225, 15);
            this.Segment2.TabIndex = 17;
            this.Segment2.Text = "Выберите следующую точку сегмента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(272, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Создано сегментов";
            // 
            // Segments
            // 
            this.Segments.AutoSize = true;
            this.Segments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Segments.Location = new System.Drawing.Point(399, 144);
            this.Segments.Name = "Segments";
            this.Segments.Size = new System.Drawing.Size(14, 15);
            this.Segments.TabIndex = 19;
            this.Segments.Text = "0";
            // 
            // chartK
            // 
            chartArea1.Name = "ChartArea1";
            this.chartK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartK.Legends.Add(legend1);
            this.chartK.Location = new System.Drawing.Point(340, 312);
            this.chartK.Name = "chartK";
            this.chartK.Size = new System.Drawing.Size(302, 285);
            this.chartK.TabIndex = 20;
            this.chartK.Text = "chart1";
            // 
            // chartC
            // 
            chartArea2.Name = "ChartArea1";
            this.chartC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartC.Legends.Add(legend2);
            this.chartC.Location = new System.Drawing.Point(22, 312);
            this.chartC.Name = "chartC";
            this.chartC.Size = new System.Drawing.Size(302, 285);
            this.chartC.TabIndex = 21;
            this.chartC.Text = "chart2";
            // 
            // SaveConf
            // 
            this.SaveConf.Location = new System.Drawing.Point(546, 70);
            this.SaveConf.Name = "SaveConf";
            this.SaveConf.Size = new System.Drawing.Size(75, 26);
            this.SaveConf.TabIndex = 22;
            this.SaveConf.Text = "SaveConfig";
            this.SaveConf.UseVisualStyleBackColor = true;
            this.SaveConf.Click += new System.EventHandler(this.SaveConf_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(546, 106);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 26);
            this.Load.TabIndex = 23;
            this.Load.Text = "LoadConfig";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(372, 260);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(146, 26);
            this.Reset.TabIndex = 24;
            this.Reset.Text = "Сбросить параметры";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SegmentParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 654);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.SaveConf);
            this.Controls.Add(this.chartC);
            this.Controls.Add(this.chartK);
            this.Controls.Add(this.Segments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Segment2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.Segment1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.K);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Positions);
            this.Controls.Add(this.Pos1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Finish);
            this.Name = "SegmentParametersForm";
            this.Text = "SegmentParamsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pos1;
        private System.Windows.Forms.Label Positions;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Segment1;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Segment2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Segments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartC;
        private System.Windows.Forms.Button SaveConf;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Reset;
    }
}