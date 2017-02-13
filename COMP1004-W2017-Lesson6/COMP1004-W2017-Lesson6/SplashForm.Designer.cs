namespace COMP1004_W2017_Lesson6
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.splashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.characterGeneratorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeLabel.Location = new System.Drawing.Point(87, 65);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(371, 42);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Marvel Super Heroes";
            // 
            // splashFormTimer
            // 
            this.splashFormTimer.Enabled = true;
            this.splashFormTimer.Interval = 1000;
            this.splashFormTimer.Tick += new System.EventHandler(this.splashFormTimer_Tick);
            // 
            // characterGeneratorLabel
            // 
            this.characterGeneratorLabel.AutoSize = true;
            this.characterGeneratorLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.characterGeneratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterGeneratorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.characterGeneratorLabel.Location = new System.Drawing.Point(134, 137);
            this.characterGeneratorLabel.Name = "characterGeneratorLabel";
            this.characterGeneratorLabel.Size = new System.Drawing.Size(263, 31);
            this.characterGeneratorLabel.TabIndex = 1;
            this.characterGeneratorLabel.Text = "Character Generator";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(534, 260);
            this.Controls.Add(this.characterGeneratorLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Timer splashFormTimer;
        private System.Windows.Forms.Label characterGeneratorLabel;
    }
}