using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FstCal
{
    public partial class FstCalDisp : Form
    {
        int lvlGame; // level of Game
        string rank, lvl; // Player rank & level
        int check; // check = 0 Lose; check = 1 Win
        int num1, num2, playerAns, gameAns;

        // Call Form
        public FstCalDisp(int xlvlGame, string xRank, string xLvl) 
        {
            InitializeComponent();
            lvlGame = xlvlGame;
            rank = xRank;
            lvl = xLvl;
        }
        //
        // Prepare to play
        //
        private void FstCalDisp_Load(object sender, EventArgs e) 
        {
            lblLevelData.Text = lvl;
            lblRankData.Text = rank;
            lblGuide.Text = "Nếu đã sẵn sàng để thử việc, hãy chọn Bắt đâu ;)";

            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblNum3.Visible = false;
            lblSign.Visible = false;
            txtAns.Visible = false;
            btnAns.Visible = false;
            lblNoti.Visible = false;
        }
        //
        // Load the calculation
        //
        public void loadGameData()
        {
            Random rd = new Random();

            lblNum1.Visible = true;
            lblNum2.Visible = true;
            lblNum3.Visible = true;
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
        // Click Start button
        //
        int sec;
        private void btnStart_Click(object sender, EventArgs e) 
        {
            lblGuide.Text = "Kết quả phép tính này là bao nhiêu ??";
            loadGameData();
            btnStart.Visible = false;

            lblTimeCount.Text = "20";
            sec = int.Parse(lblTimeCount.Text);
            timer.Start();
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
        // Player gives the answer
        //
        private void btnAns_Click(object sender, EventArgs e)   
        {
            timer.Stop();
            playerAns = int.Parse(txtAns.Text);
            gameAns = calAns(num1, num2);

            if (playerAns == gameAns)
            {
                check = 1; notiRightAns();
            }
            else
            {
                check = 0;
                notiWrongAns();
            }
        }
        //
        // Timer
        //
        private void timer_Tick(object sender, EventArgs e) 
        {
            lblTimeCount.Text = sec.ToString();
            sec--;
            if (sec == -1) 
            {
                check = 0;
                timer.Stop();
                notiTimeUp();
            }
        }
        //
        // Time up
        //
        public void notiTimeUp()
        {
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblNum3.Visible = false;
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
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblNum3.Visible = false;
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
            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblNum3.Visible = false;
            lblSign.Visible = false;
            txtAns.Visible = false;
            btnAns.Visible = false;
            lblGuide.Visible = false;
            btnAns.Visible = false;
            txtAns.Visible = false;
            lblNoti.Visible = true;
            lblNoti.Text = "Đen thôi, đỏ khác liền =)) Gặp lại bạn lần sau !";
        }
        public delegate void truyen(int value);
        public truyen trans;

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            if (check==1) trans.Invoke(1); else trans.Invoke(0);
            this.Close();
        }
    }
}
