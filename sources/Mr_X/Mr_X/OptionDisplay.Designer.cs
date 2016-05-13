namespace Mr_X
{
    partial class OptionDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionDisplay));
            this.lblContinue = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lbl_Infor = new System.Windows.Forms.Label();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.lblFreePlaying = new System.Windows.Forms.Label();
            this.lblMarathon = new System.Windows.Forms.Label();
            this.pnl_Infor = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.pnlNewGame.SuspendLayout();
            this.pnl_Infor.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.BackColor = System.Drawing.Color.Transparent;
            this.lblContinue.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblContinue.ForeColor = System.Drawing.Color.LightGray;
            this.lblContinue.Location = new System.Drawing.Point(652, 95);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(111, 36);
            this.lblContinue.TabIndex = 4;
            this.lblContinue.Text = "Tiếp tục";
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.BackColor = System.Drawing.Color.Transparent;
            this.lblNewGame.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblNewGame.ForeColor = System.Drawing.Color.LightGray;
            this.lblNewGame.Location = new System.Drawing.Point(645, 144);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(125, 36);
            this.lblNewGame.TabIndex = 4;
            this.lblNewGame.Text = "Chơi mới";
            this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblSetting.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblSetting.ForeColor = System.Drawing.Color.LightGray;
            this.lblSetting.Location = new System.Drawing.Point(658, 193);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(99, 36);
            this.lblSetting.TabIndex = 4;
            this.lblSetting.Text = "Cài đặt";
            this.lblSetting.Click += new System.EventHandler(this.lblSetting_Click);
            // 
            // lbl_Infor
            // 
            this.lbl_Infor.AutoSize = true;
            this.lbl_Infor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Infor.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lbl_Infor.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Infor.Location = new System.Drawing.Point(643, 242);
            this.lbl_Infor.Name = "lbl_Infor";
            this.lbl_Infor.Size = new System.Drawing.Size(129, 36);
            this.lbl_Infor.TabIndex = 4;
            this.lbl_Infor.Text = "Thông tin";
            this.lbl_Infor.Click += new System.EventHandler(this.lbl_Infor_Click);
            // 
            // pnlNewGame
            // 
            this.pnlNewGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlNewGame.Controls.Add(this.lblMarathon);
            this.pnlNewGame.Controls.Add(this.lblFreePlaying);
            this.pnlNewGame.ForeColor = System.Drawing.Color.LightGray;
            this.pnlNewGame.Location = new System.Drawing.Point(257, 344);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(240, 160);
            this.pnlNewGame.TabIndex = 5;
            this.pnlNewGame.Visible = false;
            // 
            // lblFreePlaying
            // 
            this.lblFreePlaying.AutoSize = true;
            this.lblFreePlaying.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblFreePlaying.ForeColor = System.Drawing.Color.LightGray;
            this.lblFreePlaying.Location = new System.Drawing.Point(38, 81);
            this.lblFreePlaying.Name = "lblFreePlaying";
            this.lblFreePlaying.Size = new System.Drawing.Size(142, 36);
            this.lblFreePlaying.TabIndex = 0;
            this.lblFreePlaying.Text = "Chơi tự do";
            this.lblFreePlaying.Click += new System.EventHandler(this.lblFreePlaying_Click);
            // 
            // lblMarathon
            // 
            this.lblMarathon.AutoSize = true;
            this.lblMarathon.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblMarathon.ForeColor = System.Drawing.Color.LightGray;
            this.lblMarathon.Location = new System.Drawing.Point(43, 31);
            this.lblMarathon.Name = "lblMarathon";
            this.lblMarathon.Size = new System.Drawing.Size(132, 36);
            this.lblMarathon.TabIndex = 0;
            this.lblMarathon.Text = "Marathon";
            this.lblMarathon.Click += new System.EventHandler(this.lblMarathon_Click);
            // 
            // pnl_Infor
            // 
            this.pnl_Infor.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Infor.Controls.Add(this.lbl1);
            this.pnl_Infor.Location = new System.Drawing.Point(49, 106);
            this.pnl_Infor.Name = "pnl_Infor";
            this.pnl_Infor.Size = new System.Drawing.Size(551, 232);
            this.pnl_Infor.TabIndex = 6;
            this.pnl_Infor.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LightGray;
            this.lbl1.Location = new System.Drawing.Point(28, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(480, 167);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Tên sản phẩm: Mr.X - Window Desktop Game\r\nPhiên bản: 2.1\r\nPhát hành bởi: Fantasti" +
    "c 4 \r\nNgôn ngữ: C#\r\nYêu cầu cấu hình máy tính tối thiểu: 1233 x 702\r\nLiên hệ với" +
    " chúng tôi: http://www.F4.com.vn/";
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.Transparent;
            this.pnlSetting.Controls.Add(this.lbl3);
            this.pnlSetting.Controls.Add(this.lblSound);
            this.pnlSetting.Controls.Add(this.lblMusic);
            this.pnlSetting.Controls.Add(this.lbl2);
            this.pnlSetting.Location = new System.Drawing.Point(606, 316);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(240, 200);
            this.pnlSetting.TabIndex = 7;
            this.pnlSetting.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lbl2.ForeColor = System.Drawing.Color.LightGray;
            this.lbl2.Location = new System.Drawing.Point(25, 42);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(140, 36);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Âm thanh:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lbl3.ForeColor = System.Drawing.Color.LightGray;
            this.lbl3.Location = new System.Drawing.Point(25, 97);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(85, 36);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Nhạc:";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(212)))), ((int)(((byte)(96)))));
            this.lblMusic.Location = new System.Drawing.Point(112, 97);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(53, 36);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "Tắt";
            this.lblMusic.Click += new System.EventHandler(this.lblMusic_Click);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(212)))), ((int)(((byte)(96)))));
            this.lblSound.Location = new System.Drawing.Point(164, 42);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(53, 36);
            this.lblSound.TabIndex = 0;
            this.lblSound.Text = "Tắt";
            this.lblSound.Click += new System.EventHandler(this.lblSound_Click);
            // 
            // OptionDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlNewGame);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.pnl_Infor);
            this.Controls.Add(this.lbl_Infor);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.lblContinue);
            this.DoubleBuffered = true;
            this.Name = "OptionDisplay";
            this.Size = new System.Drawing.Size(1217, 663);
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.pnl_Infor.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label lbl_Infor;
        private System.Windows.Forms.Panel pnlNewGame;
        private System.Windows.Forms.Label lblFreePlaying;
        private System.Windows.Forms.Label lblMarathon;
        private System.Windows.Forms.Panel pnl_Infor;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lbl2;


    }
}
