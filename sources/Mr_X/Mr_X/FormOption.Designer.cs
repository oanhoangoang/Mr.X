namespace Mr_X
{
    partial class FormOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOption));
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblPractice = new System.Windows.Forms.Label();
            this.lblFight = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNewGamePrac = new System.Windows.Forms.Label();
            this.lblContinuePrac = new System.Windows.Forms.Label();
            this.pnlPrac = new System.Windows.Forms.Panel();
            this.lblNewGameFight = new System.Windows.Forms.Label();
            this.lblContinueFight = new System.Windows.Forms.Label();
            this.pnlFight = new System.Windows.Forms.Panel();
            this.pnlPrac.SuspendLayout();
            this.pnlFight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAbout.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblAbout.ForeColor = System.Drawing.Color.LightGray;
            this.lblAbout.Location = new System.Drawing.Point(205, 247);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(129, 36);
            this.lblAbout.TabIndex = 14;
            this.lblAbout.Text = "Thông tin";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVolume.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblVolume.ForeColor = System.Drawing.Color.LightGray;
            this.lblVolume.Location = new System.Drawing.Point(180, 211);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(140, 36);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "Âm thanh:";
            // 
            // lblPractice
            // 
            this.lblPractice.AutoSize = true;
            this.lblPractice.BackColor = System.Drawing.Color.Transparent;
            this.lblPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPractice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPractice.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblPractice.ForeColor = System.Drawing.Color.LightGray;
            this.lblPractice.Location = new System.Drawing.Point(206, 161);
            this.lblPractice.Name = "lblPractice";
            this.lblPractice.Size = new System.Drawing.Size(133, 36);
            this.lblPractice.TabIndex = 17;
            this.lblPractice.Text = "Luyện tập";
            this.lblPractice.Click += new System.EventHandler(this.lblPractice_Click);
            // 
            // lblFight
            // 
            this.lblFight.AutoSize = true;
            this.lblFight.BackColor = System.Drawing.Color.Transparent;
            this.lblFight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFight.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblFight.ForeColor = System.Drawing.Color.LightGray;
            this.lblFight.Location = new System.Drawing.Point(205, 111);
            this.lblFight.Name = "lblFight";
            this.lblFight.Size = new System.Drawing.Size(134, 36);
            this.lblFight.TabIndex = 18;
            this.lblFight.Text = "Chiến đấu";
            this.lblFight.Click += new System.EventHandler(this.lblFight_Click);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.BackColor = System.Drawing.Color.Transparent;
            this.lblSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSound.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.lblSound.Location = new System.Drawing.Point(326, 211);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(56, 36);
            this.lblSound.TabIndex = 16;
            this.lblSound.Text = "Bật";
            this.lblSound.Click += new System.EventHandler(this.lblSound_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescription.Location = new System.Drawing.Point(624, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(480, 167);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Tên sản phẩm: Mr.X - Window Desktop Game\r\nPhiên bản: 2.1\r\nPhát hành bởi: Fantasti" +
    "c 4 \r\nNgôn ngữ: C#\r\nYêu cầu cấu hình máy tính tối thiểu: 1233 x 702\r\nLiên hệ với" +
    " chúng tôi: http://www.F4.com.vn/";
            this.lblDescription.Visible = false;
            // 
            // lblNewGamePrac
            // 
            this.lblNewGamePrac.AutoSize = true;
            this.lblNewGamePrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewGamePrac.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblNewGamePrac.ForeColor = System.Drawing.Color.LightGray;
            this.lblNewGamePrac.Location = new System.Drawing.Point(75, 81);
            this.lblNewGamePrac.Name = "lblNewGamePrac";
            this.lblNewGamePrac.Size = new System.Drawing.Size(125, 36);
            this.lblNewGamePrac.TabIndex = 0;
            this.lblNewGamePrac.Text = "Chơi mới";
            this.lblNewGamePrac.Click += new System.EventHandler(this.lblNewGamePrac_Click);
            // 
            // lblContinuePrac
            // 
            this.lblContinuePrac.AutoSize = true;
            this.lblContinuePrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContinuePrac.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblContinuePrac.ForeColor = System.Drawing.Color.LightGray;
            this.lblContinuePrac.Location = new System.Drawing.Point(75, 31);
            this.lblContinuePrac.Name = "lblContinuePrac";
            this.lblContinuePrac.Size = new System.Drawing.Size(111, 36);
            this.lblContinuePrac.TabIndex = 0;
            this.lblContinuePrac.Text = "Tiếp tục";
            this.lblContinuePrac.Click += new System.EventHandler(this.lblContinuePrac_Click);
            // 
            // pnlPrac
            // 
            this.pnlPrac.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrac.Controls.Add(this.lblContinuePrac);
            this.pnlPrac.Controls.Add(this.lblNewGamePrac);
            this.pnlPrac.ForeColor = System.Drawing.Color.LightGray;
            this.pnlPrac.Location = new System.Drawing.Point(415, 123);
            this.pnlPrac.Name = "pnlPrac";
            this.pnlPrac.Size = new System.Drawing.Size(240, 160);
            this.pnlPrac.TabIndex = 20;
            this.pnlPrac.Visible = false;
            // 
            // lblNewGameFight
            // 
            this.lblNewGameFight.AutoSize = true;
            this.lblNewGameFight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewGameFight.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblNewGameFight.ForeColor = System.Drawing.Color.LightGray;
            this.lblNewGameFight.Location = new System.Drawing.Point(75, 81);
            this.lblNewGameFight.Name = "lblNewGameFight";
            this.lblNewGameFight.Size = new System.Drawing.Size(125, 36);
            this.lblNewGameFight.TabIndex = 0;
            this.lblNewGameFight.Text = "Chơi mới";
            this.lblNewGameFight.Click += new System.EventHandler(this.lblNewGameFight_Click);
            // 
            // lblContinueFight
            // 
            this.lblContinueFight.AutoSize = true;
            this.lblContinueFight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContinueFight.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblContinueFight.ForeColor = System.Drawing.Color.LightGray;
            this.lblContinueFight.Location = new System.Drawing.Point(75, 31);
            this.lblContinueFight.Name = "lblContinueFight";
            this.lblContinueFight.Size = new System.Drawing.Size(111, 36);
            this.lblContinueFight.TabIndex = 0;
            this.lblContinueFight.Text = "Tiếp tục";
            this.lblContinueFight.Click += new System.EventHandler(this.lblContinueFight_Click);
            // 
            // pnlFight
            // 
            this.pnlFight.BackColor = System.Drawing.Color.Transparent;
            this.pnlFight.Controls.Add(this.lblContinueFight);
            this.pnlFight.Controls.Add(this.lblNewGameFight);
            this.pnlFight.ForeColor = System.Drawing.Color.LightGray;
            this.pnlFight.Location = new System.Drawing.Point(418, 68);
            this.pnlFight.Name = "pnlFight";
            this.pnlFight.Size = new System.Drawing.Size(240, 160);
            this.pnlFight.TabIndex = 19;
            this.pnlFight.Visible = false;
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pnlPrac);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblPractice);
            this.Controls.Add(this.lblFight);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.pnlFight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOption";
            this.pnlPrac.ResumeLayout(false);
            this.pnlPrac.PerformLayout();
            this.pnlFight.ResumeLayout(false);
            this.pnlFight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblPractice;
        private System.Windows.Forms.Label lblFight;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNewGamePrac;
        private System.Windows.Forms.Label lblContinuePrac;
        private System.Windows.Forms.Panel pnlPrac;
        private System.Windows.Forms.Label lblNewGameFight;
        private System.Windows.Forms.Label lblContinueFight;
        private System.Windows.Forms.Panel pnlFight;
    }
}