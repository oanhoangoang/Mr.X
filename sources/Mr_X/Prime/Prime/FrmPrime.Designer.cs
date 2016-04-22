using System;
using WMPLib;
namespace Prime
{
    partial class FrmPrime
    {
        public const int maxn = (int)1E5;
        public const int maxm = (int)1E4;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        Random r = new Random();
        public void enableSound()
        {
            player.URL = @"sound/Prime/SundialDreams.mp3";
            player.controls.play();
        }
        #region taoMangNguyenTo
        
        public bool[] dd = new bool[maxn + 10]; // mang danh dau de dung sang nguyen to
        public int demSLNT;
        public int[] Q = new int[100000];

        public void sangNgTo()
        {
            for (int i = 1; i <= maxm; i++) dd[i] = true;
            int x;
            int j;
            dd[1] = false;
            demSLNT = 0;
            x = 2;
            while (x <= maxm)
            {
                if (dd[x])
                {
                    j = x + x;
                    while (j <= maxm)
                    {
                        dd[j] = false;
                        j += x;
                    }
                    demSLNT++;
                    Q[demSLNT] = x;

                }
                x++;
            }

        }
        #endregion
        private int randGameTitle;
        public string[] A = new string[5]; // loai game kho
        public string[] B = new string[5]; // loai game de
        public string chooseGameTitle()
        {
            
            randGameTitle = r.Next(1, 4);
            B[1] = "Trong 4 số sau đây số nào là số nguyên tố";
            A[1] = "Trong 4 sô sau đây số nào là hợp số";
            B[2] = "Trong 4 số sau đây số nào chia hết cho 9";
            A[2] = "Trong 4 số sau đây số nào chia hết cho 7";
            B[3] = "Trong 4 số sau đây số nào không chia hết cho 9";
            A[3] = "Trong 4 số sau đây số nào không chia hết cho 7";
            if (kindOfGame == 2) return A[randGameTitle]; else return B[randGameTitle];
        }
        
        #region taoGiaTriChoGameChiaCho9,7

        public int soChiaHetCho(int u)
        {
            
            int x;
            x= r.Next(1, maxm);
            while ((x%9) != 0 )
            {
                x = r.Next(1, maxm);
            }
            return x;
        }
        public int soKhongChiaHetCho(int u)
        {
           
            int x;
            x= r.Next(1, maxm);
            while ((x%9)==0)
            {
                x = r.Next(1, maxm);
            } 
            return x;
        }
        #endregion

        #region sinhHoanVI
        public int[,] finalHoanVi = new int[1000,6];
        public int[] testHoanVi = new int[6];
        public int soLuongHoanVi;
        public void updateHoanVi()
        {
            soLuongHoanVi++;
            for (int i=1;i<=4;i++)
            finalHoanVi[soLuongHoanVi,i]=testHoanVi[i];
        }
        public void sinhHoanVi(int x)
        {
            if (x == 5) updateHoanVi();   
            for (int i=1;i<=4;i++)
                if (trace[i])
            {
                trace[i]=false;
                testHoanVi[x]=i;
                sinhHoanVi(x+1);
                trace[i]=true;
            }
        }
#endregion
        #region taoGiaTriCHoGameNgToHopSo
        public int sinhSoKhongPhaiNgTo()
        {
            
            int x;
            x= r.Next(1,maxm);
            while (dd[x])
            {
                x = r.Next(1, maxm);
            }
            return x;
        }
        public int sinhSoLaNgTo()
        {
            
            int x;
            x= r.Next(1,maxm);
            while (dd[x]==false)
            {
                x = r.Next(1, maxm);
            }
            return x;
        }
        #endregion
        
        public int randHoanVi;
        public bool[] trace = new bool[6];

        public int[] so = new int[6];
        
        public void chooseGameExpression()
        {
            sangNgTo();
           
           
            if (kindOfGame == 1)// lam game de
            {
                if (randGameTitle == 1) // Trong 4 số sau đây số nào là số nguyên tố
                {
                    so[1] = Q[r.Next(1,demSLNT+1)];
                    so[2] = sinhSoKhongPhaiNgTo();
                    so[3] = sinhSoKhongPhaiNgTo();
                    so[4] = sinhSoKhongPhaiNgTo();
                    
                } else if (randGameTitle == 2) // Trong 4 số sau đây số nào chia hết cho 9
                {
                    so[1] = soChiaHetCho(9);
                    so[2] = soKhongChiaHetCho(9);
                    so[3] = soKhongChiaHetCho(9);
                    so[4] = soKhongChiaHetCho(9);
                } else  // Trong 4 số sau đây số nào không chia hết cho 9
                {
                    so[1] = soKhongChiaHetCho(9);
                    so[2] = soChiaHetCho(9);
                    so[3] = soChiaHetCho(9);
                    so[4] = soChiaHetCho(9);
                }
            }
            if (kindOfGame ==2 )// lam Game kho
            {
                if (randGameTitle == 1) // Trong 4 sô sau đây số nào là hợp số
                {
                    so[1] = sinhSoKhongPhaiNgTo();
                    so[2] = sinhSoLaNgTo();
                    so[3] = sinhSoLaNgTo();
                    so[4] = sinhSoLaNgTo();
                } else if (randGameTitle == 2) // Trong 4 số sau đây số nào chia hết cho 7
                {
                    so[1] = soChiaHetCho(7);
                    so[2] = soKhongChiaHetCho(7);
                    so[3] = soKhongChiaHetCho(7);
                    so[4] = soKhongChiaHetCho(7);
                } else // Trong 4 số sau đây số nào không chia hết cho 7
                {
                    so[1] = soKhongChiaHetCho(7);
                    so[2] = soChiaHetCho(7);
                    so[3] = soKhongChiaHetCho(7);
                    so[4] = soKhongChiaHetCho(7);
                }
            }
        }
        public int rightButton;
        public void enterExpression()
        {
            soLuongHoanVi = 0;
            for (int i = 1; i <= 4; i++) trace[i] = true;
            sinhHoanVi(1);
            chooseGameExpression();
            
            int x = r.Next(1, soLuongHoanVi + 1);
            for (int i=1;i<=4;i++)
            {
                if (i == 1) { btnGameAns1.Text = so[finalHoanVi[x, i]].ToString(); if (finalHoanVi[x, i] == 1) rightButton = 1; }
                if (i == 2) {btnGameAns2.Text = so[finalHoanVi[x, i]].ToString(); if (finalHoanVi[x, i] == 1) rightButton = 2; }
                if (i == 3) {btnGameAns3.Text = so[finalHoanVi[x, i]].ToString(); if (finalHoanVi[x, i] == 1) rightButton = 3;}
                if (i == 4) { btnGameAns4.Text = so[finalHoanVi[x, i]].ToString(); if (finalHoanVi[x, i] == 1) rightButton = 4; }
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrime));
            this.pnGameDis = new System.Windows.Forms.Panel();
            this.picWinLoseGame = new System.Windows.Forms.PictureBox();
            this.lblNotiGameThua = new System.Windows.Forms.Label();
            this.lblNotiGameThang = new System.Windows.Forms.Label();
            this.btnGameAns4 = new System.Windows.Forms.Button();
            this.btnGameAns3 = new System.Windows.Forms.Button();
            this.btnGameAns2 = new System.Windows.Forms.Button();
            this.btnGameAns1 = new System.Windows.Forms.Button();
            this.btnGameTitle = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.pnUserInfo = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGameData = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmGame = new System.Windows.Forms.Timer(this.components);
            this.pnGameDis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinLoseGame)).BeginInit();
            this.pnUserInfo.SuspendLayout();
            this.pnGameData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGameDis
            // 
            this.pnGameDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGameDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.pnGameDis.Controls.Add(this.picWinLoseGame);
            this.pnGameDis.Controls.Add(this.lblNotiGameThua);
            this.pnGameDis.Controls.Add(this.lblNotiGameThang);
            this.pnGameDis.Controls.Add(this.btnGameAns4);
            this.pnGameDis.Controls.Add(this.btnGameAns3);
            this.pnGameDis.Controls.Add(this.btnGameAns2);
            this.pnGameDis.Controls.Add(this.btnGameAns1);
            this.pnGameDis.Controls.Add(this.btnGameTitle);
            this.pnGameDis.Controls.Add(this.lblGameTitle);
            this.pnGameDis.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnGameDis.ForeColor = System.Drawing.Color.White;
            this.pnGameDis.Location = new System.Drawing.Point(4, 4);
            this.pnGameDis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnGameDis.Name = "pnGameDis";
            this.pnGameDis.Size = new System.Drawing.Size(809, 654);
            this.pnGameDis.TabIndex = 0;
            this.pnGameDis.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picWinLoseGame
            // 
            this.picWinLoseGame.ErrorImage = null;
            this.picWinLoseGame.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWinLoseGame.InitialImage")));
            this.picWinLoseGame.Location = new System.Drawing.Point(222, 8);
            this.picWinLoseGame.Name = "picWinLoseGame";
            this.picWinLoseGame.Size = new System.Drawing.Size(353, 311);
            this.picWinLoseGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWinLoseGame.TabIndex = 8;
            this.picWinLoseGame.TabStop = false;
            this.picWinLoseGame.Visible = false;
            this.picWinLoseGame.Click += new System.EventHandler(this.picWinLoseGame_Click);
            // 
            // lblNotiGameThua
            // 
            this.lblNotiGameThua.AutoSize = true;
            this.lblNotiGameThua.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiGameThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNotiGameThua.Location = new System.Drawing.Point(150, 395);
            this.lblNotiGameThua.Name = "lblNotiGameThua";
            this.lblNotiGameThua.Size = new System.Drawing.Size(0, 43);
            this.lblNotiGameThua.TabIndex = 7;
            this.lblNotiGameThua.Click += new System.EventHandler(this.lblNotiGameThua_Click);
            // 
            // lblNotiGameThang
            // 
            this.lblNotiGameThang.AutoSize = true;
            this.lblNotiGameThang.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiGameThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNotiGameThang.Location = new System.Drawing.Point(31, 395);
            this.lblNotiGameThang.Name = "lblNotiGameThang";
            this.lblNotiGameThang.Size = new System.Drawing.Size(0, 43);
            this.lblNotiGameThang.TabIndex = 6;
            this.lblNotiGameThang.Click += new System.EventHandler(this.lblNotiGame_Click);
            // 
            // btnGameAns4
            // 
            this.btnGameAns4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnGameAns4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameAns4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns4.FlatAppearance.BorderSize = 0;
            this.btnGameAns4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameAns4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGameAns4.Location = new System.Drawing.Point(472, 474);
            this.btnGameAns4.Name = "btnGameAns4";
            this.btnGameAns4.Size = new System.Drawing.Size(290, 70);
            this.btnGameAns4.TabIndex = 5;
            this.btnGameAns4.Text = "button4";
            this.btnGameAns4.UseVisualStyleBackColor = false;
            this.btnGameAns4.Click += new System.EventHandler(this.btnGameAns4_Click);
            // 
            // btnGameAns3
            // 
            this.btnGameAns3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnGameAns3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns3.FlatAppearance.BorderSize = 0;
            this.btnGameAns3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameAns3.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGameAns3.Location = new System.Drawing.Point(39, 474);
            this.btnGameAns3.Name = "btnGameAns3";
            this.btnGameAns3.Size = new System.Drawing.Size(290, 70);
            this.btnGameAns3.TabIndex = 4;
            this.btnGameAns3.Text = "button3";
            this.btnGameAns3.UseVisualStyleBackColor = false;
            this.btnGameAns3.Click += new System.EventHandler(this.btnGameAns3_Click);
            // 
            // btnGameAns2
            // 
            this.btnGameAns2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnGameAns2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameAns2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns2.FlatAppearance.BorderSize = 0;
            this.btnGameAns2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameAns2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGameAns2.Location = new System.Drawing.Point(472, 345);
            this.btnGameAns2.Name = "btnGameAns2";
            this.btnGameAns2.Size = new System.Drawing.Size(290, 70);
            this.btnGameAns2.TabIndex = 3;
            this.btnGameAns2.Text = "Halo";
            this.btnGameAns2.UseVisualStyleBackColor = false;
            this.btnGameAns2.Click += new System.EventHandler(this.btnGameAns2_Click);
            // 
            // btnGameAns1
            // 
            this.btnGameAns1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnGameAns1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameAns1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns1.FlatAppearance.BorderSize = 0;
            this.btnGameAns1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.btnGameAns1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameAns1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGameAns1.Location = new System.Drawing.Point(39, 345);
            this.btnGameAns1.Name = "btnGameAns1";
            this.btnGameAns1.Size = new System.Drawing.Size(290, 70);
            this.btnGameAns1.TabIndex = 2;
            this.btnGameAns1.Text = "button1";
            this.btnGameAns1.UseVisualStyleBackColor = false;
            this.btnGameAns1.Click += new System.EventHandler(this.btnGameAns1_Click);
            this.btnGameAns1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGameAns1_MouseMove);
            // 
            // btnGameTitle
            // 
            this.btnGameTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnGameTitle.Enabled = false;
            this.btnGameTitle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnGameTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameTitle.ForeColor = System.Drawing.Color.White;
            this.btnGameTitle.Location = new System.Drawing.Point(108, 181);
            this.btnGameTitle.Name = "btnGameTitle";
            this.btnGameTitle.Size = new System.Drawing.Size(577, 92);
            this.btnGameTitle.TabIndex = 1;
            this.btnGameTitle.Text = "button1";
            this.btnGameTitle.UseVisualStyleBackColor = false;
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.lblGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.lblGameTitle.Location = new System.Drawing.Point(230, 36);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(310, 20);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Chọn đáp án đúng nhất thỏa mãn yêu cầu:";
            // 
            // pnUserInfo
            // 
            this.pnUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnUserInfo.Controls.Add(this.lblChucVu);
            this.pnUserInfo.Controls.Add(this.lblLevel);
            this.pnUserInfo.Controls.Add(this.label2);
            this.pnUserInfo.Controls.Add(this.label1);
            this.pnUserInfo.Location = new System.Drawing.Point(818, 4);
            this.pnUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnUserInfo.Name = "pnUserInfo";
            this.pnUserInfo.Size = new System.Drawing.Size(395, 292);
            this.pnUserInfo.TabIndex = 1;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(149, 198);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(66, 24);
            this.lblChucVu.TabIndex = 3;
            this.lblChucVu.Text = "label4";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(143, 151);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(66, 24);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "label3";
            this.lblLevel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level: ";
            // 
            // pnGameData
            // 
            this.pnGameData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnGameData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnGameData.Controls.Add(this.label5);
            this.pnGameData.Controls.Add(this.lblTime);
            this.pnGameData.Controls.Add(this.label3);
            this.pnGameData.Controls.Add(this.btnBackToMenu);
            this.pnGameData.Controls.Add(this.btnStart);
            this.pnGameData.Location = new System.Drawing.Point(818, 300);
            this.pnGameData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnGameData.Name = "pnGameData";
            this.pnGameData.Size = new System.Drawing.Size(395, 358);
            this.pnGameData.TabIndex = 2;
            this.pnGameData.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(198, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giây";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(149, 99);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời Gian:";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnBackToMenu.FlatAppearance.BorderSize = 0;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(223, 213);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(135, 82);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "Trở về màn hình chính";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(48, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 82);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmGame
            // 
            this.tmGame.Interval = 800;
            this.tmGame.Tick += new System.EventHandler(this.tmGame_Tick);
            // 
            // FrmPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.pnGameData);
            this.Controls.Add(this.pnUserInfo);
            this.Controls.Add(this.pnGameDis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrime_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrime_Load);
            this.pnGameDis.ResumeLayout(false);
            this.pnGameDis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinLoseGame)).EndInit();
            this.pnUserInfo.ResumeLayout(false);
            this.pnUserInfo.PerformLayout();
            this.pnGameData.ResumeLayout(false);
            this.pnGameData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGameDis;
        private System.Windows.Forms.Panel pnUserInfo;
        private System.Windows.Forms.Panel pnGameData;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnGameAns4;
        private System.Windows.Forms.Button btnGameAns3;
        private System.Windows.Forms.Button btnGameAns2;
        private System.Windows.Forms.Button btnGameAns1;
        private System.Windows.Forms.Button btnGameTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmGame;
        private System.Windows.Forms.Label lblNotiGameThang;
        private System.Windows.Forms.Label lblNotiGameThua;
        private System.Windows.Forms.PictureBox picWinLoseGame;
    }
}