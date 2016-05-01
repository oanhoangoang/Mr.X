﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace FndDiCell
{
    public partial class FindDifferentCell : Form
    {
        // kích thước bảng
        private int sizeTable;

        // thể loại của game: khác màu, khác kích thước, khác nội dung
        private int typeOfGame;

        // điểm qua vòng
        private int scoreToPass;

        // mức độ game: dễ, trung bình, khó
        private int kindOfgame;

        // điểm người chơi
        private int yourScore;

        // thời gian chơi, tính bằng phút
        private int minute;

        // thời gian chơi, tính bằng giây
        private int second;

        // ô khác biệt, random từ 1 tới n*n
        private int pos;

        // Red của các ô button
        private int xDimension;

        // Green của các ô button
        private int yDimension;

        // Blue của các ô button
        private int zDimension;

        // độ chênh lệch màu sắc, kích thước của button khác biệt với các button còn lại
        private int Different;

        // độ dài của xâu hiển thị trên button
        private int lenOfContent;

        // nội dung hiển thị trên các button giống nhau
        private string content;

        // nội dung hiển thị trên button khác biệt
        private string DiffContent;

        // mảng button để người chơi chọn
        private readonly Button[][] randomBtn = new Button[50][];

        // lấy các giá trị: level, chức vụ, kích thước bảng, thể loại chơi, mức độ chơi, điểm qua vòng, thời gian chơi, tắt nhạc hay không
        public FindDifferentCell(int level, string position, int size, int type, int kind, int score, int time, bool turnOffSound, int determine)
        {
            InitializeComponent();
            sizeTable = size;
            typeOfGame = type;
            kindOfgame = kind;
            scoreToPass = score;
            minute = time / 60;
            second = time % 60;
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            if (turnOffSound == false)
            {
                try
                {
                wmpSoundTrack.URL = @"sound/FndDiCell/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }
            for (var i = 1; i <= sizeTable; i++) randomBtn[i] = new Button[40];
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++)
                {
                    randomBtn[i][j] = new Button();
                    randomBtn[i][j].Size = new Size(70, 70);
                    randomBtn[i][j].Name=( (i-1)*sizeTable+j ).ToString();
                    randomBtn[i][j].Location = new Point( (i-1) * 90+50, (j-1) * 90+80);
                    randomBtn[i][j].FlatStyle = FlatStyle.Flat;
            
                    randomBtn[i][j].Click += btnMediate_Click;
                    Controls.Add(randomBtn[i][j]);
                    randomBtn[i][j].Visible = false;

                    pnlGameDisplayGray.Controls.Add(randomBtn[i][j]);
                }
        }

        // khởi tạo các giá trị ban đầu cho các button
        private void initArrayButton(){
            for(int i=1; i<=sizeTable; i++)
                for(int j=1; j<=sizeTable; j++)
                {
                    randomBtn[i][j].Size = new Size(70, 70);
                    randomBtn[i][j].Text = "";
                    randomBtn[i][j].BackColor = Color.FromArgb(249, 105, 14);
                }
        }

        // lấy ngẫu nhiên 1 số từ limitLow tới limitHigh
        Random rd = new Random();
        private int randomNumber(int limitLow, int limitHigh)
        {
             return rd.Next(limitLow, limitHigh + 1);
        }

        // làm thời gian chậm lại x milisecond
        private void timeDelay(int x)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(x);
            });
            t.Wait();
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

        // tạo lượt chơi mới
        private void newRound()
        {
            picTalk.Image = Image.FromFile(@"picture/FndDiCell/normal.jpg");
            picTalk.SizeMode = PictureBoxSizeMode.StretchImage;

            initArrayButton();
            for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++)
                {
                    randomBtn[i][j].Visible = true;
                    randomBtn[i][j].Enabled = true;
                }
            
            pos = randomNumber(1, sizeTable * sizeTable);
            if (typeOfGame==1){
                xDimension = randomNumber(1, 200);
                yDimension = randomNumber(1, 200);
                zDimension = randomNumber(1, 200);
                for (int i = 1; i <= sizeTable; i++)
                for (int j = 1; j <= sizeTable; j++ )
                    if ((i - 1) * sizeTable + j != pos) randomBtn[i][j].BackColor = Color.FromArgb(xDimension,yDimension,zDimension);
                    else
                    {
                        Different = randomNumber(1, 3);
                        if (Different == 1)
                        {
                            if (kindOfgame == 1) Different = randomNumber(15, 20);
                            else if (kindOfgame == 2) Different = randomNumber(10, 15);
                            else Different = randomNumber(5, 7);

                            randomBtn[i][j].BackColor = Color.FromArgb(xDimension + Different, yDimension, zDimension);
                        }
                        else if (Different == 2)
                        {
                            if (kindOfgame == 1) Different = randomNumber(15, 20);
                            else if (kindOfgame == 2) Different = randomNumber(10, 15);
                            else Different = randomNumber(5, 7);

                            randomBtn[i][j].BackColor = Color.FromArgb(xDimension, yDimension + Different, zDimension);
                        }
                        else
                        {
                            if (kindOfgame == 1) Different = randomNumber(15, 20);
                            else if (kindOfgame == 2) Different = randomNumber(10, 15);
                            else Different = randomNumber(5, 7);

                            randomBtn[i][j].BackColor = Color.FromArgb(xDimension, yDimension, zDimension + Different);
                        }
                    }
            }
            else if (typeOfGame == 2)
            {

                if (kindOfgame == 1) Different = randomNumber(8, 13);
                else if (kindOfgame == 2) Different = randomNumber(4, 8);
                else Different = randomNumber(2, 4);

                for (int i = 1; i <= sizeTable; i++)
                    for (int j = 1; j <= sizeTable; j++ )
                        if ((i - 1) * sizeTable + j == pos) randomBtn[i][j].Size = new Size(70+Different,70+Different); 
            }
            else
            {
                content = "";
                DiffContent = "";
                if (kindOfgame == 1) lenOfContent = randomNumber(1, 4);
                else if (kindOfgame == 2) lenOfContent = randomNumber(4, 7);
                else lenOfContent = randomNumber(7, 9);

                for (int i = 1; i <= lenOfContent; i++) content+=(char)(randomNumber(65, 90));
                Different = randomNumber(0, lenOfContent - 1);
                
                for (int i = 0; i < lenOfContent; i++)
                if (i == Different)
                {
                    if (content[i] == 'A') DiffContent += (char)90;
                    else DiffContent += (char)65;
                }
                else DiffContent += content[i];
     
                for (int i = 1; i <= sizeTable; i++)
                    for (int j = 1; j <= sizeTable; j++)
                        if (pos == (i - 1) * sizeTable + j) randomBtn[i][j].Text = content;  
                        else randomBtn[i][j].Text = DiffContent;
            }
        }

        // bắt đầu chơi game
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            tmrTimeToPlay.Enabled = true;
            newRound();
        }

        // xử lí khi người chơi nhấn button
        private void btnMediate_Click(object sender, EventArgs e)
        {
            Button btnMedia = (Button)sender;

            if (Int16.Parse(btnMedia.Name) == pos)
            {
                btnMedia.Visible = false;
                yourScore++;
                playMusic("sound/FndDiCell/happy.wav");

                picTalk.Image = Image.FromFile(@"picture/FndDiCell/happy.jpg");
                picTalk.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                picTalk.Image = Image.FromFile(@"picture/FndDiCell/sad.jpg");
                picTalk.SizeMode = PictureBoxSizeMode.StretchImage;
                playMusic("sound/FndDiCell/sad.wav");
            }
 
            timeDelay(1000);
            initArrayButton();
            newRound();
        }

        // đếm ngược thời gian
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYourScore.Text = yourScore.ToString();
            txtScoreToPass.Text = scoreToPass.ToString();
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
                for (int j = 1; j <= sizeTable; j++) randomBtn[i][j].Enabled = false;

            if (yourScore >= scoreToPass)
            {
                trans.Invoke(1);
                try
                {
                    picVictory.Visible = true;
                    picVictory.Image = Image.FromFile(@"picture/FndDiCell/victory.jpg");
                    picVictory.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) { }

                try
                {
                    wmpSoundTrack.URL = @"sound/FndDiCell/victory.mp3";
                }
                catch (Exception ex) { }

                MessageBox.Show("Chúc mừng bạn đã vượt qua thử thách này", "Thông báo");
            }
            else
            {
                trans.Invoke(0);
                MessageBox.Show("Rất tiếc bạn đã không vượt qua thử thách này. Chúc may mắn", "Thông báo");
            }
        }

        // tắt nhạc khi đóng chương trình
        private void FindDifferentCell_FormClosed(object sender, FormClosedEventArgs e)
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