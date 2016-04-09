namespace FndNum
{
    partial class FindNumDisplay
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
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGameDisplayGray
            // 
            this.pnlGameDisplayGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 0;
            // 
            // pnlGameDisplayYellow
            // 
            this.pnlGameDisplayYellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlGameDisplayYellow.Location = new System.Drawing.Point(818, 4);
            this.pnlGameDisplayYellow.Name = "pnlGameDisplayYellow";
            this.pnlGameDisplayYellow.Size = new System.Drawing.Size(395, 292);
            this.pnlGameDisplayYellow.TabIndex = 1;
            // 
            // pnlGameDisplayGreen
            // 
            this.pnlGameDisplayGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 2;
            // 
            // FindNumDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlGameDisplayGreen);
            this.Controls.Add(this.pnlGameDisplayYellow);
            this.Controls.Add(this.pnlGameDisplayGray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FindNumDisplay";
            this.Text = "FindNumDisplay";
            this.Load += new System.EventHandler(this.FindNumDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplayGray;
        private System.Windows.Forms.Panel pnlGameDisplayYellow;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
    }
}