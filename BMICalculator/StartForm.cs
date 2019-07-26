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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            StartFormTimer.Enabled = true;
        }

        private void StartFormTimer_Tick(object sender, EventArgs e)
        {
            StartFormTimer.Enabled = false;
            Program.Forms[FormName.BMI_FORM].Show();
            this.Hide();
        }
    }
}
