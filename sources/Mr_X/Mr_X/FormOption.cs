using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using frPlayMo;

namespace Mr_X
{
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();
        }

        // Hiển thị các panel khi nhấp vào Chiến đấu, Luyện tập, Thông tin
        private void lblFight_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
            pnlPrac.Visible = false;
            pnlFight.Visible = true;
            lblFight.ForeColor = Color.FromArgb(245, 171, 53);
            lblPractice.ForeColor = Color.LightGray;
            lblAbout.ForeColor = Color.LightGray;
        }

        private void lblPractice_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = false;
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
            lblDescription.Visible = true;
            lblAbout.ForeColor = Color.FromArgb(245, 171, 53);
            lblFight.ForeColor = Color.LightGray;
            lblPractice.ForeColor = Color.LightGray;
        }

        private bool sound = true;
        private void lblSound_Click(object sender, EventArgs e)
        {
            pnlFight.Visible = false;
            pnlPrac.Visible = false;
            lblDescription.Visible = false;
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

       
        private void lblContinueFight_Click(object sender, EventArgs e)
        {
            Main m = new Main(sound, 0);
            m.ShowDialog();
            
        }

        private void lblNewGameFight_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter(@"database/MrX.txt");
            output.WriteLine("b");
            output.Close();
            Main m = new Main(sound, 1);
            m.ShowDialog();
        }

        private void lblContinuePrac_Click(object sender, EventArgs e)
        {
            freePlayMode f = new freePlayMode(sound);
            f.ShowDialog();
        }

        private void lblNewGamePrac_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter(@"database/frPlayMo/level.txt");
            for (int i = 1; i <= 8; i++) output.WriteLine("b");
            output.Close();
            freePlayMode f = new freePlayMode(sound);
            f.ShowDialog();
            
        }

      
    }
}
