using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculatorForm : Form
    {

        double weight;
        double height;
        double Bmi = 0.0;
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            weight = double.Parse(WeightTextBox.Text);
            height = double.Parse(HeightTextBox.Text);

            if (ImperialRadioButton.Checked)
            {
                Bmi = (weight * 703) / (height * height);
            }
            if (MetricRadioButton.Checked)
            {
                Bmi = (weight * 1) / (height * height);
            }

            if (Bmi < 18.5)
            {
                BMITextBox.Text = $"{Bmi:f2} \n Underweight";
            }
            else if (Bmi >= 18.5 && Bmi <= 24.9)
            {
                BMITextBox.Text = $"{Bmi:f2} \n Normal";
            }
            else if (Bmi >= 25 && Bmi <= 29.9)
            {
                BMITextBox.Text = $"{Bmi:f2} \n Overweight";
            }
            else if (Bmi >= 30)
            {
                BMITextBox.Text = $"{Bmi:f2} \n Obese";
            }
        }
    }
}
