namespace follArrow
{
    partial class followArrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(followArrow));
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.picTalk = new System.Windows.Forms.PictureBox();
            this.picDance = new System.Windows.Forms.PictureBox();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLevelOfGame = new System.Windows.Forms.Label();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tmrTimeToPlay = new System.Windows.Forms.Timer();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pnlGameDisplayGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDance)).BeginInit();
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
            this.pnlGameDisplayGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.pnlGameDisplayGray.Controls.Add(this.picTalk);
            this.pnlGameDisplayGray.Controls.Add(this.picDance);
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(0, 0);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 1;
            // 
            // picTalk
            // 
            this.picTalk.Location = new System.Drawing.Point(86, 347);
            this.picTalk.Name = "picTalk";
            this.picTalk.Size = new System.Drawing.Size(144, 128);
            this.picTalk.TabIndex = 1;
            this.picTalk.TabStop = false;
            // 
            // picDance
            // 
            this.picDance.Location = new System.Drawing.Point(198, 104);
            this.picDance.Name = "picDance";
            this.picDance.Size = new System.Drawing.Size(395, 230);
            this.picDance.TabIndex = 0;
            this.picDance.TabStop = false;
            // 
            // pnlGameDisplayYellow
            // 
            this.pnlGameDisplayYellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(212)))), ((int)(((byte)(96)))));
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
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(179)))), ((int)(((byte)(80)))));
            this.pnlGameDisplayGreen.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhấn mũi tên NGƯỢC chiều với mũi tên màu đỏ";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRule.ForeColor = System.Drawing.Color.White;
            this.lblRule.Location = new System.Drawing.Point(15, 38);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(348, 20);
            this.lblRule.TabIndex = 13;
            this.lblRule.Text = "Nhấn mũi tên CÙNG chiều với mũi tên màu xanh";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(215)))), ((int)(((byte)(183)))));
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(219, 276);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(89, 75);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.TabStop = false;
            this.btnEnd.Text = "Thoát";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtScoreToPass
            // 
            this.txtScoreToPass.Enabled = false;
            this.txtScoreToPass.Location = new System.Drawing.Point(232, 216);
            this.txtScoreToPass.Name = "txtScoreToPass";
            this.txtScoreToPass.ReadOnly = true;
            this.txtScoreToPass.Size = new System.Drawing.Size(45, 26);
            this.txtScoreToPass.TabIndex = 11;
            this.txtScoreToPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Location = new System.Drawing.Point(245, 145);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(63, 26);
            this.nudSecond.TabIndex = 3;
            // 
            // nudMinute
            // 
            this.nudMinute.Enabled = false;
            this.nudMinute.Location = new System.Drawing.Point(181, 145);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(58, 26);
            this.nudMinute.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(94, 145);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời gian :";
            // 
            // txtYourScore
            // 
            this.txtYourScore.Enabled = false;
            this.txtYourScore.Location = new System.Drawing.Point(104, 216);
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
            this.lblScoreToPass.Location = new System.Drawing.Point(205, 193);
            this.lblScoreToPass.Name = "lblScoreToPass";
            this.lblScoreToPass.Size = new System.Drawing.Size(115, 20);
            this.lblScoreToPass.TabIndex = 9;
            this.lblScoreToPass.Text = "Điểm qua vòng";
            // 
            // lblYoungScore
            // 
            this.lblYoungScore.AutoSize = true;
            this.lblYoungScore.ForeColor = System.Drawing.Color.White;
            this.lblYoungScore.Location = new System.Drawing.Point(100, 193);
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
            this.lblNameGame.Location = new System.Drawing.Point(15, 9);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(227, 20);
            this.lblNameGame.TabIndex = 5;
            this.lblNameGame.Text = "Trò chơi: Nhảy cùng Doraemon";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(247)))), ((int)(((byte)(197)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(92, 276);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTimeToPlay
            // 
            this.tmrTimeToPlay.Interval = 1000;
            this.tmrTimeToPlay.Tick += new System.EventHandler(this.tmrTimeToPlay_Tick);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(72)))), ((int)(((byte)(54)))));
            this.lblNotice.Location = new System.Drawing.Point(186, 181);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 20);
            this.lblNotice.TabIndex = 7;
            // 
            // followArrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.pnlGameDisplayGreen);
            this.Controls.Add(this.pnlGameDisplayYellow);
            this.Controls.Add(this.pnlGameDisplayGray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "followArrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.followArrow_FormClosed);
            this.Load += new System.EventHandler(this.followArrow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.followArrow_KeyUp);
            this.pnlGameDisplayGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDance)).EndInit();
            this.pnlGameDisplayYellow.ResumeLayout(false);
            this.pnlGameDisplayYellow.PerformLayout();
            this.pnlGameDisplayGreen.ResumeLayout(false);
            this.pnlGameDisplayGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplayGray;
        private System.Windows.Forms.Panel pnlGameDisplayYellow;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblLevelOfGame;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
        private System.Windows.Forms.Label lblRule;
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
        private System.Windows.Forms.Timer tmrTimeToPlay;
        private System.Windows.Forms.PictureBox picDance;
        private System.Windows.Forms.PictureBox picTalk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotice;



    }
}