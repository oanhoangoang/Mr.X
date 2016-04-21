namespace ChseNum
{
    partial class ChooseNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseNumber));
            this.pnlGameDisplayGray = new System.Windows.Forms.Panel();
            this.wmpSoundTrack = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnMediate = new System.Windows.Forms.Button();
            this.pnlGameDisplayYellow = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLevelOfGame = new System.Windows.Forms.Label();
            this.pnlGameDisplayGreen = new System.Windows.Forms.Panel();
            this.txtYourSum = new System.Windows.Forms.TextBox();
            this.lblYourSum = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNameGame = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTimeToPlay = new System.Windows.Forms.Timer(this.components);
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.pnlGameDisplayGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).BeginInit();
            this.pnlGameDisplayYellow.SuspendLayout();
            this.pnlGameDisplayGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameDisplayGray
            // 
            this.pnlGameDisplayGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameDisplayGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(171)))), ((int)(((byte)(227)))));
            this.pnlGameDisplayGray.Controls.Add(this.picVictory);
            this.pnlGameDisplayGray.Controls.Add(this.wmpSoundTrack);
            this.pnlGameDisplayGray.Controls.Add(this.btnMediate);
            this.pnlGameDisplayGray.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplayGray.Name = "pnlGameDisplayGray";
            this.pnlGameDisplayGray.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplayGray.TabIndex = 1;
            // 
            // wmpSoundTrack
            // 
            this.wmpSoundTrack.Enabled = true;
            this.wmpSoundTrack.Location = new System.Drawing.Point(139, 601);
            this.wmpSoundTrack.Name = "wmpSoundTrack";
            this.wmpSoundTrack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundTrack.OcxState")));
            this.wmpSoundTrack.Size = new System.Drawing.Size(212, 46);
            this.wmpSoundTrack.TabIndex = 3;
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
            this.pnlGameDisplayYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
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
            this.pnlGameDisplayGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(195)))), ((int)(((byte)(128)))));
            this.pnlGameDisplayGreen.Controls.Add(this.txtYourSum);
            this.pnlGameDisplayGreen.Controls.Add(this.lblYourSum);
            this.pnlGameDisplayGreen.Controls.Add(this.lblRule);
            this.pnlGameDisplayGreen.Controls.Add(this.btnEnd);
            this.pnlGameDisplayGreen.Controls.Add(this.nudSecond);
            this.pnlGameDisplayGreen.Controls.Add(this.nudMinute);
            this.pnlGameDisplayGreen.Controls.Add(this.lblTime);
            this.pnlGameDisplayGreen.Controls.Add(this.txtNum);
            this.pnlGameDisplayGreen.Controls.Add(this.lblNum);
            this.pnlGameDisplayGreen.Controls.Add(this.lblNameGame);
            this.pnlGameDisplayGreen.Controls.Add(this.btnStart);
            this.pnlGameDisplayGreen.Location = new System.Drawing.Point(818, 300);
            this.pnlGameDisplayGreen.Name = "pnlGameDisplayGreen";
            this.pnlGameDisplayGreen.Size = new System.Drawing.Size(395, 358);
            this.pnlGameDisplayGreen.TabIndex = 5;
            // 
            // txtYourSum
            // 
            this.txtYourSum.Enabled = false;
            this.txtYourSum.Location = new System.Drawing.Point(214, 201);
            this.txtYourSum.Name = "txtYourSum";
            this.txtYourSum.ReadOnly = true;
            this.txtYourSum.Size = new System.Drawing.Size(94, 26);
            this.txtYourSum.TabIndex = 15;
            this.txtYourSum.Text = "0";
            this.txtYourSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYourSum
            // 
            this.lblYourSum.AutoSize = true;
            this.lblYourSum.ForeColor = System.Drawing.Color.White;
            this.lblYourSum.Location = new System.Drawing.Point(210, 169);
            this.lblYourSum.Name = "lblYourSum";
            this.lblYourSum.Size = new System.Drawing.Size(106, 20);
            this.lblYourSum.TabIndex = 14;
            this.lblYourSum.Text = "Tổng của bạn";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRule.ForeColor = System.Drawing.Color.White;
            this.lblRule.Location = new System.Drawing.Point(15, 51);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(348, 20);
            this.lblRule.TabIndex = 13;
            this.lblRule.Text = "Chọn các số trên bảng để thu được tổng bằng X";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
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
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(92, 201);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(94, 26);
            this.txtNum.TabIndex = 7;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(112, 169);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 20);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "Số X";
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameGame.ForeColor = System.Drawing.Color.White;
            this.lblNameGame.Location = new System.Drawing.Point(15, 18);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(132, 20);
            this.lblNameGame.TabIndex = 5;
            this.lblNameGame.Text = "Trò chơi: Chọn số";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
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
            // picVictory
            // 
            this.picVictory.Location = new System.Drawing.Point(0, 0);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(809, 654);
            this.picVictory.TabIndex = 6;
            this.picVictory.TabStop = false;
            this.picVictory.Visible = false;
            // 
            // ChooseNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlGameDisplayGreen);
            this.Controls.Add(this.pnlGameDisplayYellow);
            this.Controls.Add(this.pnlGameDisplayGray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ChooseNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChooseNumber_FormClosed);
            this.pnlGameDisplayGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundTrack)).EndInit();
            this.pnlGameDisplayYellow.ResumeLayout(false);
            this.pnlGameDisplayYellow.PerformLayout();
            this.pnlGameDisplayGreen.ResumeLayout(false);
            this.pnlGameDisplayGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplayGray;
        private System.Windows.Forms.Button btnMediate;
        private System.Windows.Forms.Panel pnlGameDisplayYellow;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblLevelOfGame;
        private System.Windows.Forms.Panel pnlGameDisplayGreen;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrTimeToPlay;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundTrack;
        private System.Windows.Forms.TextBox txtYourSum;
        private System.Windows.Forms.Label lblYourSum;
        private System.Windows.Forms.PictureBox picVictory;
    }
}