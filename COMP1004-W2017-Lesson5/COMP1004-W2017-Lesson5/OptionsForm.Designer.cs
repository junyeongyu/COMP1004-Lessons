namespace COMP1004_W2017_Lesson5
{
    partial class OptionsForm
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
            this.aceeptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.functionsGroupBox = new System.Windows.Forms.GroupBox();
            this.exponentCheckBox = new System.Windows.Forms.CheckBox();
            this.squreRootCheckBox = new System.Windows.Forms.CheckBox();
            this.layoutGroupBox = new System.Windows.Forms.GroupBox();
            this.scientificRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.fontButton = new System.Windows.Forms.Button();
            this.calculatorFontDialog = new System.Windows.Forms.FontDialog();
            this.functionsGroupBox.SuspendLayout();
            this.layoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aceeptButton
            // 
            this.aceeptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceeptButton.Location = new System.Drawing.Point(12, 212);
            this.aceeptButton.Name = "aceeptButton";
            this.aceeptButton.Size = new System.Drawing.Size(99, 38);
            this.aceeptButton.TabIndex = 0;
            this.aceeptButton.Text = "Accept";
            this.aceeptButton.UseVisualStyleBackColor = true;
            this.aceeptButton.Click += new System.EventHandler(this._aceeptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(173, 212);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 38);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // functionsGroupBox
            // 
            this.functionsGroupBox.Controls.Add(this.exponentCheckBox);
            this.functionsGroupBox.Controls.Add(this.squreRootCheckBox);
            this.functionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.functionsGroupBox.Name = "functionsGroupBox";
            this.functionsGroupBox.Size = new System.Drawing.Size(135, 100);
            this.functionsGroupBox.TabIndex = 2;
            this.functionsGroupBox.TabStop = false;
            this.functionsGroupBox.Text = "Functions";
            // 
            // exponentCheckBox
            // 
            this.exponentCheckBox.AutoSize = true;
            this.exponentCheckBox.Location = new System.Drawing.Point(16, 58);
            this.exponentCheckBox.Name = "exponentCheckBox";
            this.exponentCheckBox.Size = new System.Drawing.Size(96, 24);
            this.exponentCheckBox.TabIndex = 1;
            this.exponentCheckBox.Text = "Exponent";
            this.exponentCheckBox.UseVisualStyleBackColor = true;
            // 
            // squreRootCheckBox
            // 
            this.squreRootCheckBox.AutoSize = true;
            this.squreRootCheckBox.Location = new System.Drawing.Point(17, 31);
            this.squreRootCheckBox.Name = "squreRootCheckBox";
            this.squreRootCheckBox.Size = new System.Drawing.Size(110, 24);
            this.squreRootCheckBox.TabIndex = 0;
            this.squreRootCheckBox.Text = "Squre Root";
            this.squreRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // layoutGroupBox
            // 
            this.layoutGroupBox.Controls.Add(this.scientificRadioButton);
            this.layoutGroupBox.Controls.Add(this.standardRadioButton);
            this.layoutGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutGroupBox.Location = new System.Drawing.Point(164, 13);
            this.layoutGroupBox.Name = "layoutGroupBox";
            this.layoutGroupBox.Size = new System.Drawing.Size(135, 100);
            this.layoutGroupBox.TabIndex = 3;
            this.layoutGroupBox.TabStop = false;
            this.layoutGroupBox.Text = "Layout";
            // 
            // scientificRadioButton
            // 
            this.scientificRadioButton.AutoSize = true;
            this.scientificRadioButton.Location = new System.Drawing.Point(18, 58);
            this.scientificRadioButton.Name = "scientificRadioButton";
            this.scientificRadioButton.Size = new System.Drawing.Size(91, 24);
            this.scientificRadioButton.TabIndex = 1;
            this.scientificRadioButton.TabStop = true;
            this.scientificRadioButton.Text = "Scientific";
            this.scientificRadioButton.UseVisualStyleBackColor = true;
            this.scientificRadioButton.CheckedChanged += new System.EventHandler(this._calculatorLayoutRadioButton_CheckedChanged);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Checked = true;
            this.standardRadioButton.Location = new System.Drawing.Point(18, 26);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(93, 24);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.CheckedChanged += new System.EventHandler(this._calculatorLayoutRadioButton_CheckedChanged);
            // 
            // fontButton
            // 
            this.fontButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.fontButton.Location = new System.Drawing.Point(12, 144);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(99, 38);
            this.fontButton.TabIndex = 4;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this._fontButton_Click);
            // 
            // calculatorFontDialog
            // 
            this.calculatorFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorFontDialog.MaxSize = 24;
            this.calculatorFontDialog.MinSize = 10;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 262);
            this.ControlBox = false;
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.layoutGroupBox);
            this.Controls.Add(this.functionsGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.aceeptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.functionsGroupBox.ResumeLayout(false);
            this.functionsGroupBox.PerformLayout();
            this.layoutGroupBox.ResumeLayout(false);
            this.layoutGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aceeptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox functionsGroupBox;
        private System.Windows.Forms.CheckBox squreRootCheckBox;
        private System.Windows.Forms.CheckBox exponentCheckBox;
        private System.Windows.Forms.GroupBox layoutGroupBox;
        private System.Windows.Forms.RadioButton scientificRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.FontDialog calculatorFontDialog;
    }
}