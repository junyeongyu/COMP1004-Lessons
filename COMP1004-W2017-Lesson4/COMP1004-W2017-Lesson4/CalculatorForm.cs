using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson4
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private string _operandOne;
        private string _operandTwo;
        private bool _isCalculatorClear;

        // Three. create a reference to the previous form
        public SplashForm previousForm; // against oop

        // CONSTRUCTORS 
        public CalculatorForm()
        {
            InitializeComponent();

            _clearCalculator();
        }

        /**
         * This method clears the calculator app and resets the variables
        */
        private void _clearCalculator()
        {
            this._operandOne = "";
            this._operandTwo = "";
            this._isCalculatorClear = true;
            resultRichTextBox.Text = "0";
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button;

            switch (calculatorButton.Tag as String)
            {
                case "Operand":
                    if (this._isCalculatorClear)
                    {
                        resultRichTextBox.Text = calculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else
                    {
                        resultRichTextBox.Text += calculatorButton.Text;
                    }
                    break;
                case "Operator":
                    break;
                case "Other":
                    break;
            }
        }

        private void CalulatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                // This shold exit the application
                // Application.Exit();
                // this.Close();
                this.previousForm.Close();
            } else
            {
                e.Cancel = true;
                //this.Show();
            }
        }
    }
}
