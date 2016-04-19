using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FndNum;
using CalExpression;
using FndSaCell;
using FstCal;
using RemMe;

namespace Mr_X
{
    public partial class Playing : UserControl
    {
        //private static Playing _instance;
        //public static Playing Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new Playing();
        //        return _instance;
        //    }
        //}
        public Playing()
        {
            InitializeComponent();
            frmCalExpression gt = new frmCalExpression(1, "hiepdz", "13");
            gt.Show();
          //  RememberMe frm = new RememberMe(6, 3, 3, 10);
           // frm.ShowDialog();
        }
    }
}
