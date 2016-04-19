using System;

namespace FstCal
{
    partial class FstCalDisp
    {
        int num1, num2, playerAns, gameAns;
        int check; // check = 0 Lose; check = 1 Win
        //
        // Load the calculation
        //
        public void loadGameData() 
        {
            Random rd = new Random();

            lblNum1.Visible = true;
            lblNum2.Visible = true;
            lblSign.Visible = true;
            txtAns.Visible = true;
            btnAns.Visible = true;

            num1 = rd.Next(10, 100);
            lblNum1.Text = num1.ToString();
            num2 = rd.Next(10, 100);
            lblNum2.Text = num2.ToString();
            if (lvlGame == 1) lblSign.Text = "+"; else lblSign.Text = "x";
        }
        //
        // Calculate the game answer
        //
        public int calAns(int num1, int num2) 
        {
            if (lvlGame == 1) return num1 + num2;
            else return num1 * num2;
        }

        //
        // Time up
        //
        public void notiTimeUp() 
        {
            check = 0;
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblSign.Visible = false;
            txtAns.Visible = false;
            btnAns.Visible = false;
            lblGuide.Visible = false;
            btnAns.Visible = false;
            txtAns.Visible = false;
            lblNoti.Visible = true;
            lblNoti.Text = "Cái gì lâu quá cũng không tốt. Cố gắng lần sau nhé !";
        }
        //
        // Notify player answer is Right
        //
        public void notiRightAns() 
        {
            check = 1;
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblSign.Visible = false;
            txtAns.Visible = false;
            btnAns.Visible = false;
            lblGuide.Visible = false;
            btnAns.Visible = false;
            txtAns.Visible = false;
            lblNoti.Visible = true;
            lblNoti.Text = "Ghê à nha! Party với chức vụ mới thôi :))";
        }
        //
        // Player answer is Wrong
        //
        public void notiWrongAns() 
        {
            check = 0;
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblSign.Visible = false;
            txtAns.Visible = false;
            btnAns.Visible = false;
            lblGuide.Visible = false;
            btnAns.Visible = false;
            txtAns.Visible = false;
            lblNoti.Visible = true;
            lblNoti.Text = "Đen thôi, đỏ khác liền =)) Gặp lại bạn lần sau !";
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FstCalDisp));
            this.pnlGameDisp = new System.Windows.Forms.Panel();
            this.lblNoti = new System.Windows.Forms.Label();
            this.btnAns = new System.Windows.Forms.Button();
            this.lblGuide = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblSign = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.pnlPlayerInfo = new System.Windows.Forms.Panel();
            this.lblRankData = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblLevelData = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pnlGameInfo = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimeUnit = new System.Windows.Forms.Label();
            this.lblTimeCount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.pnlGameDisp.SuspendLayout();
            this.pnlPlayerInfo.SuspendLayout();
            this.pnlGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameDisp
            // 
            this.pnlGameDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGameDisp.Controls.Add(this.lblNoti);
            this.pnlGameDisp.Controls.Add(this.btnAns);
            this.pnlGameDisp.Controls.Add(this.lblGuide);
            this.pnlGameDisp.Controls.Add(this.txtAns);
            this.pnlGameDisp.Controls.Add(this.lblSign);
            this.pnlGameDisp.Controls.Add(this.lblNum2);
            this.pnlGameDisp.Controls.Add(this.lblNum1);
            this.pnlGameDisp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlGameDisp.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGameDisp.Name = "pnlGameDisp";
            this.pnlGameDisp.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisp.TabIndex = 1;
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.Red;
            this.lblNoti.Location = new System.Drawing.Point(150, 266);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(51, 26);
            this.lblNoti.TabIndex = 6;
            this.lblNoti.Text = "Noti";
            this.lblNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnAns.Location = new System.Drawing.Point(348, 481);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(148, 72);
            this.btnAns.TabIndex = 5;
            this.btnAns.Text = "Xong !";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblGuide.Location = new System.Drawing.Point(209, 105);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(69, 25);
            this.lblGuide.TabIndex = 4;
            this.lblGuide.Text = "Guide";
            this.lblGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAns
            // 
            this.txtAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAns.Font = new System.Drawing.Font("Jokerman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txtAns.Location = new System.Drawing.Point(315, 379);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(181, 68);
            this.txtAns.TabIndex = 3;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new System.Drawing.Font("Jokerman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblSign.Location = new System.Drawing.Point(259, 242);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(108, 58);
            this.lblSign.TabIndex = 2;
            this.lblSign.Text = "Sign";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Jokerman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblNum2.Location = new System.Drawing.Point(390, 296);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(139, 58);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Num2";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Jokerman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblNum1.Location = new System.Drawing.Point(386, 184);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(133, 58);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num1";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPlayerInfo
            // 
            this.pnlPlayerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlPlayerInfo.Controls.Add(this.lblRankData);
            this.pnlPlayerInfo.Controls.Add(this.lblRank);
            this.pnlPlayerInfo.Controls.Add(this.lblLevelData);
            this.pnlPlayerInfo.Controls.Add(this.lblLevel);
            this.pnlPlayerInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPlayerInfo.Location = new System.Drawing.Point(818, 4);
            this.pnlPlayerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlayerInfo.Name = "pnlPlayerInfo";
            this.pnlPlayerInfo.Size = new System.Drawing.Size(395, 292);
            this.pnlPlayerInfo.TabIndex = 2;
            // 
            // lblRankData
            // 
            this.lblRankData.AutoSize = true;
            this.lblRankData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankData.Location = new System.Drawing.Point(161, 159);
            this.lblRankData.Name = "lblRankData";
            this.lblRankData.Size = new System.Drawing.Size(51, 20);
            this.lblRankData.TabIndex = 3;
            this.lblRankData.Text = "label4";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(68, 159);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(66, 20);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "Chức vụ";
            // 
            // lblLevelData
            // 
            this.lblLevelData.AutoSize = true;
            this.lblLevelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelData.Location = new System.Drawing.Point(161, 109);
            this.lblLevelData.Name = "lblLevelData";
            this.lblLevelData.Size = new System.Drawing.Size(51, 20);
            this.lblLevelData.TabIndex = 1;
            this.lblLevelData.Text = "label2";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(68, 109);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level";
            // 
            // pnlGameInfo
            // 
            this.pnlGameInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlGameInfo.Controls.Add(this.btnBackToMenu);
            this.pnlGameInfo.Controls.Add(this.btnStart);
            this.pnlGameInfo.Controls.Add(this.lblTimeUnit);
            this.pnlGameInfo.Controls.Add(this.lblTimeCount);
            this.pnlGameInfo.Controls.Add(this.lblTime);
            this.pnlGameInfo.ForeColor = System.Drawing.Color.Black;
            this.pnlGameInfo.Location = new System.Drawing.Point(818, 300);
            this.pnlGameInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGameInfo.Name = "pnlGameInfo";
            this.pnlGameInfo.Size = new System.Drawing.Size(395, 358);
            this.pnlGameInfo.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(81, 168);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 77);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimeUnit
            // 
            this.lblTimeUnit.AutoSize = true;
            this.lblTimeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUnit.Location = new System.Drawing.Point(235, 101);
            this.lblTimeUnit.Name = "lblTimeUnit";
            this.lblTimeUnit.Size = new System.Drawing.Size(41, 20);
            this.lblTimeUnit.TabIndex = 2;
            this.lblTimeUnit.Text = "Giây";
            // 
            // lblTimeCount
            // 
            this.lblTimeCount.AutoSize = true;
            this.lblTimeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCount.Location = new System.Drawing.Point(161, 101);
            this.lblTimeCount.Name = "lblTimeCount";
            this.lblTimeCount.Size = new System.Drawing.Size(51, 20);
            this.lblTimeCount.TabIndex = 1;
            this.lblTimeCount.Text = "label2";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(68, 101);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Thời gian : ";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMenu.Location = new System.Drawing.Point(212, 168);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(106, 77);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "Trở về";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            // 
            // FstCalDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlGameInfo);
            this.Controls.Add(this.pnlPlayerInfo);
            this.Controls.Add(this.pnlGameDisp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FstCalDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FstCalDisp";
            this.Load += new System.EventHandler(this.FstCalDisp_Load);
            this.pnlGameDisp.ResumeLayout(false);
            this.pnlGameDisp.PerformLayout();
            this.pnlPlayerInfo.ResumeLayout(false);
            this.pnlPlayerInfo.PerformLayout();
            this.pnlGameInfo.ResumeLayout(false);
            this.pnlGameInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisp;
        private System.Windows.Forms.Panel pnlPlayerInfo;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Panel pnlGameInfo;
        private System.Windows.Forms.Label lblRankData;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblLevelData;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimeUnit;
        private System.Windows.Forms.Label lblTimeCount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}