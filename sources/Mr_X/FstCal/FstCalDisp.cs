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

        // Call Form
        public FstCalDisp(int xlvlGame, string xRank, string xLvl) 
        {
            InitializeComponent();
            lvlGame = xlvlGame;
            rank = xRank;
            lvl = xLvl;
        }

        // Prepare to play
        private void FstCalDisp_Load(object sender, EventArgs e) 
        {
            lblLevelData.Text = lvl;
            lblRankData.Text = rank;
            lblGuide.Text = "Nếu đã sẵn sàng để thử việc, hãy chọn Bắt đâu ;)";

            lblNum1.Visible = false;
            lblNum2.Visible = false;
            lblSign.Visible = false;
            txtAns.Visible = false;
            btnAns.Visible = false;
            lblNoti.Visible = false;
        }

        // Start the game
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

        // Player gives the answer
        private void btnAns_Click(object sender, EventArgs e)   
        {
            timer.Stop();
            playerAns = int.Parse(txtAns.Text);
            gameAns = calAns(num1, num2);

            if (playerAns == gameAns)
            {
                check = 1;
                notiRightAns();
            }
            else
            {
                notiWrongAns();
                check = 0;
            }
        }

        // Timer
        private void timer_Tick(object sender, EventArgs e) 
        {
            lblTimeCount.Text = sec.ToString();
            sec--;
            if (sec == -1) 
            {
                timer.Stop();
                check = 0; notiTimeUp();
            }
        }

    }
}
