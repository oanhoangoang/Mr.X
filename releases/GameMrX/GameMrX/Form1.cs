using System;
using System.Windows.Forms;

namespace GameMrX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            var tim = new TimSo(6, 3, 20);
            tim.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}