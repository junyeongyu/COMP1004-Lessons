namespace COMP1004_W2017_Lesson5
{
    partial class CalculatorForm
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
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultRichTextBox.Location = new System.Drawing.Point(15, 12);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(218, 46);
            this.resultRichTextBox.TabIndex = 21;
            this.resultRichTextBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.backButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.divideButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.multiplyButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fiveButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.minusButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.oneButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.twoButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.plusButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.zeroButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dotButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.equalButton, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 274);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(111, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 48);
            this.backButton.TabIndex = 23;
            this.backButton.Tag = "Other";
            this.backButton.Text = "<B";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(57, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(48, 48);
            this.clearButton.TabIndex = 1;
            this.clearButton.Tag = "Other";
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(165, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(50, 48);
            this.divideButton.TabIndex = 24;
            this.divideButton.Tag = "Operator";
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(3, 57);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(48, 48);
            this.sevenButton.TabIndex = 25;
            this.sevenButton.Tag = "Operand";
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(57, 57);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(48, 48);
            this.eightButton.TabIndex = 26;
            this.eightButton.Tag = "Operand";
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(111, 57);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(48, 48);
            this.nineButton.TabIndex = 27;
            this.nineButton.Tag = "Operand";
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(165, 57);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(50, 48);
            this.multiplyButton.TabIndex = 28;
            this.multiplyButton.Tag = "Operator";
            this.multiplyButton.Text = "X";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(3, 111);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(48, 48);
            this.fourButton.TabIndex = 29;
            this.fourButton.Tag = "Operand";
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(57, 111);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(48, 48);
            this.fiveButton.TabIndex = 30;
            this.fiveButton.Tag = "Operand";
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(111, 111);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(48, 48);
            this.sixButton.TabIndex = 31;
            this.sixButton.Tag = "Operand";
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(165, 111);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(50, 48);
            this.minusButton.TabIndex = 32;
            this.minusButton.Tag = "Operator";
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(3, 165);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(48, 48);
            this.oneButton.TabIndex = 33;
            this.oneButton.Tag = "Operand";
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(57, 165);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(48, 48);
            this.twoButton.TabIndex = 34;
            this.twoButton.Tag = "Operand";
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(111, 165);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(48, 48);
            this.threeButton.TabIndex = 35;
            this.threeButton.Tag = "Operand";
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(165, 165);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(50, 48);
            this.plusButton.TabIndex = 36;
            this.plusButton.Tag = "Operator";
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(57, 219);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(48, 52);
            this.zeroButton.TabIndex = 38;
            this.zeroButton.Tag = "Operand";
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(111, 219);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(48, 52);
            this.dotButton.TabIndex = 39;
            this.dotButton.Tag = "Other";
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(165, 219);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(50, 52);
            this.equalButton.TabIndex = 40;
            this.equalButton.Tag = "Operator";
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // CalulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultRichTextBox);
            this.MaximizeBox = false;
            this.Name = "CalulatorForm";
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalulatorForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button equalButton;
    }
}

