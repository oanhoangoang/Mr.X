using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalExpression
{
    public partial class frmCalExpression : Form
    {
        int kindOfGame;
        string ChucVU, Level;
        bool sound;
        public frmCalExpression(int kindOfGame_,string chucVu_ , string level_,bool sound_)
        {
            InitializeComponent();
            kindOfGame = kindOfGame_; // choose kind of Game ( easy or difficult
            ChucVU = chucVu_;
            Level = level_;
            sound = sound_;
            ///////////
            btnGame1.MouseMove += new MouseEventHandler(btnGame1_MouseMove);
            btnGame1.MouseLeave += new EventHandler(btnGame1_MouseLeave);
            btnGame2.MouseMove += new MouseEventHandler(btnGame2_MouseMove);
            btnGame2.MouseLeave += new EventHandler(btnGame2_MouseLeave);
            btnGame3.MouseMove += new MouseEventHandler(btnGame3_MouseMove);
            btnGame3.MouseLeave += new EventHandler(btnGame3_MouseLeave);

        }

        private void pnGameDis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnGameData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblChucVuInput.Text = ChucVU;
            lblLevelInput.Text = Level;
            lblHuongDan.Text = "Bạn click chuột quả bóng để đưa ra câu trả lời";
            lblGameTitle.Text = "Nhấn bắt đầu để chơi Game";
            lblTime.Text = "20";
            
          //  ToolTip tool = new ToolTip();
         //   tool.SetToolTip(btnGame1, "Click vào để chọn câu trả lời này");
          //  tool.IsBalloon = true;
            btnGame1.Enabled = false;
            btnGame2.Enabled = false;
            btnGame3.Enabled = false;
            btnBackToMenu.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnInfoUser_Paint(object sender, PaintEventArgs e)
        {

        }
        int sec;
        private void btnStart_Click(object sender, EventArgs e)
        {
            // earse border of balloon button 
            btnGame1.FlatStyle = FlatStyle.Flat;
            btnGame1.FlatAppearance.BorderSize = 0;
            btnGame2.FlatStyle = FlatStyle.Flat;
            btnGame2.FlatAppearance.BorderSize = 0;
            btnGame3.FlatStyle = FlatStyle.Flat;
            btnGame3.FlatAppearance.BorderSize = 0;
            // choose kind Of Game
            chooseValue();
            enter(); // xu ly Game
            btnStart.Visible = false;

            // start to count down time
            lblTime.Text = "20";
            sec = int.Parse(lblTime.Text);
            timer.Start();
            /////
            btnGame1.Enabled = true;
            btnGame2.Enabled = true;
            btnGame3.Enabled = true;

            // start to play music
            if (sound) enableSound();
            
        }
        private void thongBaoWrong()
        {
            MessageBox.Show("Chia buồn bạn đã thua,não bạn chưa đủ nếp nhăn", "Thông báo");
        }
        private void thongBaoRight()
        {
            MessageBox.Show("Cũng có não ấy nhỉ, chúc mừng bạn đã qua màn", "Thông báo");
        }
        bool ok = true; // check user win or lose
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = sec.ToString();
            sec--;
            if (sec == -1)
            {
                ok = false;
                timer.Stop();
                btnGame1.Enabled = false;
                btnGame2.Enabled = false;
                btnGame3.Enabled = false;
                btnBackToMenu.Enabled = true;

                thongBaoWrong();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
       
        private void btnGame1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (1 != rightValue) { ok = false; thongBaoWrong(); } else thongBaoRight();  
            btnGame2.Enabled = false;
            btnGame1.Enabled = false;
            btnGame3.Enabled = false;
            btnBackToMenu.Visible = true;
        }
       


        
        private void btnGame3_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnGame1_MouseMove(object sender, MouseEventArgs e)
        {
            btnGame1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.img2));
        }

        private void btnGame1_MouseLeave(object sender, EventArgs e)
        {
            btnGame1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Balloon));
        }

        private void btnGame2_MouseMove(object sender, MouseEventArgs e)
        {
            btnGame2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.img2));
        }

        private void btnGame2_MouseLeave(object sender, EventArgs e)
        {
            btnGame2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Balloon));
        }

        private void btnGame3_MouseLeave(object sender, EventArgs e)
        {
            btnGame3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Balloon));
            
        }

        private void btnGame3_MouseMove(object sender, MouseEventArgs e)
        {
            btnGame3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.img2));
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (2 != rightValue) { ok = false; thongBaoWrong(); } else thongBaoRight(); 
            
            btnGame1.Enabled = false;
            btnGame2.Enabled = false;
            btnGame3.Enabled = false;
            btnBackToMenu.Visible = true;
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (3 != rightValue) { ok = false; thongBaoWrong(); } else thongBaoRight();
            btnBackToMenu.Visible = true;
            btnGame1.Enabled = false;
            btnGame2.Enabled = false;
            btnGame3.Enabled = false;
            
        }
        private bool kq;
        public void setAns(bool ok)
        {
            this.kq=ok;
        }
        public bool getAns()
        {
            return (this.kq);
        }
        public delegate void truyen(int value);
        public truyen trans;
         
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
           // setAns(ok);
            if (ok) trans.Invoke(1); else trans.Invoke(0);
            player.close();
            this.Close();
        }

        private void frmGameTinhBieuThuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            ok = false;
            if (sec >= 0)
            { timer.Stop(); }
           // if (ok) trans.Invoke(1); else trans.Invoke(0);
            setAns(ok);
            player.close();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        
    }   
}
