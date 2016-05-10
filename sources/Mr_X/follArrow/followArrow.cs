using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using WMPLib;

namespace follArrow
{
    public partial class followArrow : Form
    {

        // điểm qua vòng
        private int scoreToPass;

        // thời gian chơi, tính bằng phút
        private int minute;

        //thời gian chơi, tính bằng giây
        private int second;

        // số điểm của người chơi
        private int yourScore;

        // thời gian chơi
        private int timeOfGame;

        // phát nhạc nền
        private WindowsMediaPlayer wmpSoundTrack;

        // phát nhạc chọn đúng, chọn sai,...
        private SoundPlayer sp;

        // tạo button mũi tên
        private circleButton btnCircle;


        // nhận giá trị từ 1 tới 4, là một trong bốn chiều của mũi tên
        private int type;

        // nhận giá trị từ 1 tới 2, tương ứng là mũi tên màu xanh hay đỏ
        private int id;

        // tạo button tròn
        class circleButton : System.Windows.Forms.Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(0, 0, ClientSize.Height, ClientSize.Width);
                this.Region = new Region(gp);
                base.OnPaint(pevent);
            }
        }

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
                sp = new SoundPlayer(@link);
                sp.Play();
            }
            catch (Exception ex) { }
        }

        // load ảnh theo đường dẫn là link vào btn
        private void loadPicture(circleButton btn, string link)
        {
            try
            {
                btn.Image = Image.FromFile(@link);
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

        // load ảnh có đường dẫn là link vào pic
        private void loadPictureToPic(PictureBox pic, string link)
        {
            try
            {
                pic.Image = null;
                pic.Image = Image.FromFile(@link);
            }
            catch (Exception ex) { }
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // lấy các giá trị: level, chức vụ, điểm qua vòng, thời gian chơi, bật hay tắt nhạc, có hiển thị chức vụ hay không
        public followArrow(int level, string position, int score, int time, bool turnOffSound, int determine)
        {
            InitializeComponent();

            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            scoreToPass = score;

            timeOfGame = time;

            if (turnOffSound == false)
            {
                wmpSoundTrack = new WindowsMediaPlayer();
                try
                {
                    wmpSoundTrack.URL = @"sound/follArrow/soundTrack.mp3";
                    wmpSoundTrack.controls.play();
                }
                catch (Exception ex) { }
            }
            
            btnCircle = new circleButton();

            btnCircle.Size = new Size(75, 75);
            btnCircle.Location = new Point(350, 350);

            btnCircle.FlatAppearance.BorderSize = 0;
            btnCircle.FlatStyle = FlatStyle.Flat;

            Controls.Add(btnCircle);
            pnlGameDisplayGray.Controls.Add(btnCircle);

            loadPictureToPic(picDance, "picture/follArrow/center.gif");
        }  

        // tạo button tròn có hình ảnh mũi tên
        private void createCircleButton()
        {  
            type = randomNumber(1, 4);
            id = randomNumber(1, 2);
            if (type == 1)
            {
                if (id == 1) loadPicture(btnCircle, "picture/follArrow/blueLeft.jpg");
                else loadPicture(btnCircle, "picture/follArrow/blueRight.jpg");
            }
            else if (type == 2){
                if (id == 1) loadPicture(btnCircle, "picture/follArrow/redLeft.jpg");
                else loadPicture(btnCircle, "picture/follArrow/redRight.jpg");
            }
            else if (type == 3)
            {
                if (id == 1) loadPicture(btnCircle, "picture/follArrow/blueUp.jpg");
                else loadPicture(btnCircle, "picture/follArrow/blueDown.jpg");
            }
            else
            {
                if (id == 1) loadPicture(btnCircle, "picture/follArrow/redUp.jpg");
                else loadPicture(btnCircle, "picture/follArrow/redDown.jpg");
            }
        }
        // xử lí khi người chơi ấn mũi tên trên bàn phím
        private void followArrow_KeyUp(object sender, KeyEventArgs e)
        {
            if (tmrTimeToPlay.Enabled == true)
            {
                picTalk.Visible = true;
                if (e.KeyCode == Keys.Up)
                {
                    if ((type == 3 && id == 1) || (type == 4 && id == 2))
                    {
                        yourScore++;
                        loadPictureToPic(picTalk, "picture/follArrow/happy.gif");
                        loadPictureToPic(picDance, "picture/follArrow/left.gif");
                        playMusic("sound/follArrow/happy.wav");
                    }
                    else 
                    {
                        loadPictureToPic(picTalk, "picture/follArrow/sad.gif");
                        loadPictureToPic(picDance, "picture/follArrow/center.gif");
                        playMusic("sound/follArrow/sad.wav");
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if ((type == 3 && id == 2) || (type == 4 && id == 1))
                    {
                        yourScore++;
                        loadPictureToPic(picTalk, "picture/follArrow/happy.gif");
                        loadPictureToPic(picDance, "picture/follArrow/right.gif");
                        playMusic("sound/follArrow/happy.wav");
                    }
                    else
                    {
                        loadPictureToPic(picTalk, "picture/follArrow/sad.gif");
                        loadPictureToPic(picDance, "picture/follArrow/center.gif");
                        playMusic("sound/follArrow/sad.wav");
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if ((type == 1 && id == 1) || (type == 2 && id == 2))
                    {
                        yourScore++;
                        loadPictureToPic(picTalk, "picture/follArrow/happy.gif");
                        loadPictureToPic(picDance, "picture/follArrow/left.gif");
                        playMusic("sound/follArrow/happy.wav");
                    }
                    else
                    {
                        loadPictureToPic(picTalk, "picture/follArrow/sad.gif");
                        loadPictureToPic(picDance, "picture/follArrow/center.gif");
                        playMusic("sound/follArrow/sad.wav");
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if ((type == 1 && id == 2) || (type == 2 && id == 1))
                    {
                        yourScore++;
                        loadPictureToPic(picTalk, "picture/follArrow/happy.gif");
                        loadPictureToPic(picDance, "picture/follArrow/right.gif");
                        playMusic("sound/follArrow/happy.wav");
                    }
                    else
                    {
                        loadPictureToPic(picTalk, "picture/follArrow/sad.gif");
                        loadPictureToPic(picDance, "picture/follArrow/center.gif");
                        playMusic("sound/follArrow/sad.wav");
                    }
                }
                else
                {
                    loadPictureToPic(picTalk, "picture/follArrow/sad.gif");
                    loadPictureToPic(picDance, "picture/follArrow/center.gif");
                    playMusic("sound/follArrow/sad.wav");
                }
                createCircleButton();
            }
        }

        // bắt đầu chơi game
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Chơi lại";
            yourScore = 0;
            tmrTimeToPlay.Enabled = true;
            minute = timeOfGame / 60;
            second = timeOfGame % 60;
            loadPictureToPic(picDance, "picture/follArrow/center.gif");
            picTalk.Visible = false;
            createCircleButton();
        }

        // bắt đầu đếm ngược thời gian
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYourScore.Text = yourScore.ToString();
            txtScoreToPass.Text = scoreToPass.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ((minute > 0 || second > 0) && yourScore < scoreToPass)
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

        // trả về kết quả
        private void answer()
        {
            loadPictureToPic(picDance, "picture/follArrow/center.gif");
            picTalk.Visible = false;
            if (yourScore >= scoreToPass)trans.Invoke(1);        
            else trans.Invoke(0);
        }

        // tắt nhạc khi đóng form
        private void followArrow_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                sp.Stop();
            }
            catch (Exception ex) { }
            tmrTimeToPlay.Stop();
            wmpSoundTrack.close();
        }

        // thoát game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
