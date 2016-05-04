namespace PiPo
{
    partial class PingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPong));
            this.pnlGameDisplay = new System.Windows.Forms.Panel();
            this.picBar = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.pnlPlayerInfo = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlGameInfo = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblTimeGone = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrBallMove = new System.Windows.Forms.Timer(this.components);
            this.pnlGameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.pnlPlayerInfo.SuspendLayout();
            this.pnlGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameDisplay
            // 
            this.pnlGameDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlGameDisplay.Controls.Add(this.picBar);
            this.pnlGameDisplay.Controls.Add(this.picBall);
            this.pnlGameDisplay.Location = new System.Drawing.Point(4, 4);
            this.pnlGameDisplay.Name = "pnlGameDisplay";
            this.pnlGameDisplay.Size = new System.Drawing.Size(809, 654);
            this.pnlGameDisplay.TabIndex = 0;
            // 
            // picBar
            // 
            this.picBar.BackColor = System.Drawing.SystemColors.GrayText;
            this.picBar.Location = new System.Drawing.Point(344, 618);
            this.picBar.Name = "picBar";
            this.picBar.Size = new System.Drawing.Size(209, 29);
            this.picBar.TabIndex = 0;
            this.picBar.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.picBall.Location = new System.Drawing.Point(185, 240);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(37, 38);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // pnlPlayerInfo
            // 
            this.pnlPlayerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(211)))), ((int)(((byte)(124)))));
            this.pnlPlayerInfo.Controls.Add(this.lblChucVu);
            this.pnlPlayerInfo.Controls.Add(this.lblLevel);
            this.pnlPlayerInfo.Controls.Add(this.lbl2);
            this.pnlPlayerInfo.Controls.Add(this.lbl1);
            this.pnlPlayerInfo.Location = new System.Drawing.Point(818, 4);
            this.pnlPlayerInfo.Name = "pnlPlayerInfo";
            this.pnlPlayerInfo.Size = new System.Drawing.Size(395, 292);
            this.pnlPlayerInfo.TabIndex = 0;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(178, 213);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(110, 29);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức vụ: ";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(151, 159);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(83, 29);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(62, 213);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(110, 29);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Chức vụ: ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(62, 159);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Level: ";
            // 
            // pnlGameInfo
            // 
            this.pnlGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(120)))), ((int)(((byte)(75)))));
            this.pnlGameInfo.Controls.Add(this.btnBack);
            this.pnlGameInfo.Controls.Add(this.btnStart);
            this.pnlGameInfo.Controls.Add(this.lbl8);
            this.pnlGameInfo.Controls.Add(this.lblTimeGone);
            this.pnlGameInfo.Controls.Add(this.lblTime);
            this.pnlGameInfo.Controls.Add(this.lbl6);
            this.pnlGameInfo.Controls.Add(this.lbl7);
            this.pnlGameInfo.Controls.Add(this.lbl5);
            this.pnlGameInfo.Controls.Add(this.lbl4);
            this.pnlGameInfo.Controls.Add(this.lbl3);
            this.pnlGameInfo.Location = new System.Drawing.Point(818, 300);
            this.pnlGameInfo.Name = "pnlGameInfo";
            this.pnlGameInfo.Size = new System.Drawing.Size(395, 358);
            this.pnlGameInfo.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(179)))), ((int)(((byte)(80)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(230, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(179)))), ((int)(((byte)(80)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(81, 261);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F);
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(195, 199);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(49, 23);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "giây";
            // 
            // lblTimeGone
            // 
            this.lblTimeGone.AutoSize = true;
            this.lblTimeGone.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeGone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTimeGone.Location = new System.Drawing.Point(136, 186);
            this.lblTimeGone.Name = "lblTimeGone";
            this.lblTimeGone.Size = new System.Drawing.Size(53, 40);
            this.lblTimeGone.TabIndex = 0;
            this.lblTimeGone.Text = "45";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTime.Location = new System.Drawing.Point(119, 146);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 40);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "45";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F);
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(167, 159);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(49, 23);
            this.lbl6.TabIndex = 0;
            this.lbl6.Text = "giây";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(37, 202);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(97, 20);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Bạn đã chơi:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(37, 162);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(77, 20);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Thời gian:";
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(36, 66);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(337, 68);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "Di chuyển giá đỡ để ngăn cản quả bóng rơi xuống mặt đất. Nếu duy trì được hơn số " +
    "thời gian quy định, bạn sẽ chiến thắng!";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(36, 27);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(219, 20);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Thử thách: Game Ping Pong";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tmrBallMove
            // 
            this.tmrBallMove.Interval = 1;
            this.tmrBallMove.Tick += new System.EventHandler(this.tmrBallMove_Tick);
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnlPlayerInfo);
            this.Controls.Add(this.pnlGameInfo);
            this.Controls.Add(this.pnlGameDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PingPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.pnlGameDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.pnlPlayerInfo.ResumeLayout(false);
            this.pnlPlayerInfo.PerformLayout();
            this.pnlGameInfo.ResumeLayout(false);
            this.pnlGameInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameDisplay;
        private System.Windows.Forms.Panel pnlPlayerInfo;
        private System.Windows.Forms.Panel pnlGameInfo;
        private System.Windows.Forms.PictureBox picBar;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeGone;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrBallMove;
    }
}