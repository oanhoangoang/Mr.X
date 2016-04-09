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

namespace FndNum
{
    public partial class FindNumDisplay : Form
    {
        private readonly Button[][] randomBtn = new Button[50][];
        private readonly int[] randomArray = new int[1000 + 10];
        private int[] originalArray = new int[1000 + 10];
        private readonly int sizeTable;
        private int now;
        private int locationRandom;
        private int minute, second;
        private int numberToFind;
        private int your_score;
        private int timeToPlay;

        public FindNumDisplay(int size, int num, int time)
        {
            InitializeComponent();
            sizeTable = size;
            numberToFind = num;
            timeToPlay = time;
        }

        private int randomNumber(int limitLow, int limitHigh)
        {
            Random rd = new Random();
            return rd.Next(limitLow, limitHigh + 1);
        }

        private void createButtonArray()
        {
            for (var i = 1; i <= sizeTable * sizeTable; i++) originalArray[i] = i;
            for (var i = 1; i <= sizeTable; i++) randomBtn[i] = new Button[40];
            now = 1;
            for (var i = 1; i <= sizeTable; i++)
                for (var j = 1; j <= sizeTable; j++)
                {
                    randomBtn[i][j] = new Button();
                    randomBtn[i][j].Size = new Size(55, 55);

                    locationRandom = randomNumber(1, sizeTable * sizeTable - now+1);
                    randomBtn[i][j].Text = originalArray[locationRandom].ToString();
                    originalArray[locationRandom] = originalArray[sizeTable * sizeTable - now + 1];
                    now++;

                    randomBtn[i][j].Location = new Point(i * 60 + 20, j * 60 + 20);
                    randomBtn[i][j].BackColor = Color.Red;
                    randomBtn[i][j].FlatStyle = FlatStyle.Flat;
                    randomBtn[i][j].ForeColor = Color.White;
                    randomBtn[i][j].Click += btnMediate_Click;
                    Controls.Add(randomBtn[i][j]);
                    randomBtn[i][j].Enabled = true;

                    pnlGameDisplayGray.Controls.Add(randomBtn[i][j]);
                }
            now = 1;
        }
        private void createRandomArray()
        {
            for (var i = 1; i <= sizeTable * sizeTable; i++) originalArray[i] = i;
            for (var i = 1; i <= sizeTable*sizeTable; i++)
            {
                locationRandom = randomNumber(1, sizeTable * sizeTable - i + 1);
                randomArray[i] = originalArray[locationRandom];
                originalArray[locationRandom] = originalArray[sizeTable * sizeTable - i + 1];
            }
        }


        private void FindNumDisplay_Load(object sender, EventArgs e)
        {
            your_score = 0;
            now = 1;
            txtFindNum.Text = "";
            txtScoreToPass.Text = "";
            txtYoung_Score.Text = "";
            minute = timeToPlay / 60;
            second = timeToPlay % 60;         
        }

        private void btnStart_Click(object sender, EventArgs e)
        { 
            createButtonArray();
            createRandomArray();
            btnStart.Enabled = false;
            btnReset.Enabled = true;
            tmrTimeToPlay.Enabled = true;
        }

        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtFindNum.Text = randomArray[now].ToString();
            txtYoung_Score.Text = your_score.ToString();
            txtScoreToPass.Text = numberToFind.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ((minute > 0 || second > 0) && now <= sizeTable * sizeTable)
            {
                if (second == 0 && minute > 0)
                {
                    second = 60;
                    minute--;
                }
                second--;
            }
            else
            {
                tmrTimeToPlay.Stop();
                answer();
            }
        }

        private void btnMediate_Click(object sender, EventArgs e)
        {
            Button btnMedia = (Button)sender;
            if (btnMedia.Text == randomArray[now].ToString())
            {
                btnMedia.Visible = false;
                your_score++;
            }
            now++;
        } 

        private void answer(){
            if (your_score >= numberToFind)
            {
                   MessageBox.Show("Chúc mừng bạn đã trở thành thực tập viên của công ty chúng tôi", "Thông báo");
            }
            else
            {
                 MessageBox.Show("Rất tiếc, bạn đã không trở thành thực tập viên của công ty chúng tôi. Chúc bạn may mắn hơn ở lần sau", "Thông báo"); 
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
