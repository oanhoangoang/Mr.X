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

namespace OrBut
{
    public partial class orderButton : Form
    {
        // tạo mảng button hiển thị các số
        private readonly Button[][] randomBtn = new Button[50][];

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

        // lấy các giá trị: level, chức vụ, kích thước bảng, số lượng button phải ấn, thời gian chơi, tắt nhạc hay không, chế độ chơi
        public orderButton(int level, string position, int size, int num, int time, bool turnOffSound, int determine)
        {
            InitializeComponent();
            sizeTable = size;
            numberToFind = num;
            minute = num / 60;
            second = num % 60;
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            if (turnOffSound == false)
            {
                try
                {
                    wmpSoundTrack.URL = @"sound/orBut/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }
        }

        // lấy ngẫu nhiên 1 số từ limitLow tới limitHigh
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

        // làm chậm thời gian đi x milisecond
        private void timeDelay(int x)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(x);
            });
            t.Wait();
        }

        // xác định vị trí hiển trị cho các button
        private int getLocation(int size, int num, bool check)
        {
            if (check == true) return (809 - size * num) / 2;
            else return (654 - size * num) / 2;
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
       
                    locationRandom = randomNumber(1, sizeTable * sizeTable - now + 1);
                    randomBtn[i][j].Name = originalArray[locationRandom].ToString();
                    originalArray[locationRandom] = originalArray[sizeTable * sizeTable - now + 1];
                    now++;

                    randomBtn[i][j].Size = new Size(55, 55);
                    randomBtn[i][j].Location = new Point((i - 1) * 60 + getLocation(55, sizeTable, true), (j - 1) * 60 + getLocation(55, sizeTable, false));
                    randomBtn[i][j].BackColor = Color.Red;
                    randomBtn[i][j].FlatStyle = FlatStyle.Flat;
                    randomBtn[i][j].ForeColor = Color.White;
                    randomBtn[i][j].Visible = false;
                    randomBtn[i][j].Click += btnMediate_Click;              
                    Controls.Add(randomBtn[i][j]);
                    randomBtn[i][j].Enabled = true;
                    pnlGameDisplayGray.Controls.Add(randomBtn[i][j]);
                }

            for (now = 1; now <= numberToFind; now++)
            {
                for (var i = 1; i <= sizeTable; i++)
                for (var j = 1; j <= sizeTable; j++)
                    if (Int16.Parse(randomBtn[i][j].Name) == now)
                    {      
                        randomBtn[i][j].Visible = true;
                        timeDelay(200);
                    }
            }
        }

        // bắt đầu trò chơi
        private void btnStart_Click(object sender, EventArgs e)
        {
            createButtonArray();
            now = 1;
            btnStart.Enabled = false;
            tmrTimeToPlay.Enabled = true;
        }

        //xử lí khi người chơi nhấn vào button
        private void btnMediate_Click(object sender, EventArgs e)
        {
            Button btnMedia = (Button)sender;
            if (btnMedia.Name == now.ToString())
            {
                btnMedia.Visible = false;
                now++;
                playMusic("sound/orBut/happy.wav");
            }
            else
            {
                playMusic("sound/orBut/sad.wav");
                tmrTimeToPlay.Stop();
                answer();
            }
        }

        // đếm ngược thời gian chơi

        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ((minute > 0 || second > 0) && now <= numberToFind)
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

        public delegate void truyen(int value);
        public truyen trans;

        // trả về kết quả của người chơi
        private void answer()
        {
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++) randomBtn[i][j].Visible = false;

            if (now > numberToFind)
            {
                trans.Invoke(1);
                try
                {
                    picVictory.Visible = true;
                    picVictory.Image = Image.FromFile(@"picture/orBut/victory.jpg");
                    picVictory.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) { }

                try
                {
                    wmpSoundTrack.URL = @"sound/orBut/victory.mp3";
                }
                catch (Exception ex) { }

                MessageBox.Show("Chúc mừng bạn đã vượt qua thử thách này", "Thông báo");
            }
            else
            {
                trans.Invoke(0);

                try
                {
                    picFail.Visible = true;
                    picFail.Image = Image.FromFile(@"picture/orBut/fail.jpg");
                    picFail.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) { }

                MessageBox.Show("Rất tiếc bạn đã không vượt qua thử thách này. Chúc may mắn", "Thông báo");
            }
        }

        // tắt nhạc khi đóng chương trình
        private void orderButton_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrTimeToPlay.Stop();
            wmpSoundTrack.close();
        }

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
