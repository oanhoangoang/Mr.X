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

        // Hiển thị các panel khi nhấp vào Chiến đấu, Luyện tập, Thông tin
        private void lblFight_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            pnlPrac.Visible = false;
            pnlFight.Visible = true;
            lblFight.ForeColor = Color.FromArgb(245, 171, 53);
            lblPractice.ForeColor = Color.LightGray;
            lblAbout.ForeColor = Color.LightGray;
        }

        private void lblPractice_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            pnlFight.Visible = false;
            pnlPrac.Visible = true;
            lblPractice.ForeColor = Color.FromArgb(245, 171, 53);
            lblFight.ForeColor = Color.LightGray;
            lblAbout.ForeColor = Color.LightGray;
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            pnlFight.Visible = false;
            pnlPrac.Visible = false;
            pnlAbout.Visible = true;
            lblAbout.ForeColor = Color.FromArgb(245, 171, 53);
            lblFight.ForeColor = Color.LightGray;
            lblPractice.ForeColor = Color.LightGray;
        }

        // Cài đặt Bật/Tắt âm thanh
        public delegate bool setSound();
        
        
        static bool sound = true;
        public void lblSound_Click(object sender, EventArgs e)
        {
            pnlFight.Visible = false;
            pnlPrac.Visible = false;
            pnlAbout.Visible = false;
            if (lblSound.Text == "Bật")
            {
                sound = false;
                lblSound.Text = "Tắt";
                
            }
            else
            {
                sound = true;
                lblSound.Text = "Bật";
                
            }
            
        }

        private void lblContinuePrac_Click(object sender, EventArgs e)
        {
            freePlayMode f = new freePlayMode(sound);
            f.ShowDialog();
        }

        private void lblNewGamePrac_Click(object sender, EventArgs e)
        {
            freePlayMode f = new freePlayMode(sound);
            f.ShowDialog();
        }

        private void lblContinueFight_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblNewGameFight_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        


        


    }
}
