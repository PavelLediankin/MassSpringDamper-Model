
namespace ModelVisualaizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.mass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeltaT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.TextBox();
            this.AddParameters = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.AddPos = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MinPos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(31, 28);
            this.mass.Margin = new System.Windows.Forms.Padding(2);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(76, 20);
            this.mass.TabIndex = 2;
            this.mass.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mass, кг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Velocity, м/с";
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(31, 117);
            this.V.Margin = new System.Windows.Forms.Padding(2);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(76, 20);
            this.V.TabIndex = 8;
            this.V.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DeltaT, с";
            // 
            // DeltaT
            // 
            this.DeltaT.Location = new System.Drawing.Point(190, 28);
            this.DeltaT.Margin = new System.Windows.Forms.Padding(2);
            this.DeltaT.Name = "DeltaT";
            this.DeltaT.Size = new System.Drawing.Size(76, 20);
            this.DeltaT.TabIndex = 10;
            this.DeltaT.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "StartTime, с";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(190, 75);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(76, 20);
            this.Start.TabIndex = 12;
            this.Start.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "EndTime, с";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(190, 117);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(76, 20);
            this.Stop.TabIndex = 14;
            this.Stop.Tag = "";
            this.Stop.Text = "60";
            // 
            // AddParameters
            // 
            this.AddParameters.Location = new System.Drawing.Point(31, 269);
            this.AddParameters.Margin = new System.Windows.Forms.Padding(2);
            this.AddParameters.Name = "AddParameters";
            this.AddParameters.Size = new System.Drawing.Size(113, 24);
            this.AddParameters.TabIndex = 16;
            this.AddParameters.Text = "Add model params";
            this.AddParameters.UseVisualStyleBackColor = true;
            this.AddParameters.Click += new System.EventHandler(this.AddParameters_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(157, 269);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(89, 24);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Position, м";
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(31, 72);
            this.Position.Margin = new System.Windows.Forms.Padding(2);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(76, 20);
            this.Position.TabIndex = 18;
            this.Position.Text = "0";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(31, 306);
            this.Result.Margin = new System.Windows.Forms.Padding(2);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(113, 24);
            this.Result.TabIndex = 20;
            this.Result.Text = "Show result";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // AddPos
            // 
            this.AddPos.Location = new System.Drawing.Point(336, 269);
            this.AddPos.Margin = new System.Windows.Forms.Padding(2);
            this.AddPos.Name = "AddPos";
            this.AddPos.Size = new System.Drawing.Size(113, 24);
            this.AddPos.TabIndex = 21;
            this.AddPos.Text = "Add forced positions";
            this.AddPos.UseVisualStyleBackColor = true;
            this.AddPos.Click += new System.EventHandler(this.AddPos_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(316, 24);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(89, 24);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save Config";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(316, 68);
            this.Load.Margin = new System.Windows.Forms.Padding(2);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(89, 24);
            this.Load.TabIndex = 23;
            this.Load.Text = "Load Config";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Minimal position, м";
            // 
            // MinPos
            // 
            this.MinPos.Location = new System.Drawing.Point(28, 165);
            this.MinPos.Margin = new System.Windows.Forms.Padding(2);
            this.MinPos.Name = "MinPos";
            this.MinPos.Size = new System.Drawing.Size(76, 20);
            this.MinPos.TabIndex = 24;
            this.MinPos.Text = "-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinPos);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddPos);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.AddParameters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeltaT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.V);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DeltaT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Stop;
        private System.Windows.Forms.Button AddParameters;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button AddPos;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MinPos;
    }
}

