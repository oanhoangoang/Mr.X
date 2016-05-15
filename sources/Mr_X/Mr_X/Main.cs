using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrMsc;
using CalExpression;
using CatTheWo;
using ChseNum;
using FndDiCell;
using FndNum;
using FndSaCell;
using frPlayMo;
using FstCal;
using LgImg;
using OrBut;
using Prime;
using RemMe;
using follArrow;
using System.IO;

namespace Mr_X
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            StreamReader inp = new StreamReader(@"database\MrX.txt");
            nowLevel = convert(inp.ReadLine());
            solve();
        }

        // Nhận giá trị Bật hay Tắt âm thanh 
        public void getSound(bool sound)
        {
            
        }

        // Tạo đường dẫn đến các mini game
        private int nowLevel = 1;
        private int levelClick;
        // Gọi ra mini game khi click vào từng button level
        private void btn_Click(object sender, EventArgs e)
        {
            #region Gọi các mini game
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
                    frmCalExpression g = new frmCalExpression(1, "Bảo vệ", "2", false);
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
                    FstCalDisp g = new FstCalDisp(2, "Trưởng phòng hành chính", "21");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 22)
                {
                    CatchTheWord g = new CatchTheWord(16, "Trưởng phòng hành chính", 8, 8, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 23)
                {
                    ArrMscDisp g = new ArrMscDisp(2, "Trưởng phòng hành chính", "23");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 24)
                {
                    followArrow g = new followArrow(24, "Trưởng phòng hành chính", 40, 30, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 25)
                {
                    FstCalDisp g = new FstCalDisp(2, "Trưởng phòng hành chính", "25");
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 26)
                {
                    FindSameCell g = new FindSameCell(26, "Phó giám đốc", 6, 7, 42, 120, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 27)
                {
                    orderButton g = new orderButton(27, "Phó giám đốc", 6, 13, 60, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 28)
                {
                    followArrow g = new followArrow(28, "Phó giám đốc", 80, 45, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }
                else if (levelClick == 29)
                {
                    FindDifferentCell g = new FindDifferentCell(18, "Phó giám đốc", 6, 3, 3, 20, 90, false, 1);
                    g.trans = data;
                    g.ShowDialog();
                }


            }
            #endregion
        }



        // Xử lí mở button level tiếp theo và đổi màu
        private void control(Button btn)
        {
            btn.BackColor = Color.FromArgb(92, 151, 191);
            btn.Enabled = true;
        }

        // Gọi hàm control để xử lý các button cụ thể
        private void solve()
        {
            #region Gọi hàm control đối với từng button
            if (nowLevel >= 2)
                control(btn2);
            if (nowLevel >= 3)
                control(btn3);
            if (nowLevel >= 4)
                control(btn4);
            if (nowLevel >= 5)
                control(btn5);
            if (nowLevel >= 6)
                control(btn6);
            if (nowLevel >= 7)
                control(btn7);
            if (nowLevel >= 8)
                control(btn8);
            if (nowLevel >= 9)
                control(btn9);
            if (nowLevel >= 10)
                control(btn10);
            if (nowLevel >= 11)
                control(btn11);
            if (nowLevel >= 12)
                control(btn12);
            if (nowLevel >= 13)
                control(btn13);
            if (nowLevel >= 14)
                control(btn14);
            if (nowLevel >= 15)
                control(btn15);
            if (nowLevel >= 16)
                control(btn16);
            if (nowLevel >= 17)
                control(btn17);
            if (nowLevel >= 18)
                control(btn18);
            if (nowLevel >= 19)
                control(btn19);
            if (nowLevel >= 20)
                control(btn20);
            if (nowLevel >= 21)
                control(btn21);
            if (nowLevel >= 22)
                control(btn22);
            if (nowLevel >= 23)
                control(btn23);
            if (nowLevel >= 24)
                control(btn24);
            if (nowLevel >= 25)
                control(btn25);
            if (nowLevel >= 26)
                control(btn26);
            if (nowLevel >= 27)
                control(btn27);
            if (nowLevel >= 28)
                control(btn28);
            if (nowLevel >= 29)
                control(btn29);
            if (nowLevel >= 30)
            {
                btn30.BackColor = Color.FromArgb(239, 72, 54);
                btn30.Enabled = true;
            }
            #endregion
        }


        //  Chuyển đổi và mã hóa kết quả người chơi trước khi lưu dữ liệu
        private int convert(String s)
        {
            if (s.Length > 2) return 1;
            int value = 0;
            for (int i = 0; i < s.Length; i++) value = value * 10 + s[i] - 'a';
            if (value < 1 || value > 40) value = 1;
            return value;
        }

        private string encode(int value)
        {
            string xauMaHoa = "";
            string xauTrungGian = value.ToString();
            for (int i = 0; i < xauTrungGian.Length; i++) xauMaHoa += (char)(xauTrungGian[i] - '0' + 'a');
            return xauMaHoa;
        }



        // Ghi vòng hiện tại của người chơi ra file txt
        public void data(int value)
        {
            if (levelClick == nowLevel)
            {
                nowLevel += value;
            }
            StreamWriter output = new StreamWriter(@"database\MrX.txt");
            output.WriteLine(encode(nowLevel));
            output.Close();
            solve();
        }

        // Trở lại màn hình chính
        private void btnBack_Click(object sender, EventArgs e)
        {
            ucOption.Show();
        }

        
        

        
    }
}
