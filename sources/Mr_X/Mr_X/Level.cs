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
using RemMe;
using CatTheWo;
using PingPong;
using Prime;
using LgImg;
using OrBut;
namespace Mr_X
{
    public partial class Level : UserControl
    {

        public Level()
        {
            InitializeComponent();
        }

        // tạo đường dẫn đến các mini game
        private int nowLevel = 1;
        private int levelClick;

        private void btn_Click(object sender, EventArgs e)
        {
            Button bt2 = (Button)sender;
            levelClick = 0;

            for (int i = 3; i < bt2.Name.Length; i++) levelClick = levelClick * 10 + bt2.Name[i] - '0';
            if (levelClick <= nowLevel)
            {
                if (levelClick == 1)
                {
                    FstCalDisp g = new FstCalDisp(1, "Bảo vệ", "1");
                    g.trans = data;
                    g.ShowDialog();             
                }

                else if (levelClick == 2)
                {
                    frmCalExpression g = new frmCalExpression(1, "Bảo vệ", "2", true);
                    g.trans = data;
                    g.ShowDialog();                 
                }
                else if (levelClick == 3)
                {
                    FindNumDisplay g = new FindNumDisplay(3, "Bảo vệ", 6, 8, 60, true, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 4)
                {
                    RememberMe g = new RememberMe(4, "Vẫn chỉ là bảo vệ", 5, 7, 12, 30, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 5)
                {
                    FindSameCell g = new FindSameCell(5, "Bảo vệ", 4, 5, 8, 40, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 6)
                {
                    FrmPrime g = new FrmPrime(1, "Nhân viên lễ tân", "6", 20, true);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 7)
                {
                    LgImgDisp g = new LgImgDisp(1, "Nhân viên lễ tân", "7");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 8)
                {
                    FstCalDisp g = new FstCalDisp(2, "Nhân viên lễ tân", "8");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 9)
                {
                    orderButton g = new orderButton(9, "Nhân viên lễ tân", 4, 6, 60, false, 1);
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
                btn2.BackColor = Color.FromArgb(92, 151, 191);
                btn2.Enabled = true; 
            }
            if (nowLevel == 3)
            {
                btn3.BackColor = Color.FromArgb(92, 151, 191);
                btn3.Enabled = true;
            }
            if (nowLevel == 4)
            {
                btn4.BackColor = Color.FromArgb(92, 151, 191);
                btn4.Enabled = true;
            }
            if (nowLevel == 5)
            {
                btn5.BackColor = Color.FromArgb(92, 151, 191);
                btn5.Enabled = true;
            } if (nowLevel == 6)
            {
                btn6.BackColor = Color.FromArgb(92, 151, 191);
                btn6.Enabled = true;
            } if (nowLevel == 7)
            {
                btn7.BackColor = Color.FromArgb(92, 151, 191);
                btn7.Enabled = true;
            } if (nowLevel == 8)
            {
                btn8.BackColor = Color.FromArgb(92, 151, 191);
                btn8.Enabled = true;
            } if (nowLevel == 9)
            {
                btn9.BackColor = Color.FromArgb(92, 151, 191);
                btn9.Enabled = true;
            } if (nowLevel == 10)
            {
                btn10.BackColor = Color.FromArgb(92, 151, 191);
                btn10.Enabled = true;
            } if (nowLevel == 11)
            {
                btn11.BackColor = Color.FromArgb(92, 151, 191);
                btn11.Enabled = true;
            }

        }


    }
}
