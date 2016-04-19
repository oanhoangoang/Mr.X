using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FstCal;
using CalExpression;
using FndNum;
using FndSaCell;



namespace Mr_X
{
    public partial class Level : UserControl
    {

        public Level()
        {
            InitializeComponent();
        }


        private int nowLevel = 1;
        private int levelClick;
        private void btn_Click(object sender, EventArgs e)
        {
            Button bt2 = (Button)sender;
            levelClick = 0;

            for (int i = 3; i < bt2.Text.Length; i++) levelClick = levelClick * 10 + bt2.Text[i] - '0';
            if (levelClick <= nowLevel)
            {

                if (nowLevel == 1)
                {
                    FstCalDisp g = new FstCalDisp(1, "Bảo vệ", "1");
                    //g.trans = data;
                    g.ShowDialog();
                }
                else if (nowLevel == 2)
                {
                    frmCalExpression g = new frmCalExpression(1, "Bảo vệ", "3");
                    //g.trans = data;
                    g.ShowDialog();
                    
                    
                }
                else if (nowLevel == 3)
                {
                    FindNumDisplay g = new FindNumDisplay(6, 5, 60);
                    //g.trans = data;
                    g.ShowDialog();
                }
            }
        }

        public void data(int value)
        {
            if (levelClick == nowLevel)
            {
                nowLevel += value;
            }
        }


    }
}
