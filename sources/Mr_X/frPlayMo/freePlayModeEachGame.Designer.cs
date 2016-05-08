namespace frPlayMo
{
    partial class freePlayModeEachGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(freePlayModeEachGame));
            this.picGame = new System.Windows.Forms.PictureBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.picFirework = new System.Windows.Forms.PictureBox();
            this.picMedal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedal)).BeginInit();
            this.SuspendLayout();
            // 
            // picGame
            // 
            this.picGame.Location = new System.Drawing.Point(504, 12);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(127, 86);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame.TabIndex = 9;
            this.picGame.TabStop = false;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(500, 110);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(0, 20);
            this.lblGame.TabIndex = 8;
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wmpSoundTrack
            // 
            this.wmpSoundTrack.Enabled = true;
            this.wmpSoundTrack.Location = new System.Drawing.Point(0, 639);
            this.wmpSoundTrack.Name = "wmpSoundTrack";
            this.wmpSoundTrack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundTrack.OcxState")));
            this.wmpSoundTrack.Size = new System.Drawing.Size(75, 23);
            this.wmpSoundTrack.TabIndex = 19;
            this.wmpSoundTrack.Visible = false;
            // 
            // picFirework
            // 
            this.picFirework.Location = new System.Drawing.Point(226, 12);
            this.picFirework.Name = "picFirework";
            this.picFirework.Size = new System.Drawing.Size(684, 302);
            this.picFirework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirework.TabIndex = 20;
            this.picFirework.TabStop = false;
            this.picFirework.Visible = false;
            // 
            // picMedal
            // 
            this.picMedal.Location = new System.Drawing.Point(310, 320);
            this.picMedal.Name = "picMedal";
            this.picMedal.Size = new System.Drawing.Size(517, 331);
            this.picMedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedal.TabIndex = 21;
            this.picMedal.TabStop = false;
            this.picMedal.Visible = false;
            // 
            // freePlayModeEachGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.picMedal);
            this.Controls.Add(this.picFirework);
            this.Controls.Add(this.wmpSoundTrack);
            this.Controls.Add(this.picGame);
            this.Controls.Add(this.lblGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "freePlayModeEachGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.freePlayModeEachGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.Label lblGame;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
        private System.Windows.Forms.PictureBox picFirework;
        private System.Windows.Forms.PictureBox picMedal;


    }
}