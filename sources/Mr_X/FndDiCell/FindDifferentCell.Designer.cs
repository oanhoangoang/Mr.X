namespace FndDiCell
{
    partial class FindDifferentCell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDifferentCell));
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.picTalk = new System.Windows.Forms.PictureBox();
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnMediate = new System.Windows.Forms.Button();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLevelOfGame = new System.Windows.Forms.Label();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.lblRule = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtScoreToPass = new System.Windows.Forms.TextBox();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtYourScore = new System.Windows.Forms.TextBox();
            this.lblScoreToPass = new System.Windows.Forms.Label();
            this.lblYoungScore = new System.Windows.Forms.Label();
            this.lblNameGame = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTimeToPlay = new System.Windows.Forms.Timer(this.components);
            this.pnlGameDisplayGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTalk)).BeginInit();
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
            this.pnlGameDisplayGray.Controls.Add(this.picTalk);
            this.pnlGameDisplayGray.Controls.Add(this.wmpSoundTrack);
            this.pnlGameDisplayGray.Controls.Add(this.btnMediate);
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 1;
            // 
            // picVictory
            // 
            this.picVictory.Location = new System.Drawing.Point(0, 0);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(809, 667);
            this.picVictory.TabIndex = 3;
            this.picVictory.TabStop = false;
            this.picVictory.Visible = false;
            // 
            // picTalk
            // 
            this.picTalk.Location = new System.Drawing.Point(549, 144);
            this.picTalk.Name = "picTalk";
            this.picTalk.Size = new System.Drawing.Size(248, 201);
            this.picTalk.TabIndex = 2;
            this.picTalk.TabStop = false;
            // 
            // wmpSoundTrack
            // 
            this.wmpSoundTrack.Enabled = true;
            this.wmpSoundTrack.Location = new System.Drawing.Point(149, 628);
            this.wmpSoundTrack.Name = "wmpSoundTrack";
            this.wmpSoundTrack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundTrack.OcxState")));
            this.wmpSoundTrack.Size = new System.Drawing.Size(75, 23);
            this.wmpSoundTrack.TabIndex = 1;
            this.wmpSoundTrack.Visible = false;
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
            this.pnlGameDisplayYellow.Controls.Add(this.lblPosition);
            this.pnlGameDisplayYellow.Controls.Add(this.lblLevelOfGame);
            this.pnlGameDisplayYellow.Location = new System.Drawing.Point(818, 4);
            this.pnlGameDisplayYellow.Name = "pnlGameDisplayYellow";
            this.pnlGameDisplayYellow.Size = new System.Drawing.Size(395, 292);
            this.pnlGameDisplayYellow.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(39, 202);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(78, 20);
            this.lblPosition.TabIndex = 4;
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
            this.lblLevelOfGame.TabIndex = 3;
            this.lblLevelOfGame.Text = "Level : ";
            // 
            // pnlGameDisplayGreen
            // 
            this.pnlGameDisplayGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameDisplayGreen.Controls.Add(this.lblRule);
            this.pnlGameDisplayGreen.Controls.Add(this.btnEnd);
            this.pnlGameDisplayGreen.Controls.Add(this.txtScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.nudSecond);
            this.pnlGameDisplayGreen.Controls.Add(this.nudMinute);
            this.pnlGameDisplayGreen.Controls.Add(this.lblTime);
            this.pnlGameDisplayGreen.Controls.Add(this.txtYourScore);
            this.pnlGameDisplayGreen.Controls.Add(this.lblScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblYoungScore);
            this.pnlGameDisplayGreen.Controls.Add(this.lblNameGame);
            this.pnlGameDisplayGreen.Controls.Add(this.btnStart);
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 5;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.ForeColor = System.Drawing.Color.White;
            this.lblRule.Location = new System.Drawing.Point(15, 47);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(367, 20);
            this.lblRule.TabIndex = 13;
            this.lblRule.Text = "Tìm ô khác biệt: màu sắc, kích thước hoặc nội dung";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(219, 276);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(89, 75);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Thoát";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtScoreToPass
            // 
            this.txtScoreToPass.Enabled = false;
            this.txtScoreToPass.Location = new System.Drawing.Point(245, 202);
            this.txtScoreToPass.Name = "txtScoreToPass";
            this.txtScoreToPass.ReadOnly = true;
            this.txtScoreToPass.Size = new System.Drawing.Size(45, 26);
            this.txtScoreToPass.TabIndex = 11;
            this.txtScoreToPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Location = new System.Drawing.Point(234, 106);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(43, 26);
            this.nudSecond.TabIndex = 3;
            // 
            // nudMinute
            // 
            this.nudMinute.Enabled = false;
            this.nudMinute.Location = new System.Drawing.Point(187, 106);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 26);
            this.nudMinute.TabIndex = 2;
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
            // txtYourScore
            // 
            this.txtYourScore.Enabled = false;
            this.txtYourScore.Location = new System.Drawing.Point(104, 202);
            this.txtYourScore.Name = "txtYourScore";
            this.txtYourScore.ReadOnly = true;
            this.txtYourScore.Size = new System.Drawing.Size(45, 26);
            this.txtYourScore.TabIndex = 10;
            this.txtYourScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblScoreToPass
            // 
            this.lblScoreToPass.AutoSize = true;
            this.lblScoreToPass.ForeColor = System.Drawing.Color.White;
            this.lblScoreToPass.Location = new System.Drawing.Point(215, 179);
            this.lblScoreToPass.Name = "lblScoreToPass";
            this.lblScoreToPass.Size = new System.Drawing.Size(115, 20);
            this.lblScoreToPass.TabIndex = 9;
            this.lblScoreToPass.Text = "Điểm qua vòng";
            // 
            // lblYoungScore
            // 
            this.lblYoungScore.AutoSize = true;
            this.lblYoungScore.ForeColor = System.Drawing.Color.White;
            this.lblYoungScore.Location = new System.Drawing.Point(100, 179);
            this.lblYoungScore.Name = "lblYoungScore";
            this.lblYoungScore.Size = new System.Drawing.Size(46, 20);
            this.lblYoungScore.TabIndex = 8;
            this.lblYoungScore.Text = "Điểm";
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameGame.ForeColor = System.Drawing.Color.White;
            this.lblNameGame.Location = new System.Drawing.Point(15, 18);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(179, 20);
            this.lblNameGame.TabIndex = 5;
            this.lblNameGame.Text = "Trò chơi: Tìm ô khác biệt";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(92, 276);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTimeToPlay
            // 
            this.tmrTimeToPlay.Interval = 1000;
            this.tmrTimeToPlay.Tick += new System.EventHandler(this.tmrTimeToPlay_Tick);
            // 
            // FindDifferentCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlGameDisplayGreen);
            this.Controls.Add(this.pnlGameDisplayYellow);
            this.Controls.Add(this.pnlGameDisplayGray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FindDifferentCell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindDifferentCell_FormClosed);
            this.pnlGameDisplayGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTalk)).EndInit();
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
        private System.Windows.Forms.Button btnMediate;
        private System.Windows.Forms.Panel pnlGameDisplayYellow;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblLevelOfGame;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtScoreToPass;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtYourScore;
        private System.Windows.Forms.Label lblScoreToPass;
        private System.Windows.Forms.Label lblYoungScore;
        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.Button btnStart;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
        private System.Windows.Forms.Timer tmrTimeToPlay;
        private System.Windows.Forms.PictureBox picTalk;
        private System.Windows.Forms.PictureBox picVictory;
        private System.Windows.Forms.Label lblRule;

    }
}