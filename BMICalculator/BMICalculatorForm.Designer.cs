namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.UnitsGroupBox = new System.Windows.Forms.GroupBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.UnitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMICalculatorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UnitsLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UnitsGroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMIResultLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BMITextBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorLabel.AutoSize = true;
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.BMICalculatorLabel, 2);
            this.BMICalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(298, 73);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            this.BMICalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(3, 146);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(146, 73);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 219);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(146, 73);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Location = new System.Drawing.Point(3, 73);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(146, 73);
            this.UnitsLabel.TabIndex = 1;
            this.UnitsLabel.Text = "Units";
            this.UnitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitsGroupBox
            // 
            this.UnitsGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitsGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitsGroupBox.Location = new System.Drawing.Point(155, 76);
            this.UnitsGroupBox.Name = "UnitsGroupBox";
            this.UnitsGroupBox.Size = new System.Drawing.Size(146, 67);
            this.UnitsGroupBox.TabIndex = 3;
            this.UnitsGroupBox.TabStop = false;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(6, -3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(6, 32);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(155, 149);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(146, 38);
            this.HeightTextBox.TabIndex = 4;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(155, 222);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(146, 38);
            this.WeightTextBox.TabIndex = 4;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 295);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(146, 67);
            this.CalculateBMIButton.TabIndex = 5;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ResetButton.Location = new System.Drawing.Point(155, 295);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 67);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Location = new System.Drawing.Point(3, 365);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(146, 77);
            this.BMIResultLabel.TabIndex = 2;
            this.BMIResultLabel.Text = "Your BMI";
            this.BMIResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMITextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BMITextBox.Location = new System.Drawing.Point(155, 368);
            this.BMITextBox.Multiline = true;
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(146, 71);
            this.BMITextBox.TabIndex = 4;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.UnitsGroupBox.ResumeLayout(false);
            this.UnitsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.GroupBox UnitsGroupBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.TextBox BMITextBox;
    }
}

