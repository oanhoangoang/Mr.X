namespace Mr_X
{
    partial class Playing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGamePlay = new System.Windows.Forms.Panel();
            this.pnlPlayerInfo = new System.Windows.Forms.Panel();
            this.pnlGameInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGamePlay
            // 
            this.pnlGamePlay.AutoSize = true;
            this.pnlGamePlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGamePlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlGamePlay.Location = new System.Drawing.Point(4, 4);
            this.pnlGamePlay.Name = "pnlGamePlay";
            this.pnlGamePlay.Size = new System.Drawing.Size(809, 654);
            this.pnlGamePlay.TabIndex = 0;
            // 
            // pnlPlayerInfo
            // 
            this.pnlPlayerInfo.AutoSize = true;
            this.pnlPlayerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlPlayerInfo.ForeColor = System.Drawing.Color.White;
            this.pnlPlayerInfo.Location = new System.Drawing.Point(818, 4);
            this.pnlPlayerInfo.Name = "pnlPlayerInfo";
            this.pnlPlayerInfo.Size = new System.Drawing.Size(395, 292);
            this.pnlPlayerInfo.TabIndex = 1;
            // 
            // pnlGameInfo
            // 
            this.pnlGameInfo.AutoSize = true;
            this.pnlGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameInfo.ForeColor = System.Drawing.Color.White;
            this.pnlGameInfo.Location = new System.Drawing.Point(818, 300);
            this.pnlGameInfo.Name = "pnlGameInfo";
            this.pnlGameInfo.Size = new System.Drawing.Size(395, 358);
            this.pnlGameInfo.TabIndex = 1;
            // 
            // Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGameInfo);
            this.Controls.Add(this.pnlPlayerInfo);
            this.Controls.Add(this.pnlGamePlay);
            this.Name = "Playing";
            this.Size = new System.Drawing.Size(1217, 663);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGamePlay;
        private System.Windows.Forms.Panel pnlPlayerInfo;
        private System.Windows.Forms.Panel pnlGameInfo;
    }
}
