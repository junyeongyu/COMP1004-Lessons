namespace COMP1004_W2017_Lesson6
{
    partial class PowerForm
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
            this.powerListLabel = new System.Windows.Forms.Label();
            this.powerLlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // powerListLabel
            // 
            this.powerListLabel.AutoSize = true;
            this.powerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerListLabel.Location = new System.Drawing.Point(12, 32);
            this.powerListLabel.Name = "powerListLabel";
            this.powerListLabel.Size = new System.Drawing.Size(112, 25);
            this.powerListLabel.TabIndex = 0;
            this.powerListLabel.Text = "Power List";
            // 
            // powerLlistBox
            // 
            this.powerLlistBox.FormattingEnabled = true;
            this.powerLlistBox.Items.AddRange(new object[] {
            "Telepathy",
            "Body Armor",
            "Fight",
            "Telekiesis",
            "Electrical Bolt",
            "Fire Fall",
            "Combat Senses",
            "Radiation Resistance"});
            this.powerLlistBox.Location = new System.Drawing.Point(12, 70);
            this.powerLlistBox.MultiColumn = true;
            this.powerLlistBox.Name = "powerLlistBox";
            this.powerLlistBox.Size = new System.Drawing.Size(168, 108);
            this.powerLlistBox.TabIndex = 1;
            // 
            // PowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 222);
            this.Controls.Add(this.powerLlistBox);
            this.Controls.Add(this.powerListLabel);
            this.Name = "PowerForm";
            this.Text = "PowerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label powerListLabel;
        private System.Windows.Forms.ListBox powerLlistBox;
    }
}