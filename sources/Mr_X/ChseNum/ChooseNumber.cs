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
using System.Drawing;
using WMPLib;

namespace ChseNum
{
    public partial class ChooseNumber : Form
    {
        // kích thước bảng
        private int sizeTable;
     
        // mức độ của game
        private int KindOfGame;
        
        // tổng
        private int numberToFind;

        // thời gian chơi
        private int TimeOfGame;
       
        // thời gian chơi tính bằng phút
        private int minute;

        // thời gian chơi tính bằng giây
        private int second;
       
        // số lượng số cần chọn, phụ thuộc vào KindOfGame
        private int value;

        // là mảng lưu giá trị các số sẽ hiển thị trên button
        private int[] original=new int[100+10];

        // tổng của người chơi
        private int yourSum;

        // mảng button
        private Button[][] randomBtn = new Button[100 + 10][];
        
        // số lần đã chơi ở game này của người chơi
        private int number;

        // vị trí random
        private int location;

        // phát nhạc nền
        private WindowsMediaPlayer wmpSoundTrack;

        // phát nhạc chọn đúng, chọn sai,...
        private SoundPlayer sp;

        // lấy các giá trị: level, chức vụ, kích thước bảng,mức độ chơi, thời gian chơi, tắt nhạc hay không, hiển thị chức vụ truyền vào hay không: 1=có; 2=không
        public ChooseNumber(int level, string position, int size, int kind, int time, bool turnOffSound, int determine)
        {
            InitializeComponent();
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            sizeTable = size;
            KindOfGame = kind;
            TimeOfGame = time;

            if (turnOffSound == false)
            {
                wmpSoundTrack = new WindowsMediaPlayer();
                try
                {
                    wmpSoundTrack.URL = @"sound/ChseNum/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }
            number = 0;
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
                sp = new SoundPlayer(@link);
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

        // tạo ra các số có tổng bằng số cần tìm
        private void createOriginalArray()
        {
            if (KindOfGame == 1) value = randomNumber(2, 3);
            else if (KindOfGame == 2) value = randomNumber(4, 6);
            else if (KindOfGame == 3) value = randomNumber(7, 9);

            numberToFind = value * 50;      
            original[value] = numberToFind;

            for (int i = 1; i < value; i++)
            {
                original[i] = randomNumber(1, 50);
                original[value] -= original[i];
            }
            for (int i = value + 1; i <= sizeTable * sizeTable; i++) original[i] = randomNumber(1, 50);
        }

        // tạo ngẫu nhiên các button, các số hiển thị trên Text lấy từ mảng original[]
        private void createButtonArray(int number)
        {
            if (number == 1)
            {
                for (int i = 1; i <= 10; i++) randomBtn[i] = new Button[20];
                for (int i = 1; i <= sizeTable; i++)
                    for (int j = 1; j <= sizeTable; j++)
                    {
                        randomBtn[i][j] = new Button();
                        randomBtn[i][j].Size = new Size(55, 55);

                        value = (i - 1) * sizeTable + j;

                        location = randomNumber(1, sizeTable * sizeTable - value + 1);
                        randomBtn[i][j].Text = original[location].ToString();
                        original[location] = original[sizeTable * sizeTable - value + 1];

                        randomBtn[i][j].Location = new Point((i - 1) * 60 + getLocation(55, sizeTable, true), (j - 1) * 60 + getLocation(55, sizeTable, false));
                        randomBtn[i][j].BackColor = Color.FromArgb(246, 71, 71);
                        randomBtn[i][j].FlatStyle = FlatStyle.Flat;
                        randomBtn[i][j].ForeColor = Color.White;
                        randomBtn[i][j].Click += btnMediate_Click;
                        Controls.Add(randomBtn[i][j]);
                        randomBtn[i][j].Enabled = true;

                        pnlGameDisplayGray.Controls.Add(randomBtn[i][j]);
                    }
            }
            else
            {
                for (int i = 1; i <= sizeTable; i++)
                    for (int j = 1; j <= sizeTable; j++)
                    {
                        value = (i - 1) * sizeTable + j;

                        location = randomNumber(1, sizeTable * sizeTable - value + 1);
                        randomBtn[i][j].Text = original[location].ToString();
                        original[location] = original[sizeTable * sizeTable - value + 1];
                       
                        randomBtn[i][j].Enabled = true;
                        randomBtn[i][j].Visible = true;

                    }
            }
        }

        // bắt đầu chơi game
        private void btnStart_Click(object sender, EventArgs e)
        {
            minute = TimeOfGame / 60;
            second = TimeOfGame % 60;
            yourSum = 0;
            createOriginalArray();
            number++;
            createButtonArray(number);
            btnStart.Text = "Chơi lại";
            tmrTimeToPlay.Enabled = true;
        }

        // bắt đầu đếm ngược thời gian
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYourSum.Text = yourSum.ToString();
            txtNum.Text = numberToFind.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ((minute > 0 || second > 0) && yourSum<numberToFind)
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
            playMusic("sound/ChseNum/click.wav");
            Button btnMedia = (Button)sender;
            yourSum += Int16.Parse(btnMedia.Text);
            btnMedia.Visible = false;
        }

        public delegate void truyen(int value);
        public truyen trans;

        // trả về kết quả
        private void answer()
        {
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++) randomBtn[i][j].Enabled = false;

            if (yourSum == numberToFind) trans.Invoke(1);      
            else trans.Invoke(0);
        }

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // tắt nhạc khi đóng chương trình
        private void ChooseNumber_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                sp.Stop();
            }
            catch (Exception ex) { }
            tmrTimeToPlay.Stop();
            wmpSoundTrack.close();
        }
    }
}
