using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson5
{
    /// <summary>
    /// OptionsForm controls all the option for the Calculator Form
    /// </summary>
    public partial class OptionsForm : Form
    {
        // Instance Variables
        private string _calculatorLayout;
        private bool _isSqureRootActive;
        private bool _isExponentActive;

        // Constuctor for OptioinForm
        public OptionsForm()
        {
            InitializeComponent();
        }

        // Properties

        public string calculatorLayout { get; set; }

        public bool isSqureRootActive { get; set; }

        public bool isExponentActive { get; set; }

        public CalculatorForm previousForm { get; set; } // refrenece to previous form ("CalculatorForm")

        // Private Methods

        // Event Handlers
        
        /// <summary>
        /// cancelButton Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _aceeptButton_Click(object sender, EventArgs e)
        {

            this.previousForm.calculatorFormLayout = this.calculatorLayout;
            this.Close();
        }

        private void _fontButton_Click(object sender, EventArgs e)
        {
            // Step 1. Show Dialog.
            DialogResult result = calculatorFontDialog.ShowDialog();
            // FontDialog result =;
        }

        private void _calculatorLayoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton calculatorRadioButton = sender as RadioButton;
            this.calculatorLayout = calculatorRadioButton.Text;
            Debug.WriteLine(this.calculatorLayout);
        }
    }
}
