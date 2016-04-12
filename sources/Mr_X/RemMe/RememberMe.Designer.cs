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
            this.btnMediate = new System.Windows.Forms.Button();
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.lblOpportunity = new System.Windows.Forms.Label();
            this.txtOpportunity = new System.Windows.Forms.TextBox();
            this.txtSelectedColor = new System.Windows.Forms.TextBox();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.txtYoung_Score = new System.Windows.Forms.TextBox();
            this.txtScoreToPass = new System.Windows.Forms.TextBox();
            this.lblScoreToPass = new System.Windows.Forms.Label();
            this.lblYoungScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTimeToWatch = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeToPlay = new System.Windows.Forms.Timer(this.components);
            this.pnlGameDisplayGray.SuspendLayout();
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
            this.pnlGameDisplayGray.Controls.Add(this.btnMediate);
            this.pnlGameDisplayGray.Controls.Add(this.wmpSoundTrack);
            this.pnlGameDisplayGray.ForeColor = System.Drawing.Color.Black;
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 0;
            // 
            // btnMediate
            // 
            this.btnMediate.Enabled = false;
            this.btnMediate.Location = new System.Drawing.Point(107, 599);
            this.btnMediate.Name = "btnMediate";
            this.btnMediate.Size = new System.Drawing.Size(126, 48);
            this.btnMediate.TabIndex = 1;
            this.btnMediate.Text = "btnMediate";
            this.btnMediate.UseVisualStyleBackColor = true;
            this.btnMediate.Visible = false;
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
            this.pnlGameDisplayYellow.Controls.Add(this.textBox1);
            this.pnlGameDisplayYellow.Controls.Add(this.label1);
            this.pnlGameDisplayYellow.ForeColor = System.Drawing.Color.Black;
            this.pnlGameDisplayYellow.Location = new System.Drawing.Point(818, 4);
            this.pnlGameDisplayYellow.Name = "pnlGameDisplayYellow";
            this.pnlGameDisplayYellow.Size = new System.Drawing.Size(395, 292);
            this.pnlGameDisplayYellow.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(338, 99);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Ban đầu các ô đều có màu nhất định. Sau 5s, tất cả các ô đều sẽ có màu đỏ. Nhiệm " +
    "vụ của bạn là chọn tất cả các ô có màu ban đầu trùng với màu được chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trò chơi ghi nhớ";
            // 
            // pnlGameDisplayGreen
            // 
            this.pnlGameDisplayGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameDisplayGreen.Controls.Add(this.lblOpportunity);
            this.pnlGameDisplayGreen.Controls.Add(this.txtOpportunity);
            this.pnlGameDisplayGreen.Controls.Add(this.txtSelectedColor);
            this.pnlGameDisplayGreen.Controls.Add(this.lblSelectedColor);
            this.pnlGameDisplayGreen.Controls.Add(this.txtYoung_Score);
            this.pnlGameDisplayGreen.Controls.Add(this.txtScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblScoreToPass);
            this.pnlGameDisplayGreen.Controls.Add(this.lblYoungScore);
            this.pnlGameDisplayGreen.Controls.Add(this.lblTime);
            this.pnlGameDisplayGreen.Controls.Add(this.nudSecond);
            this.pnlGameDisplayGreen.Controls.Add(this.nudMinute);
            this.pnlGameDisplayGreen.Controls.Add(this.btnEnd);
            this.pnlGameDisplayGreen.Controls.Add(this.btnStart);
            this.pnlGameDisplayGreen.ForeColor = System.Drawing.Color.Black;
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 1;
            // 
            // lblOpportunity
            // 
            this.lblOpportunity.AutoSize = true;
            this.lblOpportunity.Location = new System.Drawing.Point(1, 143);
            this.lblOpportunity.Name = "lblOpportunity";
            this.lblOpportunity.Size = new System.Drawing.Size(102, 20);
            this.lblOpportunity.TabIndex = 17;
            this.lblOpportunity.Text = "Số lượt chọn:";
            // 
            // txtOpportunity
            // 
            this.txtOpportunity.Enabled = false;
            this.txtOpportunity.Location = new System.Drawing.Point(149, 137);
            this.txtOpportunity.Name = "txtOpportunity";
            this.txtOpportunity.ReadOnly = true;
            this.txtOpportunity.Size = new System.Drawing.Size(100, 26);
            this.txtOpportunity.TabIndex = 16;
            // 
            // txtSelectedColor
            // 
            this.txtSelectedColor.Enabled = false;
            this.txtSelectedColor.Location = new System.Drawing.Point(149, 34);
            this.txtSelectedColor.Name = "txtSelectedColor";
            this.txtSelectedColor.ReadOnly = true;
            this.txtSelectedColor.Size = new System.Drawing.Size(100, 26);
            this.txtSelectedColor.TabIndex = 15;
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.AutoSize = true;
            this.lblSelectedColor.Location = new System.Drawing.Point(3, 40);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(122, 20);
            this.lblSelectedColor.TabIndex = 14;
            this.lblSelectedColor.Text = "Màu được chọn:";
            // 
            // txtYoung_Score
            // 
            this.txtYoung_Score.Enabled = false;
            this.txtYoung_Score.Location = new System.Drawing.Point(149, 70);
            this.txtYoung_Score.Name = "txtYoung_Score";
            this.txtYoung_Score.ReadOnly = true;
            this.txtYoung_Score.Size = new System.Drawing.Size(100, 26);
            this.txtYoung_Score.TabIndex = 13;
            // 
            // txtScoreToPass
            // 
            this.txtScoreToPass.Enabled = false;
            this.txtScoreToPass.Location = new System.Drawing.Point(149, 105);
            this.txtScoreToPass.Name = "txtScoreToPass";
            this.txtScoreToPass.ReadOnly = true;
            this.txtScoreToPass.Size = new System.Drawing.Size(100, 26);
            this.txtScoreToPass.TabIndex = 12;
            // 
            // lblScoreToPass
            // 
            this.lblScoreToPass.AutoSize = true;
            this.lblScoreToPass.Location = new System.Drawing.Point(3, 108);
            this.lblScoreToPass.Name = "lblScoreToPass";
            this.lblScoreToPass.Size = new System.Drawing.Size(140, 20);
            this.lblScoreToPass.TabIndex = 10;
            this.lblScoreToPass.Text = "Số điểm qua vòng:";
            // 
            // lblYoungScore
            // 
            this.lblYoungScore.AutoSize = true;
            this.lblYoungScore.Location = new System.Drawing.Point(3, 75);
            this.lblYoungScore.Name = "lblYoungScore";
            this.lblYoungScore.Size = new System.Drawing.Size(111, 20);
            this.lblYoungScore.TabIndex = 9;
            this.lblYoungScore.Text = "Điểm của bạn:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 169);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời gian :";
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Location = new System.Drawing.Point(208, 167);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(41, 26);
            this.nudSecond.TabIndex = 3;
            // 
            // nudMinute
            // 
            this.nudMinute.Enabled = false;
            this.nudMinute.Location = new System.Drawing.Point(149, 167);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 26);
            this.nudMinute.TabIndex = 2;
            // 
            // btnEnd
            // 
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Location = new System.Drawing.Point(220, 220);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 100);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(56, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 100);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RememberMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RememberMe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RememberMe_FormClosed);
            this.Load += new System.EventHandler(this.RememberMe_Load);
            this.pnlGameDisplayGray.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnEnd;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
        private System.Windows.Forms.Button btnMediate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblYoungScore;
        private System.Windows.Forms.Label lblScoreToPass;
        private System.Windows.Forms.TextBox txtScoreToPass;
        private System.Windows.Forms.TextBox txtYoung_Score;
        private System.Windows.Forms.Label lblSelectedColor;
        private System.Windows.Forms.TextBox txtSelectedColor;
        private System.Windows.Forms.Label lblOpportunity;
        private System.Windows.Forms.TextBox txtOpportunity;
        private System.Windows.Forms.Timer tmrTimeToWatch;
        private System.Windows.Forms.Timer tmrTimeToPlay;
    }
}