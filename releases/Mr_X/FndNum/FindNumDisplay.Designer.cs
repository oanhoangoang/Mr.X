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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindNumDisplay));
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.btnMediate = new System.Windows.Forms.Button();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtScoreToPass = new System.Windows.Forms.TextBox();
            this.txtYoung_Score = new System.Windows.Forms.TextBox();
            this.lblScoreToPass = new System.Windows.Forms.Label();
            this.lblYoungScore = new System.Windows.Forms.Label();
            this.txtFindNum = new System.Windows.Forms.TextBox();
            this.lblFindNum = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTimeToPlay = new System.Windows.Forms.Timer(this.components);
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlGameDisplayGray.SuspendLayout();
            this.pnlGameDisplayGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameDisplayGray
            // 
            this.pnlGameDisplayGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGameDisplayGray.Controls.Add(this.wmpSoundTrack);
            this.pnlGameDisplayGray.Controls.Add(this.btnMediate);
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 0;
            // 
            // btnMediate
            // 
            this.btnMediate.Enabled = false;
            this.btnMediate.Location = new System.Drawing.Point(0, 585);
            this.btnMediate.Name = "btnMediate";
            this.btnMediate.Size = new System.Drawing.Size(133, 69);
            this.btnMediate.TabIndex = 0;
            this.btnMediate.Text = "btnMediate";
            this.btnMediate.UseVisualStyleBackColor = true;
            this.btnMediate.Visible = false;
            this.btnMediate.Click += new System.EventHandler(this.btnMediate_Click);
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
            this.pnlGameDisplayGreen.Controls.Add(this.btnEnd);
            this.pnlGameDisplayGreen.Controls.Add(this.txtScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.txtYoung_Score);
            this.pnlGameDisplayGreen.Controls.Add(this.lblScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblYoungScore);
            this.pnlGameDisplayGreen.Controls.Add(this.txtFindNum);
            this.pnlGameDisplayGreen.Controls.Add(this.lblFindNum);
            this.pnlGameDisplayGreen.Controls.Add(this.lblIntro);
            this.pnlGameDisplayGreen.Controls.Add(this.lblTime);
            this.pnlGameDisplayGreen.Controls.Add(this.nudSecond);
            this.pnlGameDisplayGreen.Controls.Add(this.nudMinute);
            this.pnlGameDisplayGreen.Controls.Add(this.btnReset);
            this.pnlGameDisplayGreen.Controls.Add(this.btnStart);
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 2;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(251, 230);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 100);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtScoreToPass
            // 
            this.txtScoreToPass.Enabled = false;
            this.txtScoreToPass.Location = new System.Drawing.Point(132, 120);
            this.txtScoreToPass.Name = "txtScoreToPass";
            this.txtScoreToPass.Size = new System.Drawing.Size(100, 26);
            this.txtScoreToPass.TabIndex = 11;
            // 
            // txtYoung_Score
            // 
            this.txtYoung_Score.Enabled = false;
            this.txtYoung_Score.Location = new System.Drawing.Point(132, 88);
            this.txtYoung_Score.Name = "txtYoung_Score";
            this.txtYoung_Score.Size = new System.Drawing.Size(100, 26);
            this.txtYoung_Score.TabIndex = 10;
            // 
            // lblScoreToPass
            // 
            this.lblScoreToPass.AutoSize = true;
            this.lblScoreToPass.Location = new System.Drawing.Point(15, 123);
            this.lblScoreToPass.Name = "lblScoreToPass";
            this.lblScoreToPass.Size = new System.Drawing.Size(111, 20);
            this.lblScoreToPass.TabIndex = 9;
            this.lblScoreToPass.Text = "Score to pass:";
            // 
            // lblYoungScore
            // 
            this.lblYoungScore.AutoSize = true;
            this.lblYoungScore.Location = new System.Drawing.Point(17, 88);
            this.lblYoungScore.Name = "lblYoungScore";
            this.lblYoungScore.Size = new System.Drawing.Size(111, 20);
            this.lblYoungScore.TabIndex = 8;
            this.lblYoungScore.Text = "Young_Score:";
            // 
            // txtFindNum
            // 
            this.txtFindNum.Enabled = false;
            this.txtFindNum.Location = new System.Drawing.Point(132, 54);
            this.txtFindNum.Name = "txtFindNum";
            this.txtFindNum.Size = new System.Drawing.Size(100, 26);
            this.txtFindNum.TabIndex = 7;
            // 
            // lblFindNum
            // 
            this.lblFindNum.AutoSize = true;
            this.lblFindNum.Location = new System.Drawing.Point(17, 57);
            this.lblFindNum.Name = "lblFindNum";
            this.lblFindNum.Size = new System.Drawing.Size(98, 20);
            this.lblFindNum.TabIndex = 6;
            this.lblFindNum.Text = "Find number";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(17, 11);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(232, 20);
            this.lblIntro.TabIndex = 5;
            this.lblIntro.Text = "Game: Find number in the table";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(15, 156);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Location = new System.Drawing.Point(189, 152);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(43, 26);
            this.nudSecond.TabIndex = 3;
            // 
            // nudMinute
            // 
            this.nudMinute.Enabled = false;
            this.nudMinute.Location = new System.Drawing.Point(132, 152);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 26);
            this.nudMinute.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(134, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 100);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 230);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 100);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTimeToPlay
            // 
            this.tmrTimeToPlay.Interval = 1000;
            this.tmrTimeToPlay.Tick += new System.EventHandler(this.tmrTimeToPlay_Tick);
            // 
            // wmpSoundTrack
            // 
            this.wmpSoundTrack.Enabled = true;
            this.wmpSoundTrack.Location = new System.Drawing.Point(151, 599);
            this.wmpSoundTrack.Name = "wmpSoundTrack";
            this.wmpSoundTrack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundTrack.OcxState")));
            this.wmpSoundTrack.Size = new System.Drawing.Size(75, 48);
            this.wmpSoundTrack.TabIndex = 1;
            this.wmpSoundTrack.Visible = false;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindNumDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindNumDisplay_FormClosed);
            this.Load += new System.EventHandler(this.FindNumDisplay_Load);
            this.pnlGameDisplayGray.ResumeLayout(false);
            this.pnlGameDisplayGreen.ResumeLayout(false);
            this.pnlGameDisplayGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplayGray;
        private System.Windows.Forms.Panel pnlGameDisplayYellow;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
        private System.Windows.Forms.Button btnMediate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Timer tmrTimeToPlay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblFindNum;
        private System.Windows.Forms.TextBox txtFindNum;
        private System.Windows.Forms.Label lblScoreToPass;
        private System.Windows.Forms.Label lblYoungScore;
        private System.Windows.Forms.TextBox txtScoreToPass;
        private System.Windows.Forms.TextBox txtYoung_Score;
        private System.Windows.Forms.Button btnEnd;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
    }
}