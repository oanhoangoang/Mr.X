using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiPo
{
    public partial class PingPong : Form
    {
       // lấy giá trị level, thời gian, chức vụ
        int level, time;
        string chucVu;
        public PingPong(int level, string chucVu, int time)
        {
            InitializeComponent();
            lblLevel.Text = level.ToString();
            lblChucVu.Text = chucVu;
            lblTime.Text = time.ToString();
            //Cursor.Hide();
            //this.FormBorderStyle = FormBorderStyle.None;
        }        


        // thiết lập đường chạy của Ball
        int speed_left = 4;     //tốc độ sang trái, phải của ball
        int speed_top = 4;
        
        private void tmrBallMove_Tick(object sender, EventArgs e)
        {
            picBar.Left = Cursor.Position.X - (picBar.Width / 2);   // tạo vị trí của Bar
            picBall.Left += speed_left;
            picBall.Top += speed_top;

            // thiết lập chiều chuyển động khi va chạm với thanh Bar, các cạnh của màn hình
            if (picBall.Bottom >= picBar.Top && picBall.Bottom <= picBar.Bottom && picBall.Left >= picBar.Left && picBall.Right <= picBar.Right)
            {
                speed_left += 2;
                speed_top += 2;
                speed_top = -speed_top;
                Random r = new Random();
                pnlGameDisplay.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(120, 255));
            }
            if (picBall.Left <= pnlGameDisplay.Left)
                speed_left = -speed_left;

            if (picBall.Right >= pnlGameDisplay.Right)
                speed_left = -speed_left;

            if (picBall.Top <= pnlGameDisplay.Top)
                speed_top = -speed_top;

            if (picBall.Bottom >= pnlGameDisplay.Bottom)
                tmrBallMove.Enabled = false;
        }


        // hiển thị thời gian chạy
        int sec = 0;
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTimeGone.Text = sec.ToString();
            sec++;
            if ((sec - time) % 20 == 0 && picBar.Width >= 50)
            {
                picBar.Width -= 5;
            }
        }


        // trả về kết quả người chơi
        public delegate void truyen(int value);
        public truyen trans;
        private void getAnswer()
        {
            if (sec >= time)
                trans.Invoke(1);
            else
                trans.Invoke(0);

        }

        // mở game khi nhấn nút Bắt đầu
        private void btnStart_Click(object sender, EventArgs e)
        {
            sec = int.Parse(lblTimeGone.Text);
            tmrTime.Enabled = true;
            tmrBallMove.Enabled = true;
        }

        // kết thúc và nhấn Trở về
        private void btnBack_Click(object sender, EventArgs e)
        {
            getAnswer();
            this.Close();
        }
    }
}
