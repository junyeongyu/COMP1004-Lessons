using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //Program.calculateForm.Show(); // It is against oop principles.
            this.splashFormTimer.Enabled = false;
            this.Hide();

            // One. Instantiate the next form
            CalculatorForm calculatorForm = new CalculatorForm();

            // Two. Pas a reference to the current form to the next form.
            calculatorForm.previousForm = this;


            calculatorForm.Show();
        }
    }
}
