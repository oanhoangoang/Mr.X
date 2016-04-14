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
        // tạo mảng button hiển thị các số
        private readonly Button[][] randomBtn = new Button[50][];

        // mảng lưu các số cần tìm
        private readonly int[] randomArray = new int[1000 + 10];

        // biến chạy để hiển thị các phần tử của mảng randomArray
        private int now;

        // mảng ban đầu, originalArray[i]=i, cung cấp giá trị cho mảng randomArray
        private int[] originalArray = new int[1000 + 10];

        // kích thước bảng
        private readonly int sizeTable; 

        // lấy ngẫu nhiên một giá trị của mảng originalArray
        private int locationRandom;

        // số phút chơi
        private int minute;

        // số giây chơi
        private int second;

        // số lượng số cần tìm
        private int numberToFind; 

        // điểm số của người chơi
        private int yourScore; 

        // thời gian chơi
        private int timeToPlay;  

        // lấy các giá trị: kích thước bảng, số lượng số cần tìm, thời gian chơi
        public FindNumDisplay(int size, int num, int time)
        {
            InitializeComponent();
            sizeTable = size;
            numberToFind = num;
            timeToPlay = time;
            try
            {
                wmpSoundTrack.URL = @"sound/FndNum/soundtrack.mp3";
            }
            catch (Exception ex)
            {

            }
        }

        // lấy ngẫu nhiên 1 số từ limitLow tới limitHigh
        private int randomNumber(int limitLow, int limitHigh)
        {
            Random rd = new Random();
            return rd.Next(limitLow, limitHigh + 1);
        }

        // tạo mảng button: kích thước, vị trí, giá trị hiển thị, màu nền, màu chữ, xử lí khi nhấn vào
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

        // tạo ngẫu nhiên mảng các số cần tìm 
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

        //khởi tạo dữ liệu ban đầu
        private void FindNumDisplay_Load(object sender, EventArgs e)
        {
            yourScore = 0;
            now = 1;
            txtFindNum.Text = "";
            txtScoreToPass.Text = "";
            txtYourScore.Text = "";
            minute = timeToPlay / 60;
            second = timeToPlay % 60;         
        }

        // bắt đầu trò chơi
        private void btnStart_Click(object sender, EventArgs e)
        { 
            createButtonArray();
            createRandomArray();
            btnStart.Enabled = false;
            tmrTimeToPlay.Enabled = true;
        }

        // đếm ngược thời gian chơi
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtFindNum.Text = randomArray[now].ToString();
            txtYourScore.Text = yourScore.ToString();
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

        //xử lí khi người chơi nhấn vào button
        private void btnMediate_Click(object sender, EventArgs e)
        {
            Button btnMedia = (Button)sender;
            if (btnMedia.Text == randomArray[now].ToString())
            {
                btnMedia.Visible = false;
                yourScore++;
                try
                {
                    SoundPlayer soundhappy = new SoundPlayer(@"sound/FndNum/happy.wav");
                    soundhappy.Play();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    SoundPlayer soundhappy = new SoundPlayer(@"sound/FndNum/sad.wav");
                    soundhappy.Play();
                }
                catch (Exception ex)
                {

                }
            }
            now++;
        }

        // trả về kết quả của người chơi
        private void answer(){
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++) randomBtn[i][j].Enabled = false;

            if (yourScore >= numberToFind)
            {
                MessageBox.Show("Chúc mừng bạn đã trở thành thực tập viên của công ty chúng tôi", "Thông báo");
            }
            else
            {
                MessageBox.Show("Rất tiếc, bạn đã không trở thành thực tập viên của công ty chúng tôi. Chúc bạn may mắn hơn ở lần sau", "Thông báo");
            }
        }

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            tmrTimeToPlay.Stop();
            this.Close();
        }

        // tắt nhạc khi đóng chương trình
        private void FindNumDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmpSoundTrack.close();
        }
    }
}
