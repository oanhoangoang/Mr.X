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

        // thời gian chơi
        private int timeOfGame;

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

        // số lượt chọn
        private int numChoice;

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

        // check[i][j]=true->có thể ấn vào button[i][j], ngược lại không
        private bool[] check=new bool[1000];

        // số lần chơi game
        private int number = 0;

        // phát nhạc nền
        private WindowsMediaPlayer wmpSoundTrack;

        // phát nhạc chọn đúng, chọn sai,...
        private SoundPlayer sp;

        // lấy các giá trị:level, chức vụ, chiều cao của bảng, chiều rộng của bảng, số điểm qua vòng,số lượt nhấn, thời gian chơi, có tắt nhạc hay không, hiển thị chức vụ truyền vào hay không: 1=có; 2=không
        public FindSameCell(int level, string position, int height, int width, int Score, int numCho, int time, bool turnOffSound, int determine)
        {
            InitializeComponent();
            lblLevelOfGame.Text += level.ToString();
            lblPosition.Text += position.ToString();
            if (determine == 2) lblPosition.Visible = false;
            heightTable = height;
            widthTable = width;
            if (heightTable % 2 == 1 && widthTable % 2 == 1) heightTable--;
            sizeTable = height * width;
            scoreToPass = Score;
            numChoice = numCho;
            timeOfGame = time;
            if (turnOffSound == false)
            {
                wmpSoundTrack = new WindowsMediaPlayer();
                try
                {
                    wmpSoundTrack.URL = @"sound/FndSaCell/soundTrack.mp3";
                }
                catch (Exception ex) { }
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

        // xác định vị trí hiển trị cho các button
        private int getLocation(int size, int num, bool check)
        {
            if (check == true) return (809 - size * num)/2;
            else return (654 - size * num)/2;
        }

        //tạo mảng button tròn
        private void createCircleButtonArray(int number)
        {
            if (number == 1)
            {
                for (int i = 1; i <= sizeTable / 2; i++) numberOfIcon[i] = 2;
                for (var i = 1; i <= sizeTable; i++) btnCircle[i] = new circleButton[30];

                for (int i = 1; i <= heightTable; i++)
                    for (int j = 1; j <= widthTable; j++)
                    {
                        value = (i - 1) * widthTable + j;
                        btnCircle[i][j] = new circleButton();

                        btnCircle[i][j].Size = new Size(63, 63);
                        btnCircle[i][j].Location = new Point((i - 1) * 68 + getLocation(63, heightTable, true), (j - 1) * 68 + getLocation(63, widthTable, false));

                        btnCircle[i][j].Name = value.ToString();
                        btnCircle[i][j].FlatAppearance.BorderSize = 0;
                        btnCircle[i][j].FlatStyle = FlatStyle.Flat;
                        btnCircle[i][j].BackColor = ColorTranslator.FromHtml("#87D37C");

                        btnCircle[i][j].Click += new EventHandler(btnMediate_Click);
                        Controls.Add(btnCircle[i][j]);
                        pnlGameDisplayGray.Controls.Add(btnCircle[i][j]);

                        location = randomNumber(1, sizeTable / 2);
                        while (numberOfIcon[location] == 0 && location < sizeTable / 2) location++;
                        while (numberOfIcon[location] == 0 && location > 1) location--;
                        numberOfIcon[location]--;

                        original[value] = "picture/FndSaCell/" + location.ToString() + ".png";
                    }
            }
            else
            {
                for (int i = 1; i <= sizeTable / 2; i++) numberOfIcon[i] = 2;

                for (int i = 1; i <= heightTable; i++)
                    for (int j = 1; j <= widthTable; j++)
                    {
                        btnCircle[i][j].Image = null;
                        btnCircle[i][j].Visible = true;
                        value = (i - 1) * widthTable + j;
                        btnCircle[i][j].Name = value.ToString();
                        
                        location = randomNumber(1, sizeTable / 2);
                        while (numberOfIcon[location] == 0 && location < sizeTable / 2) location++;
                        while (numberOfIcon[location] == 0 && location > 1) location--;
                        numberOfIcon[location]--;

                        original[value] = "picture/FndSaCell/" + location.ToString() + ".png";
                    }
            }
        }

        // bắt đầu trò chơi
        private void btnStart_Click(object sender, EventArgs e)
        {
            number++;
            minute = timeOfGame / 60;
            second = timeOfGame % 60;
            createCircleButtonArray(number);
            yourScore = 0;
            previousButton = 0;
            numberOfClick = 0;
            numberOfChoice = numChoice;
            tmrTimeToPlay.Enabled = true;
            btnStart.Text = "Chơi lại";
            for (int i = 1; i <= 100; i++) check[i] = true;
        }

        // đếm ngược thời gian chơi
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtYourScore.Text = yourScore.ToString();
            txtScoreToPass.Text = scoreToPass.ToString();
            txtOpportunity.Text = numberOfChoice.ToString();
            nudMinute.Value = minute;
            nudSecond.Value = second;

            if (minute > 0 || second > 0 && numberOfChoice > 0 && yourScore<scoreToPass)
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

            if (check[Int32.Parse(btnMedia.Name)] == true) check[Int32.Parse(btnMedia.Name)] = false;
            else return;

            loadPicture(btnMedia,original[Int32.Parse(btnMedia.Name)]);

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
                    check[Int32.Parse(btnMedia.Name)] = true;
                    for (int i = 1; i <= heightTable; i++)
                        for (int j = 1; j <= widthTable; j++)
                            if (Int32.Parse(btnCircle[i][j].Name) == previousButton)
                            {
                                btnCircle[i][j].Image = null;
                                check[ Int32.Parse(btnCircle[i][j].Name) ]=true;
                                break;
                            }
                }
            }
            else
            {
                previousButton = Int32.Parse(btnMedia.Name);
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
                    loadPicture(btnCircle[i][j],original[Int32.Parse(btnCircle[i][j].Name)]);
                    check[ Int16.Parse(btnCircle[i][j].Name) ] = false;
                }

            if (yourScore >= scoreToPass)
            {
                trans.Invoke(1);
                this.Close();
            }
            else trans.Invoke(0);
        }

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

        // tắt nhạc khi đóng chương trình
        private void FindSameCell_FormClosed(object sender, FormClosedEventArgs e)
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
