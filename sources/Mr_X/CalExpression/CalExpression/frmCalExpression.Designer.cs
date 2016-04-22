using System;
using WMPLib;
using System.Media;
namespace CalExpression
{
    partial class frmCalExpression
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       // private System.ComponentModel.IContainer components = null;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public void enableSound()
        {
            player.URL = @"sound/CalExpression/ChildhoodMemory.mp3";
            player.controls.play(); 
        }
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
       // private System.ComponentModel.IContainer components = null;
        public string[] A = new string[3];

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>

        // choose Game Title 
        public int randGameTitle;
        public int xx; // see under code to know what xx is 
        public string chooseGameTitle()
        {
            Random r = new Random();
            randGameTitle = r.Next(1, 3);
            xx = r.Next(1, 4);
            A[1] = "Chọn biểu thức có giá trị lớn nhất trong 3 biểu thức sau: ";
            A[2] = "Chọn biểu thức có giá trị bằng ";
            if (kindOfGame == 1) A[2] += tong[xx].ToString(); else A[2] += tich[xx].ToString();
            A[2] += ": ";

            return A[randGameTitle];
        }
        int rightValue;
        
        public void xuLy1()
        {
             if (randGameTitle == 2)
            {
                rightValue = xx;
                
            } else
            {
                int max=0;
                for (int i=1;i<=3;i++) 
                    if (max<tong[i]) {rightValue = i; max=tong[i]; }
            }
        }

        public void xuLy2()
        {
            if (randGameTitle == 2)
            {
                rightValue = xx;

            }
            else
            {
                int max = 0;
                for (int i = 1; i <= 3; i++)
                    if (max < tich[i]) { rightValue = i; max = tich[i]; }
            }
        }

        // value of variable in balloons
        int[] randValue = new int[10];
        public void chooseValue()
        {
            Random r = new Random();
            for (int i = 1; i <= 6; i++) randValue[i] = r.Next(1, 100);
        }


        //  choose Bieu Thuc
        public int[] tong = new int[5];
        public int[] tich = new int[5];
        // Game ez
        public string ezGame(int i, int j) 
        {
            string S = "";
            S += randValue[i].ToString() + " + ";
            S += randValue[j].ToString();
            tong[j / 2] = randValue[i] + randValue[j];
            return S;

        }
        // Game diff
        public string diffGame(int i, int j) 
        {
            string S = "";
            S += randValue[i].ToString() + " * ";
            S += randValue[j].ToString();
            tich[j / 2] = randValue[i] * randValue[j];
            return S;
        }



        /// <summary>
        // xong phan chon bieu thuc
        /// </summary>
        /// <param name="disposing"></param>
        /// 

        // xu ly Game
        public void enter()
        {
            if (kindOfGame == 1)
            {
                btnGame1.Text = ezGame(1, 2);
                btnGame2.Text = ezGame(3, 4);
                btnGame3.Text = ezGame(5, 6);
                // choose  Game Title
                lblGameTitle.Text = chooseGameTitle();

                xuLy1();
            }
            else
            {
                btnGame1.Text = diffGame(1, 2);
                btnGame2.Text = diffGame(3, 4);
                btnGame3.Text = diffGame(5, 6);
                // choose  Game Title
                lblGameTitle.Text = chooseGameTitle();

                xuLy2();
            }
        }
       
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalExpression));
            this.pnGameData = new System.Windows.Forms.Panel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGiay = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.pnInfoUser = new System.Windows.Forms.Panel();
            this.lblChucVuInput = new System.Windows.Forms.Label();
            this.lblLevelInput = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.pnGameDis = new System.Windows.Forms.Panel();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnGameData.SuspendLayout();
            this.pnInfoUser.SuspendLayout();
            this.pnGameDis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGameData
            // 
            this.pnGameData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGameData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnGameData.Controls.Add(this.btnBackToMenu);
            this.pnGameData.Controls.Add(this.lblHuongDan);
            this.pnGameData.Controls.Add(this.btnStart);
            this.pnGameData.Controls.Add(this.lblTime);
            this.pnGameData.Controls.Add(this.lblGiay);
            this.pnGameData.Controls.Add(this.lblThoiGian);
            this.pnGameData.Location = new System.Drawing.Point(818, 300);
            this.pnGameData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnGameData.Name = "pnGameData";
            this.pnGameData.Size = new System.Drawing.Size(395, 358);
            this.pnGameData.TabIndex = 1;
            this.pnGameData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGameData_Paint);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(104, 163);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(199, 87);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Trở về màn hình chính";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.ForeColor = System.Drawing.Color.Red;
            this.lblHuongDan.Location = new System.Drawing.Point(30, 288);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(51, 20);
            this.lblHuongDan.TabIndex = 6;
            this.lblHuongDan.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(104, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 87);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(157, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 24);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label4";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblGiay
            // 
            this.lblGiay.AutoSize = true;
            this.lblGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiay.ForeColor = System.Drawing.Color.White;
            this.lblGiay.Location = new System.Drawing.Point(219, 71);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(51, 24);
            this.lblGiay.TabIndex = 3;
            this.lblGiay.Text = "Giây";
            this.lblGiay.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.White;
            this.lblThoiGian.Location = new System.Drawing.Point(53, 71);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(110, 24);
            this.lblThoiGian.TabIndex = 2;
            this.lblThoiGian.Text = "Thời gian: ";
            // 
            // pnInfoUser
            // 
            this.pnInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInfoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnInfoUser.Controls.Add(this.lblChucVuInput);
            this.pnInfoUser.Controls.Add(this.lblLevelInput);
            this.pnInfoUser.Controls.Add(this.lblChucVu);
            this.pnInfoUser.Controls.Add(this.lblLevel);
            this.pnInfoUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnInfoUser.Location = new System.Drawing.Point(818, 4);
            this.pnInfoUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnInfoUser.Name = "pnInfoUser";
            this.pnInfoUser.Size = new System.Drawing.Size(395, 292);
            this.pnInfoUser.TabIndex = 2;
            this.pnInfoUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnInfoUser_Paint);
            // 
            // lblChucVuInput
            // 
            this.lblChucVuInput.AutoSize = true;
            this.lblChucVuInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVuInput.ForeColor = System.Drawing.Color.White;
            this.lblChucVuInput.Location = new System.Drawing.Point(148, 168);
            this.lblChucVuInput.Name = "lblChucVuInput";
            this.lblChucVuInput.Size = new System.Drawing.Size(66, 24);
            this.lblChucVuInput.TabIndex = 3;
            this.lblChucVuInput.Text = "label1";
            // 
            // lblLevelInput
            // 
            this.lblLevelInput.AutoSize = true;
            this.lblLevelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelInput.ForeColor = System.Drawing.Color.White;
            this.lblLevelInput.Location = new System.Drawing.Point(148, 113);
            this.lblLevelInput.Name = "lblLevelInput";
            this.lblLevelInput.Size = new System.Drawing.Size(66, 24);
            this.lblLevelInput.TabIndex = 2;
            this.lblLevelInput.Text = "label1";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(49, 168);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(93, 24);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "Chức vụ:";
            this.lblChucVu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(49, 113);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(66, 24);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level:";
            this.lblLevel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.White;
            this.lblGameTitle.ForeColor = System.Drawing.Color.Red;
            this.lblGameTitle.Location = new System.Drawing.Point(232, 42);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(51, 20);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "label1";
            // 
            // pnGameDis
            // 
            this.pnGameDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGameDis.BackColor = System.Drawing.Color.White;
            this.pnGameDis.Controls.Add(this.btnGame3);
            this.pnGameDis.Controls.Add(this.btnGame2);
            this.pnGameDis.Controls.Add(this.btnGame1);
            this.pnGameDis.Controls.Add(this.lblGameTitle);
            this.pnGameDis.Location = new System.Drawing.Point(4, 4);
            this.pnGameDis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnGameDis.Name = "pnGameDis";
            this.pnGameDis.Size = new System.Drawing.Size(809, 654);
            this.pnGameDis.TabIndex = 0;
            this.pnGameDis.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGameDis_Paint);
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.Transparent;
            this.btnGame3.BackgroundImage = global::CalExpression.Properties.Resources.Balloon;
            this.btnGame3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGame3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGame3.FlatAppearance.BorderSize = 0;
            this.btnGame3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGame3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGame3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame3.Location = new System.Drawing.Point(542, 168);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(252, 358);
            this.btnGame3.TabIndex = 3;
            this.btnGame3.UseVisualStyleBackColor = false;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            this.btnGame3.MouseLeave += new System.EventHandler(this.btnGame3_MouseLeave);
            this.btnGame3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGame3_MouseMove);
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.Transparent;
            this.btnGame2.BackgroundImage = global::CalExpression.Properties.Resources.Balloon;
            this.btnGame2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGame2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGame2.FlatAppearance.BorderSize = 0;
            this.btnGame2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGame2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame2.Location = new System.Drawing.Point(275, 168);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(252, 358);
            this.btnGame2.TabIndex = 2;
            this.btnGame2.UseVisualStyleBackColor = false;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            this.btnGame2.MouseLeave += new System.EventHandler(this.btnGame2_MouseLeave);
            this.btnGame2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGame2_MouseMove);
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.Transparent;
            this.btnGame1.BackgroundImage = global::CalExpression.Properties.Resources.Balloon;
            this.btnGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGame1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGame1.FlatAppearance.BorderSize = 0;
            this.btnGame1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGame1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGame1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGame1.Location = new System.Drawing.Point(8, 168);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(252, 358);
            this.btnGame1.TabIndex = 1;
            this.btnGame1.UseVisualStyleBackColor = false;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            this.btnGame1.MouseLeave += new System.EventHandler(this.btnGame1_MouseLeave);
            this.btnGame1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGame1_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmCalExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnInfoUser);
            this.Controls.Add(this.pnGameData);
            this.Controls.Add(this.pnGameDis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalExpression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameTinhBieuThuc_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnGameData.ResumeLayout(false);
            this.pnGameData.PerformLayout();
            this.pnInfoUser.ResumeLayout(false);
            this.pnInfoUser.PerformLayout();
            this.pnGameDis.ResumeLayout(false);
            this.pnGameDis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGameData;
        private System.Windows.Forms.Panel pnInfoUser;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblGiay;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Panel pnGameDis;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblLevelInput;
        private System.Windows.Forms.Label lblChucVuInput;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}