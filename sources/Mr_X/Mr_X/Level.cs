using System;
using System.IO;
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
using PiPo;
using Prime;
using LgImg;
using OrBut;
using ArrMsc;
using frPlayMo;
using FndDiCell;
namespace Mr_X
{
    public partial class Level : UserControl
    {

        public Level()
        {
            InitializeComponent();
            //StreamReader inp = new StreamReader(@"database\MrX.txt");
            //nowLevel = chuyenhoa(inp.ReadLine());
            //solve();
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
                //else if (levelClick == 1)
                //{
                //    PingPong g = new PingPong(1, "Bảo vệ", 10);
                //    g.trans = data;
                //    g.ShowDialog();
                //}

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
                else if (levelClick == 10)
                {
                    ArrMscDisp g = new ArrMscDisp(1, "Nhân viên lễ tân", "10");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 11)
                {
                    frmCalExpression g = new frmCalExpression(2, "Chuyên viên Marketing", "2", true);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 12)
                {
                    FindNumDisplay g = new FindNumDisplay(12, "Chuyên viên Marketing", 8, 15, 90, true, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 13)
                {
                    RememberMe g = new RememberMe(13, "Chuyên viên Marketing", 6, 9, 15, 30, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 14)
                {
                    FindSameCell g = new FindSameCell(14, "Chuyên viên Marketing", 5, 6, 16, 50, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 15)
                {
                    FindDifferentCell g = new FindDifferentCell(15, "Chuyên viên Marketing", 5, 1, 3, 10, 75, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 16)
                {
                    CatchTheWord g = new CatchTheWord(16, "Trưởng phòng tạp vụ", 8, 8, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 17)
                {
                    LgImgDisp g = new LgImgDisp(2, "Trưởng phòng tạp vụ", "17");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 18)
                {
                    FindDifferentCell g = new FindDifferentCell(18, "Trưởng phòng tạp vụ", 6, 2, 3, 12, 90, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 19)
                {
                    ArrMscDisp g = new ArrMscDisp(2, "Trưởng phòng tạp vụ", "19");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 20)
                {
                    orderButton g = new orderButton(20, "Trưởng phòng tạp vụ", 6, 8, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 21)
                {
                    FstCalDisp g = new FstCalDisp(2, "Thư kí của phó giám đốc", "21");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 22)
                {
                    CatchTheWord g = new CatchTheWord(16, "Thư kí của phó giám đốc", 8, 8, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 23)
                {
                    ArrMscDisp g = new ArrMscDisp(2, "Thư kí của phó giám đốc", "23");
                    g.trans = data;
                    g.ShowDialog();
                }




            }
        }


        public void solve()
        {
            if (nowLevel >= 2)
            {
                btn2.BackColor = Color.FromArgb(92, 151, 191);
                btn2.Enabled = true;
            }
            if (nowLevel >= 3)
            {
                btn3.BackColor = Color.FromArgb(92, 151, 191);
                btn3.Enabled = true;
            }
            if (nowLevel >= 4)
            {
                btn4.BackColor = Color.FromArgb(92, 151, 191);
                btn4.Enabled = true;
            }
            if (nowLevel >= 5)
            {
                btn5.BackColor = Color.FromArgb(92, 151, 191);
                btn5.Enabled = true;
            } 
            if (nowLevel >= 6)
            {
                btn6.BackColor = Color.FromArgb(92, 151, 191);
                btn6.Enabled = true;
            } 
            if (nowLevel >= 7)
            {
                btn7.BackColor = Color.FromArgb(92, 151, 191);
                btn7.Enabled = true;
            } 
            if (nowLevel >= 8)
            {
                btn8.BackColor = Color.FromArgb(92, 151, 191);
                btn8.Enabled = true;
            } 
            if (nowLevel >= 9)
            {
                btn9.BackColor = Color.FromArgb(92, 151, 191);
                btn9.Enabled = true;
            } 
            if (nowLevel >= 10)
            {
                btn10.BackColor = Color.FromArgb(92, 151, 191);
                btn10.Enabled = true;
            } 
            if (nowLevel >= 11)
            {
                btn11.BackColor = Color.FromArgb(92, 151, 191);
                btn11.Enabled = true;
            } if (nowLevel >= 12)
            {
                btn2.BackColor = Color.FromArgb(92, 151, 191);
                btn2.Enabled = true;
            }
            if (nowLevel >= 13)
            {
                btn3.BackColor = Color.FromArgb(92, 151, 191);
                btn3.Enabled = true;
            }
            if (nowLevel >= 14)
            {
                btn4.BackColor = Color.FromArgb(92, 151, 191);
                btn4.Enabled = true;
            }
            if (nowLevel >= 15)
            {
                btn5.BackColor = Color.FromArgb(92, 151, 191);
                btn5.Enabled = true;
            } 
            if (nowLevel >= 16)
            {
                btn6.BackColor = Color.FromArgb(92, 151, 191);
                btn6.Enabled = true;
            }
            if (nowLevel >= 17)
            {
                btn7.BackColor = Color.FromArgb(92, 151, 191);
                btn7.Enabled = true;
            }
            if (nowLevel >= 18)
            {
                btn8.BackColor = Color.FromArgb(92, 151, 191);
                btn8.Enabled = true;
            }
            if (nowLevel >= 19)
            {
                btn9.BackColor = Color.FromArgb(92, 151, 191);
                btn9.Enabled = true;
            } 
            if (nowLevel >= 20)
            {
                btn10.BackColor = Color.FromArgb(92, 151, 191);
                btn10.Enabled = true;
            } 
            if (nowLevel >= 21)
            {
                btn11.BackColor = Color.FromArgb(92, 151, 191);
                btn11.Enabled = true;
            }
            if (nowLevel >= 22)
            {
                btn2.BackColor = Color.FromArgb(92, 151, 191);
                btn2.Enabled = true;
            }
            if (nowLevel >= 23)
            {
                btn3.BackColor = Color.FromArgb(92, 151, 191);
                btn3.Enabled = true;
            }
            if (nowLevel >= 24)
            {
                btn4.BackColor = Color.FromArgb(92, 151, 191);
                btn4.Enabled = true;
            }
            if (nowLevel >= 25)
            {
                btn5.BackColor = Color.FromArgb(92, 151, 191);
                btn5.Enabled = true;
            }
            if (nowLevel >= 26)
            {
                btn6.BackColor = Color.FromArgb(92, 151, 191);
                btn6.Enabled = true;
            }
            if (nowLevel >= 27)
            {
                btn7.BackColor = Color.FromArgb(92, 151, 191);
                btn7.Enabled = true;
            }
            if (nowLevel >= 28)
            {
                btn8.BackColor = Color.FromArgb(92, 151, 191);
                btn8.Enabled = true;
            }
            if (nowLevel >= 29)
            {
                btn9.BackColor = Color.FromArgb(92, 151, 191);
                btn9.Enabled = true;
            }
            if (nowLevel >= 30)
            {
                btn9.BackColor = Color.FromArgb(239, 72, 54
);
                btn9.Enabled = true;
            } 

        }

        private int chuyenhoa(String s)
        {
            if (s.Length > 2) return 1;
            int value = 0;
            for (int i = 0; i < s.Length; i++) value = value * 10 + s[i] - 'a';
            if (value < 1 || value > 40) value = 1;
            return value;
        }


        private string mahoa(int value)
        {
            string xauMaHoa = "";
            string xauTrungGian = value.ToString();
            for (int i = 0; i < xauTrungGian.Length; i++) xauMaHoa += (char)(xauTrungGian[i] - '0' + 'a');
            return xauMaHoa;
        }



        // ghi vongf hiện tại của người chơi ra file txt
        public void data(int value)
        {
            if (levelClick == nowLevel)
            {
                nowLevel += value;
            }
            StreamWriter output = new StreamWriter(@"database\MrX.txt");
            output.WriteLine(mahoa(nowLevel));
            output.Close();
            solve();
        }

    }
}
