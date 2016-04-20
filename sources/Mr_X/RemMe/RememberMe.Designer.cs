namespace RemMe
{
    partial class RememberMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RememberMe));
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.btnMediate = new System.Windows.Forms.Button();
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLevelOfGame = new System.Windows.Forms.Label();
            this.lblNameGame = new System.Windows.Forms.Label();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRule = new System.Windows.Forms.Label();
            this.lblOpportunity = new System.Windows.Forms.Label();
            this.txtOpportunity = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtYourScore = new System.Windows.Forms.TextBox();
            this.txtScoreToPass = new System.Windows.Forms.TextBox();
            this.lblScoreToPass = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.tmrTimeToWatch = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeToPlay = new System.Windows.Forms.Timer(this.components);
            this.pnlGameDisplayGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).BeginInit();
            this.pnlGameDisplayYellow.SuspendLayout();
            this.pnlGameDisplayGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameDisplayGray
            // 
            this.pnlGameDisplayGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGameDisplayGray.Controls.Add(this.picVictory);
            this.pnlGameDisplayGray.Controls.Add(this.btnMediate);
            this.pnlGameDisplayGray.Controls.Add(this.wmpSoundTrack);
            this.pnlGameDisplayGray.ForeColor = System.Drawing.Color.Black;
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 0;
            // 
            // picVictory
            // 
            this.picVictory.Location = new System.Drawing.Point(19, 70);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(768, 503);
            this.picVictory.TabIndex = 3;
            this.picVictory.TabStop = false;
            this.picVictory.Visible = false;
            // 
            // btnMediate
            // 
            this.btnMediate.Enabled = false;
            this.btnMediate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediate.Location = new System.Drawing.Point(373, 8);
            this.btnMediate.Name = "btnMediate";
            this.btnMediate.Size = new System.Drawing.Size(131, 56);
            this.btnMediate.TabIndex = 1;
            this.btnMediate.Text = "Màu";
            this.btnMediate.UseVisualStyleBackColor = true;
            this.btnMediate.Click += new System.EventHandler(this.btnMediate_Click);
            // 
            // wmpSoundTrack
            // 
            this.wmpSoundTrack.Enabled = true;
            this.wmpSoundTrack.Location = new System.Drawing.Point(0, 628);
            this.wmpSoundTrack.Name = "wmpSoundTrack";
            this.wmpSoundTrack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundTrack.OcxState")));
            this.wmpSoundTrack.Size = new System.Drawing.Size(75, 23);
            this.wmpSoundTrack.TabIndex = 0;
            this.wmpSoundTrack.Visible = false;
            // 
            // pnlGameDisplayYellow
            // 
            this.pnlGameDisplayYellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlGameDisplayYellow.Controls.Add(this.lblPosition);
            this.pnlGameDisplayYellow.Controls.Add(this.lblLevelOfGame);
            this.pnlGameDisplayYellow.ForeColor = System.Drawing.Color.Black;
            this.pnlGameDisplayYellow.Location = new System.Drawing.Point(818, 4);
            this.pnlGameDisplayYellow.Name = "pnlGameDisplayYellow";
            this.pnlGameDisplayYellow.Size = new System.Drawing.Size(395, 292);
            this.pnlGameDisplayYellow.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(39, 202);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(78, 20);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Chức vụ : ";
            // 
            // lblLevelOfGame
            // 
            this.lblLevelOfGame.AutoSize = true;
            this.lblLevelOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelOfGame.ForeColor = System.Drawing.Color.White;
            this.lblLevelOfGame.Location = new System.Drawing.Point(38, 159);
            this.lblLevelOfGame.Name = "lblLevelOfGame";
            this.lblLevelOfGame.Size = new System.Drawing.Size(82, 26);
            this.lblLevelOfGame.TabIndex = 5;
            this.lblLevelOfGame.Text = "Level : ";
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameGame.ForeColor = System.Drawing.Color.White;
            this.lblNameGame.Location = new System.Drawing.Point(15, 18);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(121, 20);
            this.lblNameGame.TabIndex = 4;
            this.lblNameGame.Text = "Trò chơi ghi nhớ";
            // 
            // pnlGameDisplayGreen
            // 
            this.pnlGameDisplayGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameDisplayGreen.Controls.Add(this.btnClose);
            this.pnlGameDisplayGreen.Controls.Add(this.lblNameGame);
            this.pnlGameDisplayGreen.Controls.Add(this.lblRule);
            this.pnlGameDisplayGreen.Controls.Add(this.lblOpportunity);
            this.pnlGameDisplayGreen.Controls.Add(this.txtOpportunity);
            this.pnlGameDisplayGreen.Controls.Add(this.btnStart);
            this.pnlGameDisplayGreen.Controls.Add(this.txtYourScore);
            this.pnlGameDisplayGreen.Controls.Add(this.txtScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblYourScore);
            this.pnlGameDisplayGreen.Controls.Add(this.lblTime);
            this.pnlGameDisplayGreen.Controls.Add(this.nudSecond);
            this.pnlGameDisplayGreen.Controls.Add(this.nudMinute);
            this.pnlGameDisplayGreen.ForeColor = System.Drawing.Color.Black;
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(219, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 75);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRule.ForeColor = System.Drawing.Color.White;
            this.lblRule.Location = new System.Drawing.Point(15, 51);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(361, 20);
            this.lblRule.TabIndex = 18;
            this.lblRule.Text = "Sau 5s, hãy tìm tất cả các ô trùng với màu yêu cầu";
            // 
            // lblOpportunity
            // 
            this.lblOpportunity.AutoSize = true;
            this.lblOpportunity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpportunity.ForeColor = System.Drawing.Color.White;
            this.lblOpportunity.Location = new System.Drawing.Point(296, 183);
            this.lblOpportunity.Name = "lblOpportunity";
            this.lblOpportunity.Size = new System.Drawing.Size(80, 20);
            this.lblOpportunity.TabIndex = 17;
            this.lblOpportunity.Text = "Lượt chọn";
            // 
            // txtOpportunity
            // 
            this.txtOpportunity.Enabled = false;
            this.txtOpportunity.Location = new System.Drawing.Point(315, 215);
            this.txtOpportunity.Name = "txtOpportunity";
            this.txtOpportunity.ReadOnly = true;
            this.txtOpportunity.Size = new System.Drawing.Size(45, 26);
            this.txtOpportunity.TabIndex = 16;
            this.txtOpportunity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(92, 276);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtYourScore
            // 
            this.txtYourScore.Enabled = false;
            this.txtYourScore.Location = new System.Drawing.Point(48, 215);
            this.txtYourScore.Name = "txtYourScore";
            this.txtYourScore.ReadOnly = true;
            this.txtYourScore.Size = new System.Drawing.Size(45, 26);
            this.txtYourScore.TabIndex = 13;
            this.txtYourScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScoreToPass
            // 
            this.txtScoreToPass.Enabled = false;
            this.txtScoreToPass.Location = new System.Drawing.Point(183, 215);
            this.txtScoreToPass.Name = "txtScoreToPass";
            this.txtScoreToPass.ReadOnly = true;
            this.txtScoreToPass.Size = new System.Drawing.Size(45, 26);
            this.txtScoreToPass.TabIndex = 12;
            this.txtScoreToPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblScoreToPass
            // 
            this.lblScoreToPass.AutoSize = true;
            this.lblScoreToPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScoreToPass.ForeColor = System.Drawing.Color.White;
            this.lblScoreToPass.Location = new System.Drawing.Point(146, 183);
            this.lblScoreToPass.Name = "lblScoreToPass";
            this.lblScoreToPass.Size = new System.Drawing.Size(115, 20);
            this.lblScoreToPass.TabIndex = 10;
            this.lblScoreToPass.Text = "Điểm qua vòng";
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblYourScore.ForeColor = System.Drawing.Color.White;
            this.lblYourScore.Location = new System.Drawing.Point(47, 183);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(46, 20);
            this.lblYourScore.TabIndex = 9;
            this.lblYourScore.Text = "Điểm";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(100, 112);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời gian :";
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Location = new System.Drawing.Point(234, 106);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(41, 26);
            this.nudSecond.TabIndex = 3;
            this.nudSecond.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudMinute
            // 
            this.nudMinute.Enabled = false;
            this.nudMinute.Location = new System.Drawing.Point(187, 106);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 26);
            this.nudMinute.TabIndex = 2;
            // 
            // tmrTimeToWatch
            // 
            this.tmrTimeToWatch.Interval = 1000;
            this.tmrTimeToWatch.Tick += new System.EventHandler(this.tmrTimeToWatch_Tick);
            // 
            // tmrTimeToPlay
            // 
            this.tmrTimeToPlay.Interval = 1000;
            this.tmrTimeToPlay.Tick += new System.EventHandler(this.tmrTimeToPlay_Tick);
            // 
            // RememberMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlGameDisplayGreen);
            this.Controls.Add(this.pnlGameDisplayYellow);
            this.Controls.Add(this.pnlGameDisplayGray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RememberMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RememberMe_FormClosed);
            this.Load += new System.EventHandler(this.RememberMe_Load);
            this.pnlGameDisplayGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).EndInit();
            this.pnlGameDisplayYellow.ResumeLayout(false);
            this.pnlGameDisplayYellow.PerformLayout();
            this.pnlGameDisplayGreen.ResumeLayout(false);
            this.pnlGameDisplayGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplayGray;
        private System.Windows.Forms.Panel pnlGameDisplayYellow;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
        private System.Windows.Forms.Button btnStart;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
        private System.Windows.Forms.Button btnMediate;
        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblScoreToPass;
        private System.Windows.Forms.TextBox txtScoreToPass;
        private System.Windows.Forms.TextBox txtYourScore;
        private System.Windows.Forms.Label lblOpportunity;
        private System.Windows.Forms.TextBox txtOpportunity;
        private System.Windows.Forms.Timer tmrTimeToWatch;
        private System.Windows.Forms.Timer tmrTimeToPlay;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLevelOfGame;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picVictory;
    }
}