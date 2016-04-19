namespace Mr_X
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ucIntro = new Mr_X.Intro();
            this.ucLevel = new Mr_X.Level();
            this.SuspendLayout();
            // 
            // ucIntro
            // 
            this.ucIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucIntro.Location = new System.Drawing.Point(0, 0);
            this.ucIntro.Name = "ucIntro";
            this.ucIntro.Size = new System.Drawing.Size(1217, 663);
            this.ucIntro.TabIndex = 0;
            this.ucIntro.Load += new System.EventHandler(this.intro1_Load);
            // 
            // ucLevel
            // 
            this.ucLevel.Location = new System.Drawing.Point(0, 0);
            this.ucLevel.Name = "ucLevel";
            this.ucLevel.Size = new System.Drawing.Size(1217, 663);
            this.ucLevel.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.ucIntro);
            this.Controls.Add(this.ucLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.ResumeLayout(false);

        }

        #endregion

        private Intro ucIntro;
        private Level ucLevel;


    }
}