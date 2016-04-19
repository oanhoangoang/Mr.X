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

            for (int i = 3; i < bt2.Name.Length; i++) levelClick = levelClick * 10 + bt2.Name[i] - '0';
            if (levelClick <= nowLevel)
            {

                if (nowLevel == 1)
                {

                    frmCalExpression g = new frmCalExpression(1, "Bảo vệ", "3");
                    g.trans = data;
                    g.ShowDialog();
                    
                    
                }
                else if (nowLevel == 2)
                {
                    FindNumDisplay g = new FindNumDisplay(2, "Vẫn chỉ là bảo vệ", 6, 5, 60, false);
                    g.trans = data;
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
            if (nowLevel == 2)
            {
                btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(151)))), ((int)(((byte)(191)))));
                btn2.Enabled = true; }

        }


    }
}
