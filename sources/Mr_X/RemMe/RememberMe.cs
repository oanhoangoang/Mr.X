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
        // kích thước bảng trò chơi
        private int sizeTable;

        // số lượng ô người chơi phải chọn
        private int numberOfAnswer;

        // số lượng lượt chọn của người chơi
        private int numberOfChoice; 

        // số phút chơi
        private int minute = 0;

        // số giây chơi
        private int second = 5;

        // mảng cung cấp hex code của các màu
        private string[] arrayColor = new string[10];

        //vị trí của màu được chọn trong mảng ArrayColor, có giá trị từ 1 tới 3
        private int selectedColor; 

        // tạo mảng button hiển thị các màu
        private readonly Button[][] randomBtn = new Button[30][];

        // number[i] là số lượng ô có màu thứ i trong bảng trò chơi 
        private int[] number = new int[10];

        // tên của các button
        private int value;

        // original[i]=màu ban đầu của button có tên là i
        private int[] original = new int[1000 + 10];

        // môi button sẽ random một location trong mảng ArrayColor, có giá trị từ 1 tới 3
        private int location;  

        // check[i]=true nếu button tên i có location=selectedColor, ngược lại là false
        private bool[] checkColor = new bool[100 + 10];

        // điểm số của người chơi
        private int yourScore=0;

        // thời gian chơi
        private int timeToPlay; 
        
        // lấy ngẫu nhiên một số trong khoảng từ limitLow tới limitHigh
        Random rd = new Random();
        private int randomNumber(int limitLow, int limitHigh)
        {
            
            return rd.Next(limitLow, limitHigh + 1);
        }

        // phát nhạc theo đường dẫn: link
        private void playMusic(string link)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(@link);
                sp.Play();
            }
            catch (Exception ex) { }
        }

        // xác định vị trí hiển trị cho các button
        private int getLocation(int size, int num, bool check)
        {
            if (check == true) return (809 - size * num) / 2;
            else return (654 - size * num) / 2;
        }

        // lấy các giá trị:level, chức vụ, kích thước bảng, số lượng ô người chơi phải chọn, số lượng lượt người chơi được chọn, thời gian chơi, tắt nhạc hay không, hiển thị chức vụ truyền vào hay không: 1=có; 2=không
        public RememberMe(int level, string position, int size, int numAns, int numChoice, int time, bool turnOffSound, int determine)
        {
            InitializeComponent();
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            sizeTable = size;
            numberOfAnswer = numAns;
            numberOfChoice = numChoice;
            timeToPlay = time;
            if (turnOffSound == false)
            {
                try
                {
                    wmpSoundTrack.URL = @"sound/RemMe/soundTrack.mp3";
                }
                catch (Exception ex){}
            }
            btnMediate.Location = new Point( (809-131)/2 ,8);
            
        }

        // random giá trị của selectedColor, khởi tạo mảng number[]
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

        // tạo mảng button: tên, kích thước, vị trí, màu sắc ban đầu, FlatStyle, xử lí khi nhấn vào
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
                    randomBtn[i][j].Location = new Point( (i-1) * 60 +getLocation(55,sizeTable,true), (j-1) * 60 + getLocation(55,sizeTable,false) );
                   
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

        // bắt đầu trò chơi: tạo mảng randomBtn
        private void btnStart_Click(object sender, EventArgs e)
        {
            createButtonArray();
            tmrTimeToWatch.Enabled = true;
            btnStart.Enabled = false;
            btnMediate.BackColor = ColorTranslator.FromHtml(arrayColor[selectedColor]);
        }

        // đếm ngược thời gian người chơi có thể xem màu ban đầu của các button
        private void tmrTimeToWatch_Tick(object sender, EventArgs e)
        {
            txtYourScore.Text = yourScore.ToString();
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

        // khởi tạo sau khi hết thời gian xem
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

        // đếm ngược thời gian người chơi có thể chọn đáp án
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYourScore.Text = yourScore.ToString();
            txtScoreToPass.Text = numberOfAnswer.ToString();
            txtOpportunity.Text = numberOfChoice.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ((minute > 0 || second > 0) && numberOfChoice > 0 && yourScore < numberOfAnswer)
            {
                if ((second == 0 && minute > 0) )
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

        // xử lí khi người chơi chọn vào button
        private void btnMediate_Click(object sender, EventArgs e)
        {
            numberOfChoice--;
            Button btnMedia = (Button)sender;
            value = Int32.Parse(btnMedia.Name);
            btnMedia.BackColor = ColorTranslator.FromHtml(arrayColor[original[value]]);
            if (checkColor[value])
            {
                yourScore++;

                playMusic("sound/RemMe/happy.wav");
                btnMedia.Visible = false;
            }
            else
            {
                playMusic("sound/RemMe/sad.wav");
            }
        }

        public delegate void truyen(int value);
        public truyen trans;

        //đưa ra câu trả lời cho người chơi, và hiện lại mảng ban đầu
        private void answer()
        {
            btnMediate.Visible = false;
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++)
                {
                    randomBtn[i][j].Enabled = false;
                    value = Int32.Parse(randomBtn[i][j].Name);
                    randomBtn[i][j].BackColor = ColorTranslator.FromHtml(arrayColor[original[value]]);
                }
            DialogResult dig;
            if (yourScore >= numberOfAnswer)
            {
                trans.Invoke(1);
                try
                {
                    picVictory.Visible = true;
                    picVictory.Image = Image.FromFile(@"picture/RemMe/victory.jpg");
                    picVictory.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) { }

                try
                {
                    wmpSoundTrack.URL = @"sound/RemMe/victory.mp3";
                }
                catch (Exception ex) { }

                dig = MessageBox.Show("Chúc mừng bạn đã vượt qua thử thách này", "Thông báo");
            }
            else
            {
                trans.Invoke(0);
                dig = MessageBox.Show("Rất tiếc bạn đã không vượt qua thử thách này", "Thông báo");
            }
            if (dig == DialogResult.OK) this.Close();
        }

        // tắt nhạc khi đóng chương trình
        private void RememberMe_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrTimeToPlay.Stop();
            tmrTimeToWatch.Stop();
            wmpSoundTrack.close();
        }

        // tắt chương trình
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
