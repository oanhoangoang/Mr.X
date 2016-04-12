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

namespace RemMe
{
    public partial class RememberMe : Form
    {
        private int sizeTable;
        private int numberOfAnswer; // so luong dap an cua tro choi
        private int numberOfChoice; // so luong luot choi cua nguoi choi
        private int minute = 0;
        private int second = 5;
        private int selectedColor; // vi tri cua mau duoc chon trong mang ArrayColor
        private readonly Button[][] randomBtn = new Button[30][]; 
        private string[] arrayColor = new string[10]; // mang cung cap hex code cho cac mau
        private int[] number = new int[100]; // number[i]=so luong o co mau i trong bang
        private int location;  
        private int value;   
        private bool[] checkColor = new bool[100 + 10];
        private int YoungScore=0; // diem so cua nguoi choi
        private int[] original = new int[1000 + 10]; // original[i]=mau ban dau cua button co ten=i
        private int timeToPlay; // thoi gian choi
        
        // ham lay ngau nhien 1 so
        private int randomNumber(int limitLow, int limitHigh)
        {
            Random rd = new Random();
            return rd.Next(limitLow, limitHigh + 1);
        }

        // lay cac gia tri: kich thuoc cua bang, so dap an cua game, so luot duoc lua chon va thoi gian choi
        public RememberMe(int size, int numAns,int numChoice, int time)
        {
            InitializeComponent();
            sizeTable = size;
            numberOfAnswer = numAns;
            numberOfChoice = numChoice;
            timeToPlay = time;
            wmpSoundTrack.URL = @"sound/RemMe/SoundTrack.mp3";
        }

        private void RememberMe_Load(object sender, EventArgs e)
        {

            arrayColor[1] = "#33CCFF";
            arrayColor[2] = "#355C96";
            arrayColor[3] = "#9370db";
            arrayColor[4] = "#EE3233";
            selectedColor = randomNumber(1, 3);
            if (selectedColor == 1)
            {
                number[1] = numberOfAnswer;
                number[2] = (sizeTable * sizeTable - number[1]) / 2;
                number[3] = sizeTable * sizeTable - number[1] - number[2];
            }
            else if (selectedColor == 2)
            {
                number[2] = numberOfAnswer;
                number[1] = (sizeTable * sizeTable - number[2]) / 2;
                number[3] = sizeTable * sizeTable - number[1] - number[2];
            }
            else
            {
                number[3] = numberOfAnswer;
                number[1] = (sizeTable * sizeTable - number[3]) / 2;
                number[2] = sizeTable * sizeTable - number[1] - number[3];
            }
            for (int i = 1; i <= sizeTable * sizeTable; i++) checkColor[i] = false;
        }

        // tao mang button: ten, kich thuoc, vi tri, mau sac ban dau
        private void createButtonArray()
        {
            for (var i = 1; i <= sizeTable; i++) randomBtn[i] = new Button[30];
            for (var i = 1; i <= sizeTable; i++)
                for (var j = 1; j <= sizeTable; j++)
                {
                    value=(i-1)*sizeTable+j;
                    randomBtn[i][j] = new Button();
                    randomBtn[i][j].Name = value.ToString();
                    randomBtn[i][j].Size = new Size(55, 55);
                    randomBtn[i][j].FlatStyle = FlatStyle.Flat;
                    randomBtn[i][j].Click += new EventHandler(btnMediate_Click);
                    Controls.Add(randomBtn[i][j]);
                    randomBtn[i][j].Enabled = false;
                    randomBtn[i][j].Location = new Point(i * 60 + 20, j * 60 + 20);
                   
                    location = randomNumber(1, 3);
                    while (number[location] == 0 && location < 3) location++;
                    while (number[location] == 0 && location >1 ) location--;
                    number[location]--;
                    if (location == selectedColor) checkColor[value] = true;
                    original[value] = location;

                    randomBtn[i][j].BackColor = ColorTranslator.FromHtml(arrayColor[location]);
                 
                    pnlGameDisplayGray.Controls.Add(randomBtn[i][j]);
                }
        }

        // bat dau tro choi
        private void btnStart_Click(object sender, EventArgs e)
        {
            createButtonArray();
            tmrTimeToWatch.Enabled = true;
            btnStart.Enabled = false;
            txtSelectedColor.BackColor = ColorTranslator.FromHtml(arrayColor[selectedColor]);
        }

        // dem nguoc thoi gian nguoi choi co the xem mau ban dau cua cac button
        private void tmrTimeToWatch_Tick(object sender, EventArgs e)
        {
            txtYoung_Score.Text = YoungScore.ToString();
            txtScoreToPass.Text = numberOfAnswer.ToString();
            txtOpportunity.Text = numberOfChoice.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if (minute > 0 || second > 0)
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
                tmrTimeToWatch.Stop();
                afterWatch();
            }
        }

        // khoi tao sau khi het thoi gian xem
        private void afterWatch()
        {
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++)
                {
                    randomBtn[i][j].Enabled = true;
                    randomBtn[i][j].BackColor = ColorTranslator.FromHtml(arrayColor[4]);
                }
            minute = timeToPlay / 60;
            second = timeToPlay % 60;
            tmrTimeToPlay.Enabled = true;
        }

        // dem nguoc thoi gian nguoi choi co the chon dap an
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYoung_Score.Text = YoungScore.ToString();
            txtScoreToPass.Text = numberOfAnswer.ToString();
            txtOpportunity.Text = numberOfChoice.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ((minute > 0 || second > 0) && numberOfChoice>0 )
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
        // xu li khi nguoi choi chon vao button
        private void btnMediate_Click(object sender, EventArgs e)
        {
            numberOfChoice--;
            Button btnMedia = (Button)sender;
            value = Int32.Parse(btnMedia.Name);
            btnMedia.BackColor = ColorTranslator.FromHtml(arrayColor[original[value]]);
            if (checkColor[value])
            {
                YoungScore++;
                SoundPlayer sp = new SoundPlayer(@"sound/RemMe/happy.wav");
                sp.Play();
                btnMedia.Visible = false;
            }
            else
            {
                SoundPlayer sp = new SoundPlayer(@"sound/RemMe/sad.wav");
                sp.Play();
            }
        }

        //dua ra cau tra loi cho nguoi choi, va hien lai mang ban dau
        private void answer()
        {
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++)
                {
                    randomBtn[i][j].Enabled = false;
                    value = Int32.Parse(randomBtn[i][j].Name);
                    randomBtn[i][j].BackColor = ColorTranslator.FromHtml(arrayColor[original[value]]);
                }

            if (YoungScore>= numberOfAnswer)
            {
                MessageBox.Show("Chúc mừng bạn đã vượt qua trò chơi này", "Thông báo");
            }
            else
            {
                MessageBox.Show("Rất tiếc bạn đã không vượt qua trò chơi này", "Thông báo");
            }
        }
        
        //tat game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // tat nhac khi dong chuong trinh
        private void RememberMe_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmpSoundTrack.close();
        }
    }
}
