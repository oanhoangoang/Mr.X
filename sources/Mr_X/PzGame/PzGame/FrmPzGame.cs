using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace PzGame
{

    public partial class FrmPzGame : Form
    {
        Random r = new Random();

        private bool ok;
        private int level;
        private string chucVu;
        private bool msic;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        
        public void enableSound()
        {
            player.URL = @"sound/PzGame/music.mp3";
            player.controls.play();
            
           // TimeSpan duration = player.TotalTime;
        }

        public delegate void truyen(int value);
        public truyen trans;
        public FrmPzGame(bool enableMusic,int level_ , string chucVu_ )
        {
            InitializeComponent();
            msic = enableMusic;
            level = level_;
            chucVu = chucVu_;
        }
        private int x, y;
        private int[] Arr = new int[15];


        private void init()
        {
            x = 4;
            y = 3;
            for (int i = 1; i <= 12; i++) Arr[i] = i; // init mang
        }
        private int getPosition(int x, int y)
        {
            return ((x - 1) * 3 + y);
        }
        private void getPic(PictureBox pic, int a)
        {
            switch (a)
            {
                case 1: pic.Image = PzGame.Properties.Resources.pic1; break;
                case 2: pic.Image = PzGame.Properties.Resources.pic2; break;
                case 3: pic.Image = PzGame.Properties.Resources.pic3; break;
                case 4: pic.Image = PzGame.Properties.Resources.pic4; break;
                case 5: pic.Image = PzGame.Properties.Resources.pic5; break;
                case 6: pic.Image = PzGame.Properties.Resources.pic6; break;
                case 7: pic.Image = PzGame.Properties.Resources.pic7; break;
                case 8: pic.Image = PzGame.Properties.Resources.pic8; break;
                case 9: pic.Image = PzGame.Properties.Resources.pic9; break;
                case 10: pic.Image = PzGame.Properties.Resources.pic10; break;
                case 11: pic.Image = PzGame.Properties.Resources.pic11; break;
                case 12: pic.Image = null; pic.BackColor = Color.White; break;

            }
        }
        private void swap(int i, int j)
        {
            int tmp;
            tmp = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = tmp;
        }
        private void turnLeft()
        {
            if (y > 1)
            {
                swap(getPosition(x, y), getPosition(x, y - 1));
                y--;
                showPic();
            }
        }
        private void turnRight()
        {
            if (y < 3)
            {
                swap(getPosition(x, y), getPosition(x, y + 1));
                y++;
                showPic();
            }
        }
        private void goUp()
        {
            if (x > 1)
            {
                swap(getPosition(x, y), getPosition(x - 1, y));
                x--;
                showPic();
            }
        }
        private void goDown()
        {
            if (x < 4)
            {
                swap(getPosition(x, y), getPosition(x + 1, y));
                x++;
                showPic();
            }
        }
        private void showPic()
        {

            getPic(pic1, Arr[1]);
            getPic(pic2, Arr[2]);
            getPic(pic3, Arr[3]);
            getPic(pic4, Arr[4]);
            getPic(pic5, Arr[5]);
            getPic(pic6, Arr[6]);
            getPic(pic7, Arr[7]);
            getPic(pic8, Arr[8]);
            getPic(pic9, Arr[9]);
            getPic(pic10, Arr[10]);
            getPic(pic11, Arr[11]);
            getPic(pic12, Arr[12]);
            // show main pic 
            //picMain

        }
        private int j;
        private void setPzGame() // xao tron cac tam hinh
        {
            
            for (int i = 1; i <= 150; i++)
            {

                int xx = r.Next(1, 5);
                switch (xx)
                {
                    case 1: if (x > 1) { swap(getPosition(x, y), getPosition(x - 1, y)); x--; } break;
                    case 2: if (x < 4) { swap(getPosition(x, y), getPosition(x + 1, y)); x++; } break;
                    case 3: if (y > 1) { swap(getPosition(x, y), getPosition(x, y - 1)); y--; } break;
                    case 4: if (y < 3) { swap(getPosition(x, y), getPosition(x, y + 1)); y++; } break;
                }
            }
            
            for (int i = 1; i <= 12; i++) // cho phep pic12 luon mau trang
                if (Arr[i] == 12)
                {
                    j = i;
                }

            x = j / 3 + 1;
            y = j % 3; if (y == 0) { y = 3; x--; }
            
            while (getPosition(x,y) != 12)
            {
                goDown();
                turnRight();
            }
            ///
          //  showPic();
            x = 4; y = 3;
        }
        private int dem;
        private void FrmPzGame_Load(object sender, EventArgs e)
        {
            if (msic) { enableSound(); tmMusic.Start(); }
            // x = 5; y = 5;
            dem = 0;
            // show anh ra form
            init();
            picMain.Image = PzGame.Properties.Resources.main;
            showPic();
            //////
            ok = false;
            lblLevel.Text = level.ToString();
            lblChucVu.Text = chucVu;
           // label1.Text = player.controls.currentItem.durationString; 

            phut = 5;

        }

        private void pnDisplayGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void picMain_Click(object sender, EventArgs e)
        {

        }
        private bool checkResult()
        {
            for (int i = 1; i <= 12; i++)
                if (Arr[i] != i) return false;
            return true;
        }
        private void hidePic()
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            pic10.Visible = false;
            pic11.Visible = false;
            pic12.Visible = false;
            picMain.Visible = false;
            lblNotiBDau.Visible = false;
            lblNoti.Visible = false;
            btnDone.Visible = false;

            picEndGame.Visible = true;

        }
        private void thongBaoLose()
        {
            MessageBox.Show("Chưa đúng rồi");
            //hidePic();

            
            
        }
        private void thongBaoWin()
        {
            //MessageBox.Show("thang");
            btnStart.Enabled = false;
            hidePic();
            lblWin1.Visible = true;
            lblWin2.Visible = true;
            lblWin1.Text = "";
            lblWin2.Text = "";
            tmWinGame.Start();

        }
        private void thongBaoDoneGame()
        {
            if (ok) thongBaoWin(); else thongBaoLose();
        }
        private int phut;
        private int giay;
        

        private void btnDone_Click(object sender, EventArgs e)
        {

             if (phut!=5)
            {
                ok = checkResult();
            //    btnStart.Enabled = false;
                thongBaoDoneGame();

            }

        }

        private void FrmPzGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            tmMusic.Stop();
            
            player.close();
        }
        private void thongBaoStart()
        {
            lblNoti.Visible = false;
            lblNotiBDau.Visible = true;
            lblNotiBDau.Text = "Nhấn bắt đầu để chơi Game";
        }
        private void thongBaoTrongGame()
        {
            lblNotiBDau.Visible = false;
            lblNoti.Visible = true;
            lblNoti.Text = "Nhấn Xong nếu bạn đã xếp đúng hoặc Chơi Lại để chơi lại Game";
        }
        private void thongBaoChoiLai()
        {
            lblNotiBDau.Visible = false;
            lblNoti.Visible = true;
            lblNoti.Text = "Nhấn Chơi Lại để chơi lại Game hoặc Quay lại màn hình chính để trở về";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            dem++;
            //if (dem % 2 == 1)
            //{
            //    //MessageBox.Show("Hiệp đại ca chất vcl <3 <3 <3 !!");
            //    ok = false;
            //    thongBaoTrongGame();
            //  //  btnDone.Enabled = false;
            //    btnStart.Text = "Chơi lại";
            //    setPzGame();
            //    phut--;
            //}
            //else
            //{
            //    //btnDone.Enabled = true;
            //    phut = 5;
            //    thongBaoStart();
            //    btnStart.Text = "Bắt đầu";
            //}
            if (dem > 0) { btnStart.Text = "Chơi lại"; thongBaoTrongGame(); phut = 4; }
            ok = false;
            setPzGame();

        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (ok) trans.Invoke(1); else trans.Invoke(0);
            player.close();
            tmMusic.Stop();
            
           
            this.Close();
        }

        //private string str = "Bạn chưa vượt qua thử thách rồi, chúc may mắn lần sau nhé !";
        //private int xxxxx = 0;
        //private void tmNotiLose_Tick(object sender, EventArgs e)
        //{
        //    if (xxxxx < str.Length)
        //    {
        //        lblNotiLose.Text += str[xxxxx];
        //        xxxxx++;
        //    }
        //}


        private void btnDone_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnStart_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void picEndGame_Click(object sender, EventArgs e)
        {

        }

        private void lblNotiLose_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                turnLeft();
            }
            else
                if (e.KeyCode == Keys.Left)
                {
                    turnRight();
                }
                else
                    if (e.KeyCode == Keys.Up)
                    {

                        goDown();
                    }
                    else
                        if (e.KeyCode == Keys.Down)
                        {
                            goUp();
                        } 
        }
        private int t = 0;
        private void tmMusic_Tick(object sender, EventArgs e)
        {
            t++;
            if (t==220)
            {
                t = 0;
                player.close();
                enableSound();
            }  
        }

        private void lblLevel_Click(object sender, EventArgs e)
        {

        }
        private string S1 = "Thành công chỉ thực sự ngọt ngào khi ta có tri kỉ, có những con người tuyệt vời bên cạnh để sẻ chia.";
        private string S2 = "Dù bạn thành công hay thất bại, tham vọng hay là không, nhưng hãy luôn trân trọng những giá trị mình đang có..";
        private int i1 = 0;
        private int i2 = 0;
        private void tmWinGame_Tick(object sender, EventArgs e)
        {
            if (i1<S1.Length)
            {
                lblWin1.Text += S1[i1];
                i1++;
            } else
                if (i1<S2.Length)
            {

                lblWin2.Text +=S2[i2];
                i2++;
            }
        }

        private void pnInfoGame_Paint(object sender, PaintEventArgs e)
        {

        }
        

    }
}
