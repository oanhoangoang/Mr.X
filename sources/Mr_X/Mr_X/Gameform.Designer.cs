namespace Mr_X
{
    partial class Gameform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameform));
            this.pnlGameInfoArea = new System.Windows.Forms.Panel();
            this.pnlPlayerInfoArea = new System.Windows.Forms.Panel();
            this.pnlGamePlayArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGameInfoArea
            // 
            this.pnlGameInfoArea.AutoSize = true;
            this.pnlGameInfoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameInfoArea.ForeColor = System.Drawing.Color.White;
            this.pnlGameInfoArea.Location = new System.Drawing.Point(818, 300);
            this.pnlGameInfoArea.Name = "pnlGameInfoArea";
            this.pnlGameInfoArea.Size = new System.Drawing.Size(395, 358);
            this.pnlGameInfoArea.TabIndex = 0;
            // 
            // pnlPlayerInfoArea
            // 
            this.pnlPlayerInfoArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerInfoArea.AutoSize = true;
            this.pnlPlayerInfoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlPlayerInfoArea.ForeColor = System.Drawing.Color.White;
            this.pnlPlayerInfoArea.Location = new System.Drawing.Point(818, 4);
            this.pnlPlayerInfoArea.Name = "pnlPlayerInfoArea";
            this.pnlPlayerInfoArea.Size = new System.Drawing.Size(395, 292);
            this.pnlPlayerInfoArea.TabIndex = 1;
            // 
            // pnlGamePlayArea
            // 
            this.pnlGamePlayArea.AutoSize = true;
            this.pnlGamePlayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGamePlayArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlGamePlayArea.Location = new System.Drawing.Point(4, 4);
            this.pnlGamePlayArea.Name = "pnlGamePlayArea";
            this.pnlGamePlayArea.Size = new System.Drawing.Size(809, 654);
            this.pnlGamePlayArea.TabIndex = 1;
            // 
            // Gameform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlPlayerInfoArea);
            this.Controls.Add(this.pnlGamePlayArea);
            this.Controls.Add(this.pnlGameInfoArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gameform";
            this.Text = "Mr.X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameInfoArea;
        private System.Windows.Forms.Panel pnlPlayerInfoArea;
        private System.Windows.Forms.Panel pnlGamePlayArea;
    }
}