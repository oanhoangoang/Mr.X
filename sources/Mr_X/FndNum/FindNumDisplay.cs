﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

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
        private int timeOfGame;

        // phát nhạc nền
        private WindowsMediaPlayer wmpSoundTrack;

        // phát nhạc chọn đúng, chọn sai,...
        private SoundPlayer sp;

        // số lần chơi game của người chơi
        private int number;

        // lấy các giá trị: level, chức vụ, kích thước bảng, số lượng số cần tìm, thời gian chơi, tắt nhạc hay không, hiển thị chức vụ truyền vào hay không: 1=có; 2=không
        public FindNumDisplay(int level, string position, int size, int num, int time, bool turnOnSound, int determine)
        {
            InitializeComponent();
            sizeTable = size;
            numberToFind = num;
            timeOfGame = time;
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            if (turnOnSound)
            {
                wmpSoundTrack = new WindowsMediaPlayer();
                try
                {
                    wmpSoundTrack.URL = @"sound/FndNum/soundtrack.mp3";
                }
                catch (Exception ex){}
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

        // tạo mảng button: kích thước, vị trí, giá trị hiển thị, màu nền, màu chữ, xử lí khi nhấn vào
        private void createButtonArray(int number)
        {
            if (number == 1)
            {
                for (var i = 1; i <= sizeTable * sizeTable; i++) originalArray[i] = i;
                for (var i = 1; i <= sizeTable; i++) randomBtn[i] = new Button[40];
                now = 1;
                for (var i = 1; i <= sizeTable; i++)
                    for (var j = 1; j <= sizeTable; j++)
                    {
                        randomBtn[i][j] = new Button();
                        randomBtn[i][j].Size = new Size(55, 55);

                        locationRandom = randomNumber(1, sizeTable * sizeTable - now + 1);
                        randomBtn[i][j].Text = originalArray[locationRandom].ToString();
                        originalArray[locationRandom] = originalArray[sizeTable * sizeTable - now + 1];
                        now++;

                        randomBtn[i][j].Location = new Point((i - 2) * 70 + getLocation(55, sizeTable, true), (j - 1) * 65 + getLocation(55, sizeTable, false));
                        randomBtn[i][j].BackColor = Color.FromArgb(154, 18, 179);
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
                for (var i = 1; i <= sizeTable * sizeTable; i++) originalArray[i] = i;
                now = 1;
                for (var i = 1; i <= sizeTable; i++)
                    for (var j = 1; j <= sizeTable; j++)
                    {
                        locationRandom = randomNumber(1, sizeTable * sizeTable - now + 1);
                        randomBtn[i][j].Text = originalArray[locationRandom].ToString();
                        originalArray[locationRandom] = originalArray[sizeTable * sizeTable - now + 1];
                        now++;
                        randomBtn[i][j].Enabled = true;
                        randomBtn[i][j].Visible = true;
                    }
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
            number = 0;
        }

        // bắt đầu trò chơi
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlGameDisplayGray.Visible = true;
            lblNotice.Visible = false;
            number++;
            createButtonArray(number);
            createRandomArray();
            yourScore = 0;
            minute = timeOfGame / 60;
            second = timeOfGame % 60;
            txtFindNum.Text = "";
            txtScoreToPass.Text = "";
            txtYourScore.Text = "";
            now = 1;
            btnStart.Text = "Chơi lại";
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
            if ((minute > 0 || second > 0) && now <= sizeTable * sizeTable && yourScore<numberToFind)
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

                playMusic("sound/FndNum/happy.wav");
            }
            else
            {
                playMusic("sound/FndNum/sad.wav");
            }
            now++;
        }

        public delegate void truyen(int value);
        public truyen trans;

        int answerToTeturn = 0;

        // trả về kết quả của người chơi
        private void answer(){
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++) randomBtn[i][j].Enabled= false;

            pnlGameDisplayGray.Visible = false;
            lblNotice.Visible = true;
            if (yourScore >= numberToFind){
                answerToTeturn = 1;
                lblNotice.Text = "Chúc mừng bạn đã vượt qua thử thách này";
            }
            else
            {
                lblNotice.Text = "Rất tiếc bạn đã không vượt qua thử thách này";
            }
        }

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // tắt nhạc khi đóng chương trình
        private void FindNumDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                sp.Stop();
            }
            catch (Exception ex) { }
            tmrTimeToPlay.Stop();
            try
            {
                wmpSoundTrack.close();
            }
            catch (Exception ex) { }
            trans.Invoke(answerToTeturn);
        }
    }
}
