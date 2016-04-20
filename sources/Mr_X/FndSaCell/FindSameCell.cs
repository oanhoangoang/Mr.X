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

namespace FndSaCell
{
    public partial class FindSameCell : Form
    {
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

        // tạo mảng button hiển thị các con vật
        private circleButton[][] btnCircle = new circleButton[100][];

        //số phút chơi
        private int minute;

        // số giây chơi
        private int second;

        // chiều cao của bảng
        private int heightTable;

        // chiều rộng của bảng
        private int widthTable;

        // diện tích của bảng
        private int sizeTable;

        // điểm qua vòng
        private int scoreToPass;

        // số lượng lượt chọn
        private int numberOfChoice;

        // điểm người chơi
        private int yourScore;

        // tên của button
        private int value;

        // numberOfIcon[i]= số lượng icon thứ i còn có thể sử dụng, mặc định được khởi tạo bằng 2
        private int[] numberOfIcon = new int[1000 + 10];

        // lấy ngẫu nhiên vị trí của một icon mà icon đó xuất hiện chưa xuất hiện đủ 2 lần
        private int location;

        // original[i]= đường dẫn tới icon của button tên i
        private string[] original = new String[100 + 10];

        // tính số lần nhấn của người chơi
        private int numberOfClick;

        // lưu tên của button đã nhấn liền trước đó
        private int previousButton;

        // lấy các giá trị:level, chức vụ, chiều cao của bảng, chiều rộng của bảng, số điểm qua vòng,số lượt nhấn, thời gian chơi, có tắt nhạc hay không
        public FindSameCell(int level, string position, int height, int width, int Score, int numChoice, int time, bool turnOffSound)
        {
            InitializeComponent();
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            heightTable = height;
            widthTable = width;
            if (heightTable % 2 == 1 && widthTable % 2 == 1) heightTable--;
            sizeTable = height * width;
            scoreToPass = Score;
            numberOfChoice = numChoice;
            minute = time / 60;
            second = time % 60;
            if (turnOffSound == false)
            {
                try
                {
                    wmpSoundTrack.URL = @"sound/FndSaCell/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }
        }

        // lấy ngẫu nhiên một số trong khoảng từ limitLow tới limitHigh
        private int randomNumber(int limitLow, int limitHigh)
        {
            Random rd = new Random();
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

        //tạo mảng button tròn
        private void createCircleButtonArray()
        {
            for (int i = 1; i <= sizeTable / 2; i++) numberOfIcon[i] = 2;
            for (var i = 1; i <= sizeTable; i++) btnCircle[i] = new circleButton[30];

            for (int i = 1; i <= heightTable; i++)
                for (int j = 1; j <= widthTable; j++)
                {
                    value = (i - 1) * widthTable + j;
                    btnCircle[i][j] = new circleButton();

                    btnCircle[i][j].Size = new Size(63, 63);
                    btnCircle[i][j].Location = new Point(i * 70 + 20, j * 70 + 20);

                    btnCircle[i][j].Name = value.ToString();
                    btnCircle[i][j].FlatAppearance.BorderSize = 0;
                    btnCircle[i][j].FlatStyle = FlatStyle.Flat;
                    btnCircle[i][j].BackColor = ColorTranslator.FromHtml("#87D37C");

                    btnCircle[i][j].Click += new EventHandler(btnMediate_Click);
                    Controls.Add(btnCircle[i][j]);
                    pnlGameDisplayGray.Controls.Add(btnCircle[i][j]);

                    location = randomNumber(1, sizeTable / 2 );
                    while (numberOfIcon[location] == 0 && location < sizeTable/2) location++;
                    while (numberOfIcon[location] == 0 && location > 1) location--;
                    numberOfIcon[location]--;

                    original[value] = "picture/FndSaCell/" + location.ToString() + ".png";
                }
        }

        // bắt đầu trò chơi
        private void btnStart_Click(object sender, EventArgs e)
        {
            createCircleButtonArray();
            yourScore = 0;
            previousButton = 0;
            numberOfClick = 0;
            tmrTimeToPlay.Enabled = true;
            btnStart.Enabled = false;
        }

        // đếm ngược thời gian chơi
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYourScore.Text = yourScore.ToString();
            txtScoreToPass.Text = scoreToPass.ToString();
            txtOpportunity.Text = numberOfChoice.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;

            if (minute > 0 || second > 0 && numberOfChoice > 0)
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
            numberOfClick++;
            numberOfChoice--;
            circleButton btnMedia = (circleButton)sender;
            try
            {
                btnMedia.Image = Image.FromFile(@original[Int32.Parse(btnMedia.Name)]);
            }
            catch (Exception ex) { }

            var t = Task.Run(async delegate
            {
                await Task.Delay(300);
            });
            t.Wait();

            if (numberOfClick % 2 == 0)
            {
                if (original[Int32.Parse(btnMedia.Name)] == original[previousButton])
                {
                    yourScore += 2;
                    playMusic("sound/FndSaCell/happy.wav");
                    btnMedia.Visible = false;
                    for (int i = 1; i <= heightTable; i++)
                        for (int j = 1; j <= widthTable; j++)
                            if (Int32.Parse(btnCircle[i][j].Name) == previousButton)
                            {
                                btnCircle[i][j].Visible = false;
                                break;
                            }
                }
                else
                {
                    playMusic("sound/FndSaCell/sad.wav");
                    btnMedia.Image = null;
                    for (int i = 1; i <= heightTable; i++)
                        for (int j = 1; j <= widthTable; j++)
                            if (Int32.Parse(btnCircle[i][j].Name) == previousButton)
                            {
                                btnCircle[i][j].Image = null;
                                btnCircle[i][j].Click += new EventHandler(btnMediate_Click);
                                break;
                            }

                }
            }
            else
            {
                previousButton = Int32.Parse(btnMedia.Name);
                btnMedia.Click -= new EventHandler(btnMediate_Click);
                playMusic("sound/FndSaCell/openButton.wav");
            }
        }

        public delegate void truyen(int value);
        public truyen trans;

        // trả về kết quả của người chơi
        private void answer()
        {
            for (int i = 1; i <= heightTable; i++)
                for (int j = 1; j <= widthTable; j++)
                {
                    btnCircle[i][j].Image = Image.FromFile(@original[Int32.Parse(btnCircle[i][j].Name)]);
                    btnCircle[i][j].Click -= new EventHandler(btnMediate_Click);
                }

            if (yourScore >= scoreToPass)
            {
                trans.Invoke(1);
                try
                {
                    picVictory.Visible = true;
                    picVictory.Image = Image.FromFile(@"picture/FndSaCell/victory.jpg");
                    picVictory.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) { }

                try
                {
                    wmpSoundTrack.URL = @"sound/FndSaCell/victory.mp3";
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

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

        // tắt nhạc khi đóng chương trình
        private void FindSameCell_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrTimeToPlay.Stop();
            wmpSoundTrack.close();
        }
    }
}
