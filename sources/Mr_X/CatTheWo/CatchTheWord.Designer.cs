﻿namespace CatTheWo
{
    partial class CatchTheWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchTheWord));
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.btnMediate = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.picTalk = new System.Windows.Forms.PictureBox();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.picMc = new System.Windows.Forms.PictureBox();
            this.picGameDisplay = new System.Windows.Forms.PictureBox();
            this.pnlGameDisplaySunFlower = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLevelOfGame = new System.Windows.Forms.Label();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtNumberOfRound = new System.Windows.Forms.TextBox();
            this.txtScoreToPass = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblNumberOfRound = new System.Windows.Forms.Label();
            this.lblScoreToPass = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.tmrTimeToPlay = new System.Windows.Forms.Timer(this.components);
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.pnlGameDisplayGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameDisplay)).BeginInit();
            this.pnlGameDisplaySunFlower.SuspendLayout();
            this.pnlGameDisplayGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
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
            this.pnlGameDisplayGray.Controls.Add(this.lblHint);
            this.pnlGameDisplayGray.Controls.Add(this.wmpSoundTrack);
            this.pnlGameDisplayGray.Controls.Add(this.picTalk);
            this.pnlGameDisplayGray.Controls.Add(this.txtRound);
            this.pnlGameDisplayGray.Controls.Add(this.txtAnswer);
            this.pnlGameDisplayGray.Controls.Add(this.btnSkip);
            this.pnlGameDisplayGray.Controls.Add(this.picMc);
            this.pnlGameDisplayGray.Controls.Add(this.picGameDisplay);
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 702);
            this.pnlGameDisplayGray.TabIndex = 0;
            // 
            // btnMediate
            // 
            this.btnMediate.ForeColor = System.Drawing.Color.Black;
            this.btnMediate.Location = new System.Drawing.Point(91, 616);
            this.btnMediate.Name = "btnMediate";
            this.btnMediate.Size = new System.Drawing.Size(106, 38);
            this.btnMediate.TabIndex = 8;
            this.btnMediate.Text = "btnMediate";
            this.btnMediate.UseVisualStyleBackColor = true;
            this.btnMediate.Visible = false;
            this.btnMediate.Click += new System.EventHandler(this.btnMediate_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.Black;
            this.lblHint.Location = new System.Drawing.Point(663, 133);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 16);
            this.lblHint.TabIndex = 7;
            // 
            // wmpSoundTrack
            // 
            this.wmpSoundTrack.Enabled = true;
            this.wmpSoundTrack.Location = new System.Drawing.Point(3, 631);
            this.wmpSoundTrack.Name = "wmpSoundTrack";
            this.wmpSoundTrack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundTrack.OcxState")));
            this.wmpSoundTrack.Size = new System.Drawing.Size(75, 23);
            this.wmpSoundTrack.TabIndex = 6;
            this.wmpSoundTrack.Visible = false;
            // 
            // picTalk
            // 
            this.picTalk.Location = new System.Drawing.Point(622, 77);
            this.picTalk.Name = "picTalk";
            this.picTalk.Size = new System.Drawing.Size(127, 126);
            this.picTalk.TabIndex = 5;
            this.picTalk.TabStop = false;
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(50, 3);
            this.txtRound.Name = "txtRound";
            this.txtRound.ReadOnly = true;
            this.txtRound.Size = new System.Drawing.Size(267, 26);
            this.txtRound.TabIndex = 4;
            this.txtRound.Text = "Vòng 1";
            this.txtRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswer
            // 
            this.txtAnswer.ForeColor = System.Drawing.Color.White;
            this.txtAnswer.Location = new System.Drawing.Point(50, 35);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(267, 26);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSkip
            // 
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.btnSkip.Location = new System.Drawing.Point(441, 344);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(73, 35);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "bỏ qua";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Visible = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // picMc
            // 
            this.picMc.Location = new System.Drawing.Point(441, 67);
            this.picMc.Name = "picMc";
            this.picMc.Size = new System.Drawing.Size(320, 312);
            this.picMc.TabIndex = 1;
            this.picMc.TabStop = false;
            // 
            // picGameDisplay
            // 
            this.picGameDisplay.Location = new System.Drawing.Point(8, 67);
            this.picGameDisplay.Name = "picGameDisplay";
            this.picGameDisplay.Size = new System.Drawing.Size(427, 312);
            this.picGameDisplay.TabIndex = 0;
            this.picGameDisplay.TabStop = false;
            // 
            // pnlGameDisplaySunFlower
            // 
            this.pnlGameDisplaySunFlower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplaySunFlower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlGameDisplaySunFlower.Controls.Add(this.lblPosition);
            this.pnlGameDisplaySunFlower.Controls.Add(this.lblLevelOfGame);
            this.pnlGameDisplaySunFlower.Location = new System.Drawing.Point(818, 4);
            this.pnlGameDisplaySunFlower.Name = "pnlGameDisplaySunFlower";
            this.pnlGameDisplaySunFlower.Size = new System.Drawing.Size(395, 292);
            this.pnlGameDisplaySunFlower.TabIndex = 1;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(39, 202);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(78, 20);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ : ";
            // 
            // lblLevelOfGame
            // 
            this.lblLevelOfGame.AutoSize = true;
            this.lblLevelOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelOfGame.Location = new System.Drawing.Point(38, 159);
            this.lblLevelOfGame.Name = "lblLevelOfGame";
            this.lblLevelOfGame.Size = new System.Drawing.Size(82, 26);
            this.lblLevelOfGame.TabIndex = 0;
            this.lblLevelOfGame.Text = "Level : ";
            // 
            // pnlGameDisplayGreen
            // 
            this.pnlGameDisplayGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameDisplayGreen.Controls.Add(this.nudMinute);
            this.pnlGameDisplayGreen.Controls.Add(this.txtRule);
            this.pnlGameDisplayGreen.Controls.Add(this.btnEnd);
            this.pnlGameDisplayGreen.Controls.Add(this.txtNumberOfRound);
            this.pnlGameDisplayGreen.Controls.Add(this.txtScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.btnStart);
            this.pnlGameDisplayGreen.Controls.Add(this.txtScore);
            this.pnlGameDisplayGreen.Controls.Add(this.lblNumberOfRound);
            this.pnlGameDisplayGreen.Controls.Add(this.lblScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblScore);
            this.pnlGameDisplayGreen.Controls.Add(this.nudSecond);
            this.pnlGameDisplayGreen.Controls.Add(this.lblTime);
            this.pnlGameDisplayGreen.Controls.Add(this.lblGame);
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 2;
            // 
            // nudMinute
            // 
            this.nudMinute.Enabled = false;
            this.nudMinute.Location = new System.Drawing.Point(163, 115);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(48, 26);
            this.nudMinute.TabIndex = 15;
            // 
            // txtRule
            // 
            this.txtRule.Location = new System.Drawing.Point(18, 36);
            this.txtRule.Multiline = true;
            this.txtRule.Name = "txtRule";
            this.txtRule.ReadOnly = true;
            this.txtRule.Size = new System.Drawing.Size(352, 50);
            this.txtRule.TabIndex = 14;
            this.txtRule.Text = "Mỗi vòng bạn phải đoán các chữ xuất hiện trong đáp án và bạn không được đoán sai " +
    "quá 4 lần";
            // 
            // btnEnd
            // 
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Location = new System.Drawing.Point(201, 271);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(94, 71);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtNumberOfRound
            // 
            this.txtNumberOfRound.Location = new System.Drawing.Point(283, 205);
            this.txtNumberOfRound.Name = "txtNumberOfRound";
            this.txtNumberOfRound.ReadOnly = true;
            this.txtNumberOfRound.Size = new System.Drawing.Size(67, 26);
            this.txtNumberOfRound.TabIndex = 11;
            // 
            // txtScoreToPass
            // 
            this.txtScoreToPass.Location = new System.Drawing.Point(153, 205);
            this.txtScoreToPass.Name = "txtScoreToPass";
            this.txtScoreToPass.ReadOnly = true;
            this.txtScoreToPass.Size = new System.Drawing.Size(67, 26);
            this.txtScoreToPass.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(36, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 71);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(18, 205);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(67, 26);
            this.txtScore.TabIndex = 8;
            // 
            // lblNumberOfRound
            // 
            this.lblNumberOfRound.AutoSize = true;
            this.lblNumberOfRound.Location = new System.Drawing.Point(270, 182);
            this.lblNumberOfRound.Name = "lblNumberOfRound";
            this.lblNumberOfRound.Size = new System.Drawing.Size(100, 20);
            this.lblNumberOfRound.TabIndex = 7;
            this.lblNumberOfRound.Text = "Số vòng chơi";
            // 
            // lblScoreToPass
            // 
            this.lblScoreToPass.AutoSize = true;
            this.lblScoreToPass.Location = new System.Drawing.Point(123, 182);
            this.lblScoreToPass.Name = "lblScoreToPass";
            this.lblScoreToPass.Size = new System.Drawing.Size(115, 20);
            this.lblScoreToPass.TabIndex = 6;
            this.lblScoreToPass.Text = "Điểm qua vòng";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(27, 182);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Điểm";
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Location = new System.Drawing.Point(217, 115);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(48, 26);
            this.nudSecond.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(80, 121);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 20);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian : ";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(14, 13);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(197, 20);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "Trò chơi: Đuổi hình bắt chữ";
            // 
            // tmrTimeToPlay
            // 
            this.tmrTimeToPlay.Interval = 1000;
            this.tmrTimeToPlay.Tick += new System.EventHandler(this.tmrTimeToPlay_Tick);
            // 
            // picVictory
            // 
            this.picVictory.Location = new System.Drawing.Point(8, 67);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(753, 571);
            this.picVictory.TabIndex = 3;
            this.picVictory.TabStop = false;
            this.picVictory.Visible = false;
            // 
            // CatchTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlGameDisplayGreen);
            this.Controls.Add(this.pnlGameDisplaySunFlower);
            this.Controls.Add(this.pnlGameDisplayGray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CatchTheWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatchTheWord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatchTheWord_FormClosed);
            this.pnlGameDisplayGray.ResumeLayout(false);
            this.pnlGameDisplayGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameDisplay)).EndInit();
            this.pnlGameDisplaySunFlower.ResumeLayout(false);
            this.pnlGameDisplaySunFlower.PerformLayout();
            this.pnlGameDisplayGreen.ResumeLayout(false);
            this.pnlGameDisplayGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplayGray;
        private System.Windows.Forms.Panel pnlGameDisplaySunFlower;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumberOfRound;
        private System.Windows.Forms.Label lblScoreToPass;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNumberOfRound;
        private System.Windows.Forms.TextBox txtScoreToPass;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer tmrTimeToPlay;
        private System.Windows.Forms.PictureBox picMc;
        private System.Windows.Forms.PictureBox picGameDisplay;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.PictureBox picTalk;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnMediate;
        private System.Windows.Forms.Label lblLevelOfGame;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picVictory;
    }
}