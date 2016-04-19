using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Mr_X
{
    public partial class Intro : UserControl
    {

        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }
        //private int i = 2;
        private void tmrDescription_Tick(object sender, EventArgs e)
        {
            lblDescription.Top -= 1;
            
            //picBackGr.Left += i;
            //if (picBackGr.Left >=0 || picBackGr.Right <=-50)
            //{
            //    i = -i;
            //}
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
