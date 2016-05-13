using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frPlayMo;

namespace Mr_X
{
    public partial class OptionDisplay : UserControl
    {
        public OptionDisplay()
        {
            InitializeComponent();
        }

        // mở game đã đã lưu để chơi tiếp
        private void lblContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // hiện panel chọn chế độ chơi ở mục Chơi mới đồng thời ẩn các panel Cài đặt, panel Thông tin
        private void lblNewGame_Click(object sender, EventArgs e)
        {
            pnl_Infor.Visible = false;
            pnlSetting.Visible = false;
            pnlNewGame.Visible = true;
           
        }

        // hiện panel Cài đặt âm thanh
        private void lblSetting_Click(object sender, EventArgs e)
        {
            pnl_Infor.Visible = false;
            pnlNewGame.Visible = false;
            pnlSetting.Visible = true;
        }

        // hiện panel Thông tin
        private void lbl_Infor_Click(object sender, EventArgs e)
        {
            pnlNewGame.Visible = false;
            pnlSetting.Visible = false;
            pnl_Infor.Visible = true;
        }

        // mở game khi chọn chơi theo tiến trình
        private void lblMarathon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // mở bảng game khi chọn Chơi tự do
        private void lblFreePlaying_Click(object sender, EventArgs e)
        {
            
        }

        // xử lí bật, tắt âm
        private void lblSound_Click(object sender, EventArgs e)
        {

        }

        // xử lí bật, tắt nhạc
        private void lblMusic_Click(object sender, EventArgs e)
        {

        }

    }
}
