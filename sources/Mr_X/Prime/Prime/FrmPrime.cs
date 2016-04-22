using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime
{
   
    public partial class FrmPrime : Form
    {
        public int kindOfGame;
        public string level;
        public string chucVu;
        public int time;
        public bool sound;
        public FrmPrime(int kindOfGame_ , string chucVu_ , string level_,int time_,bool sound_)
        {
            InitializeComponent();
            kindOfGame = kindOfGame_;
            chucVu = chucVu_;
            level = level_;
            time = time_;
            sound = sound_;

            //

        }
        public delegate void truyen(int value);
        public truyen trans;
        public bool ok; // tra ve true neu nguoi choi thang , false neu thua
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FrmPrime_Load(object sender, EventArgs e)
        {
            
            btnGameTitle.Text = "Nhấn bắt đầu để chơi Game";
            btnGameAns1.Visible = false;
            btnGameAns2.Visible = false;
            btnGameAns3.Visible = false;
            btnGameAns4.Visible = false;
            
            lblLevel.Text = level;
            lblChucVu.Text = chucVu;
            lblTime.Text = time.ToString();
            if (sound) enableSound();
            ok = true;
            lblNotiGameThang.Visible = false;
            lblNotiGameThua.Visible = false;
            btnBackToMenu.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (ok) trans.Invoke(1); else trans.Invoke(0);
            player.close();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrime_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            tmGame.Stop();
            player.close();
        }
        public void visButton(bool vi)
        {
            btnGameAns1.Visible = vi;
            btnGameAns2.Visible = vi;
            btnGameAns3.Visible = vi;
            btnGameAns4.Visible = vi;
            btnGameTitle.Visible = vi;
        }
        public void soundLoseGame()
        {
            player.URL = @"sound/Prime/loseGameSound.mp3";
            player.controls.play();
        }
        public void soundWinGame()
        {
            player.URL = @"sound/Prime/winGameSound.mp3";
            player.controls.play();
        }
        public void thongBaoWrong()
        {
            visButton(false);
            lblNotiGameThua.Visible = true;
            lblNotiGameThua.Text = "Váng đậu ngốc quá, thua Game rồi!!!";
            btnBackToMenu.Visible = true;
            tmGame.Stop();
            btnBackToMenu.Enabled = true;
            lblGameTitle.Visible = false;
            player.close();
            if (sound) soundLoseGame();
            picWinLoseGame.Visible = true;
            picWinLoseGame.Image = ((System.Drawing.Image)(Properties.Resources.lose));
        }
        public void thongBaoRight()
        {
            visButton(false);
            lblNotiGameThang.Visible = true;
            lblNotiGameThang.Text = "Nhìn không não mà chất đấy,chia buồn bạn đã qua màn nhé!!!";
            btnBackToMenu.Visible = true;
            tmGame.Stop();
            btnBackToMenu.Enabled = true;
            lblGameTitle.Visible = false;
            player.close();
            if (sound) soundWinGame();
            picWinLoseGame.Visible = true;
            picWinLoseGame.Image = ((System.Drawing.Image)(Properties.Resources.win));
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnGameTitle.Text = chooseGameTitle();
            btnGameAns1.Visible = true;
            btnGameAns2.Visible = true;
            btnGameAns3.Visible = true;
            btnGameAns4.Visible = true;
          
            enterExpression();
            tmGame.Start();
            
            btnStart.Enabled = false;
        }
        public void hideButton()
        {
            btnGameAns1.Enabled = false;
            btnGameAns2.Enabled = false;
            btnGameAns3.Enabled = false;
            btnGameAns4.Enabled = false;
        }
        private void btnGameAns1_Click(object sender, EventArgs e)
        {
            if (rightButton != 1) ok = false;
            if (ok) thongBaoRight(); else thongBaoWrong(); 
            hideButton();
        }   

        private void btnGameAns2_Click(object sender, EventArgs e)
        {
            if (rightButton != 2) ok = false;
            if (ok) thongBaoRight(); else thongBaoWrong(); 
            hideButton();
        }

        private void btnGameAns3_Click(object sender, EventArgs e)
        {
            if (rightButton != 3) ok = false;
            if (ok) thongBaoRight(); else thongBaoWrong(); 
            hideButton();
        }

        private void btnGameAns4_Click(object sender, EventArgs e)
        {
            if (rightButton != 4) ok = false;
            if (ok) thongBaoRight(); else thongBaoWrong(); 
            hideButton();
        }

        private void tmGame_Tick(object sender, EventArgs e)
        {
            lblTime.Text = time.ToString();
            time--;
            if (time == -1)
            {
                ok = false;
                tmGame.Stop();
                hideButton();
                btnBackToMenu.Enabled = true;
                thongBaoWrong();
            }
            
        }

        private void lblNotiGame_Click(object sender, EventArgs e)
        {

        }

        private void btnGameAns1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void lblNotiGameThua_Click(object sender, EventArgs e)
        {

        }

        private void picWinLoseGame_Click(object sender, EventArgs e)
        {

        }
    }
}
