namespace BMICalculator
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.StartFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BMICalculatorLabel.Location = new System.Drawing.Point(55, 132);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(195, 43);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LoadingLabel.Location = new System.Drawing.Point(55, 198);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(195, 43);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartFormTimer
            // 
            this.StartFormTimer.Interval = 3000;
            this.StartFormTimer.Tick += new System.EventHandler(this.StartFormTimer_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Timer StartFormTimer;
    }
}