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

namespace COMP1004_W2017_Lesson6
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private string _operandOne;
        private string _operandTwo;
        private bool _isCalculatorClear;
        private string _calculatorFormLayout;

        // Three. create a reference to the previous form
        public Form previousForm; // against oop

        // CONSTRUCTORS 
        public CalculatorForm()
        {
            InitializeComponent();

            _clearCalculator();

        }

        // Properties
        public string calculatorFormLayout
        {
            get
            {
                return this._calculatorFormLayout;
            }
            set
            {
                this._calculatorFormLayout = value;
                Debug.WriteLine("Calculator Form Changed");
            }
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
            }
            else
            {
                e.Cancel = true;
                //this.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step One. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step Two. Show the about form with showDialog(a model method to display the form)
            aboutForm.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a Dialog REsult container
            DialogResult result;

            // step one
            OptionsForm optionsForm = new OptionsForm();

            // Step two. Set a reference to this "previous form" property of the options form to this form
            optionsForm.previousForm = this;

            optionsForm.calculatorLayout = this.calculatorFormLayout;

            // step three
            result = optionsForm.ShowDialog();

            Debug.WriteLine(result.ToString());
        }
    }
}
