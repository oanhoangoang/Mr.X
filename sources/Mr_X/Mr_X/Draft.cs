using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalExpression;
namespace Mr_X
{
    public partial class Draft : Form
    {
        public Draft()
        {
            InitializeComponent();
        }

        private void Draft_Load(object sender, EventArgs e)
        {
            frmCalExpression gt = new frmCalExpression(1, "hiepdz", "13");
            gt.ShowDialog();
        }
    }
}
