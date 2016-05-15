using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArrMsc
{
    public partial class ArrMscDisp : Form
    {
        // Infomation of Player and Game
        int lvlGame; 
        string rank, lvl;
        bool enableSound;

        // Check variable: Check = 0 Lose; Check = 1 Win
        int check = 0; 

        // Time (second), number of notes (n), count variable
        int sec;
        int n;
        int count = 0;

        // Arrays of Note sound and Note name
        private string[] linkNote = new string[7] { "sound/ArrMsc/1.wav", "sound/ArrMsc/2.wav", "sound/ArrMsc/3.wav", "sound/ArrMsc/4.wav", "sound/ArrMsc/5.wav", "sound/ArrMsc/6.wav", "sound/ArrMsc/7.wav" };
        private string[] note = new string[7] {"Do","Re","Mi","Fa","Sol","La","Si"};

        //SoundPlayer soundtrack = new SoundPlayer(@"sound/ArrMsc/Soundtrack1.wav");
        SoundPlayer soundWin = new SoundPlayer(@"sound/ArrMsc/Win.wav");
        SoundPlayer soundLose = new SoundPlayer(@"sound/ArrMsc/Lose.wav");
 
        private int[] a = new int[5];
        private int[] noteAt = new int[5] { 0, 0, 0, 0, 0 };
        private int[] dd = new int[5] { 0, 0, 0, 0, 0};
        
        // Strings to save the answers
        string strAns = "", strPlrAns = "";
        

        //
        // Call Form
        //
        public ArrMscDisp(int xlvlGame, string xRank, string xLvl, bool xEnableSound) 
        {
            InitializeComponent();
            lvlGame = xlvlGame;
            rank = xRank;
            lvl = xLvl;
            enableSound = xEnableSound;
        }

        //
        // Prepare to play
        //
        private void ArrMscDisp_Load(object sender, EventArgs e)
        {
            lblLevelData.Text = lvl;
            lblRankData.Text = rank;
            btn0.Visible = false; 
            btn1.Visible = false; 
            btn2.Visible = false; 
            btn3.Visible = false; 
            btn4.Visible = false;
            txtNoti.Text = "Hãy sắp xếp các nốt theo thứ tự bạn nghe được :)";
            if (lvlGame == 1) n = 3; else n = 5;
            initData();
        }

        //
        // Initialize
        //
        private void initData()
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                // random Note
                a[i] = rd.Next(100) % 7;
                strAns = strAns + a[i].ToString();
                
                // random Note position button
                int x;
                do
                {
                    x = rd.Next(n);
                }
                while ( dd[x] == 1 || x >=n );
                dd[x] = 1; noteAt[x] = a[i];
                
                switch (x) 
                {
                    case 0: btn0.Text = note[a[i]]; break;
                    case 1: btn1.Text = note[a[i]]; break;
                    case 2: btn2.Text = note[a[i]]; break;
                    case 3: btn3.Text = note[a[i]]; break;
                    case 4: btn4.Text = note[a[i]]; break;
                }
            }
        }

        //
        // play Sound
        //
        private void playMusic(string link)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@link);
                sp.Play();
            }
            catch (Exception ex) { }
        }

        //
        // Click button Start
        // 
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btn0.Visible = true; btn0.Enabled = false;
            btn1.Visible = true; btn1.Enabled = false;
            btn2.Visible = true; btn2.Enabled = false;
            if (n == 5) { btn3.Visible = true; btn3.Enabled = false; }
            if (n == 5) { btn4.Visible = true; btn4.Enabled = false; }
            sec = -1;
            tmrPlaySound.Start();
        }

        //
        // Play the Sound
        //
        private void tmrPlaySound_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 0) playMusic( @linkNote[a[0]] );
            if (sec == 1) playMusic( @linkNote[a[1]] );
            if (sec == 2) playMusic( @linkNote[a[2]] );
            if (sec == 3 && n == 5) playMusic( @linkNote[a[3]] );
            if (sec == 4 && n == 5) playMusic( @linkNote[a[4]] );
            if (sec == n+1) txtNoti.Text = "Bây giờ bạn sẽ có " + (n*3).ToString() + " giây để hoàn thành ^^";
            if (sec == n+3)
            {
                tmrPlaySound.Stop();                
                txtNoti.Text = "Thời gian BẮT ĐẦU. Nhanh tay lên nào !";
                sec = n * 3; tmr.Start();
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
            }
        }

        //
        // Timer to Play
        //
        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTimeCount.Text = sec.ToString();
            sec--;
            if (sec == -1) notiWrong();
        }

        //
        // Check the Answer
        //
        private void checkAnswer()
        {
            lblTimeCount.Text = "0";
            if ( strPlrAns == strAns ) notiRight();
            else notiWrong();
        }

        //
        // Announce the Answer
        //
        private void notiRight()
        {
            tmr.Stop(); check = 1;
            if (enableSound) soundWin.Play();
            txtNoti.Text = "Thật tuyệt vời, bạn quá là xuất sắc :))";
        }

        private void notiWrong()
        {
            tmr.Stop(); check = 0;
            if (enableSound) soundLose.Play();
            txtNoti.Text = "Thua mất rồi, lần sau cố gắng lên nhé :<";
        }

        //
        // Click the Answer Button
        //
        private void btn0_Click(object sender, EventArgs e)
        {
            strPlrAns = strPlrAns + noteAt[0].ToString();
            btn0.BackColor = System.Drawing.Color.FromArgb(82, 179, 217);
            btn0.Enabled = false; count++; if (count == n) checkAnswer();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            strPlrAns = strPlrAns + noteAt[1].ToString();
            btn1.BackColor = System.Drawing.Color.FromArgb(82, 179, 217);
            btn1.Enabled = false; count++; if (count == n) checkAnswer();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            strPlrAns = strPlrAns + noteAt[2].ToString();
            btn2.BackColor = System.Drawing.Color.FromArgb(82, 179, 217);
            btn2.Enabled = false; count++; if (count == n) checkAnswer();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            strPlrAns = strPlrAns + noteAt[3].ToString();
            btn3.BackColor = System.Drawing.Color.FromArgb(82, 179, 217);
            btn3.Enabled = false; count++; if (count == n) checkAnswer();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            strPlrAns = strPlrAns + noteAt[4].ToString();
            btn4.BackColor = System.Drawing.Color.FromArgb(82, 179, 217);
            btn4.Enabled = false; count++; if (count == n) checkAnswer();
        }

        //
        // Back to Menu
        //
        public delegate void truyen(int value);
        public truyen trans;
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (enableSound) soundWin.Stop(); if (enableSound) soundLose.Stop();
            if (check == 1) trans.Invoke(1); else trans.Invoke(0);
            this.Close();
        }
    }
}
