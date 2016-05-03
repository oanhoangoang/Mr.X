using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LgImg
{
    public partial class LgImgDisp : Form
    {
        int lvlGame; // level of Game
        string rank, lvl; // Player rank & level
        int check = 0; // check = 0 Lose; check = 1 Win
        string strAns; // the Right Answer
        int sec; // second timer
        //
        // Call Form
        //
        public LgImgDisp(int xlvlGame, string xRank, string xLvl) 
        {
            InitializeComponent();
            lvlGame = xlvlGame;
            rank = xRank;
            lvl = xLvl;
            loadGameDisp();
        }
        //
        // Load and init the game display
        //
        private void loadGameDisp()
        {
            lblLvlData.Text = lvl.ToString();
            lblRankData.Text = rank.ToString();
            lblGuide.Text = "Bấm Bắt đầu nếu bạn đã sẵn sàng :)";
            btnA.Visible = false; btnB.Visible = false; btnC.Visible = false; btnD.Visible = false; btnE.Visible = false;
            pic.Visible = false;
        }
        //
        // Show the Image Question
        //
        private void showImg(string link)
        {
            try
            {
                Image img = Image.FromFile(@link);
                pic.Image = img;
            }
            catch (Exception ex) { }
        }

        private string[] linkImg = new string[2]{"picture/LgImg/1.jpg","picture/LgImg/2.jpg"};
        private string[] ansImg = new string[2]{"D","B"};
        //
        // Click button Start
        //
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int x = rd.Next(0, 100) % 2; // Load random Question and Answer
            strAns = ansImg[x];
            showImg(linkImg[x]);

            lblGuide.Text = "Hãy chọn hình còn thiếu thích hợp nhất nhé !";
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnE.Visible = true;
            pic.Visible = true;
            lblTimeCnt.Text = "20";
            sec = int.Parse(lblTimeCnt.Text);
            timer.Start();
            btnStart.Enabled = false;
        }
        //
        // Timer
        //
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimeCnt.Text = sec.ToString();
            sec--;
            if (sec == -1)
            {
                check = 0;
                notiWrong();
            }
        }
        //
        // Notify the Right Answer
        //
        private void notiRight()
        {
            timer.Stop();
            lblGuide.Text = "Chúc mừng bạn đã vượt qua thử thách. Làm tốt lắm :)";
        }
        //
        // Notify the Wrong Answer
        //
        private void notiWrong()
        {
            timer.Stop();
            lblGuide.Text = "Có vẻ lần này bạn chưa may mắn rồi. Cố gắng hơn lần sau nhé !";
        }
        //
        // Process when player clicks answer buttons
        //
        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == strAns) { check = 1; notiRight(); }
            else { check = 0; notiWrong(); }
            btnA.Visible = false; btnB.Visible = false; btnC.Visible = false; btnD.Visible = false; btnE.Visible = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == strAns) { check = 1; notiRight(); }
            else { check = 0; notiWrong(); }
            btnA.Visible = false; btnB.Visible = false; btnC.Visible = false; btnD.Visible = false; btnE.Visible = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == strAns) { check = 1; notiRight(); }
            else { check = 0; notiWrong(); }
            btnA.Visible = false; btnB.Visible = false; btnC.Visible = false; btnD.Visible = false; btnE.Visible = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == strAns) { check = 1; notiRight(); }
            else { check = 0; notiWrong(); }
            btnA.Visible = false; btnB.Visible = false; btnC.Visible = false; btnD.Visible = false; btnE.Visible = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (btnE.Text == strAns) { check = 1; notiRight(); }
            else { check = 0; notiWrong(); }
            btnA.Visible = false; btnB.Visible = false; btnC.Visible = false; btnD.Visible = false; btnE.Visible = false;
        }
        //
        // Back to Menu
        //
        public delegate void truyen(int value);
        public truyen trans;
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (check == 1) trans.Invoke(1); else trans.Invoke(0);
            this.Close();
        }

    }
}
