using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Mr_X
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            
        }

        private void picBackGround_Click(object sender, EventArgs e)
        {

        }


        //tạo hiệu ứng động cho ảnh nền và dòng chữ chạy
        private void tmrDecription_Tick(object sender, EventArgs e)
        {
            lblDecription.Top -= 1;

            
        }


        //ấn nút Skip để chuyển sang form mới
        private void ShowMainForm_2()
        {
            Mainform_2 f = new Mainform_2();
            f.ShowDialog();
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(new ThreadStart(ShowMainForm_2));
            thr.Start();
            this.Close();
        }

        private void pnlDecription_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
