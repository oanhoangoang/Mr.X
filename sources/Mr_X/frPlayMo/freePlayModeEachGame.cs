using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using CatTheWo;
using ChseNum;
using FndDiCell;
using FndNum;
using FndSaCell;
using OrBut;
using RemMe;
using follArrow;

namespace frPlayMo
{
    public partial class freePlayModeEachGame : Form
    {
        // thứ thự của game người chơi chọn, đánh số từ 1 tới 8
        private int idGame;

        // số thứ tự của ảnh nền hiển thị, giá trị được random từ 1 tới 4
        private int stt;

        // lưu đường dẫn để load ảnh
        private string link;

        // level mà người chơi đã đạt tới
        private int nowLevel;

        // level người chơi ấn
        private int levelClick;

        // số lượng game
        private int numberOfGame = 8;

        // bật hay tắt nhạc
        private bool turnOnOrOff;

        // level[i]=vòng mà người chơi đã đạt được ở trò chơi thứ i
        private string[] level = new String[100];
        
        // hiển thị các vòng của một trò chơi
        private Button[][] btn = new Button[10][];

        // phát nhạc thắng, thua
        private SoundPlayer sp;

        // làm mất nền của label
        private void transBackground(PictureBox picBackGround, Label lbl)
        {
            var Mediate = this.PointToScreen(lbl.Location);
            Mediate = picBackGround.PointToClient(Mediate);
            lbl.Parent = picBackGround;
            lbl.Location = Mediate;
            lbl.BackColor = Color.Transparent;
        }

        // load ảnh có đường dẫn là link vào pic
        private void loadPicture(PictureBox pic, string link)
        {
            try
            {
                pic.Image = Image.FromFile(@link);
            }
            catch (Exception ex) { }
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // load ảnh có đường dẫn là link vào btnMediate
        private void loadPictureButton(Button btnMediate, string link)
        {
            try
            {
                btnMediate.Image = Image.FromFile(@link);
            }
            catch (Exception ex) { }
        }

        // lấy ngẫu nhiên một số trong khoảng từ limitLow tới limitHigh
        Random rd = new Random();
        private int randomNumber(int limitLow, int limitHigh)
        {
            return rd.Next(limitLow, limitHigh + 1);
        }

        // phát nhạc theo đường dẫn: link
        private void playMusic(string link)
        {
            try
            {
                sp = new SoundPlayer(@link);
                sp.Play();
            }
            catch (Exception ex) { }
        }

        // lấy các giá trị: số thứ tự của game, tên game, bật hay tắt nhạc
        public freePlayModeEachGame(int id, string name, bool turnOffSound)
        {
            InitializeComponent();
            turnOnOrOff = turnOffSound;
            if (turnOnOrOff == false)
            {
                try
                {
                    wmpSoundTrack.URL = @"sound/frPlayMo/freePlayModeEachGame/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }
            idGame = id;
            lblGame.Text = name;
            
            solve();
        }

        /*chúng ta sẽ coi 0="a", 1="b", 2="c", 3="d"...11="bb", 30="da"*/
        private string mahoa(int value)
        {
            string xauMaHoa = "";
            string xauTrungGian = value.ToString();
            for (int i = 0; i < xauTrungGian.Length; i++) xauMaHoa += (char)(xauTrungGian[i] - '0' + 'a');
            return xauMaHoa;
        }
        
        // chuyển hóa xâu S ra số theo cách mã hóa đã mô tả ở bên trên
        private int chuyenhoa(String s)
        {
            if (s.Length > 2) return 1;
            int value = 0;
            for (int i = 0; i < s.Length; i++) value = value * 10 + s[i] - 'a';
            if (value < 1 || value > 30) value = 1;
            return value;
        }

        // tạo các vòng của một trò chơi
        private void createButton()
        {
            for (int i = 1; i <= 5; i++)
            {
                btn[i] = new Button[10];
                for (int j = 1; j <= 6; j++)
                {
                    btn[i][j]=new Button();
                    btn[i][j].Name = ((i - 1) * 6 + j).ToString();
                    
                    btn[i][j].Size = new Size(74, 70);
                    btn[i][j].Location = new Point(160 + (j - 1) * 160, 160 + (i - 1) * 100);
                    btn[i][j].FlatStyle = FlatStyle.Flat;
                    btn[i][j].ForeColor = Color.White;
                    btn[i][j].Click += new EventHandler(click);
                    if ( (i - 1) * 6 + j < nowLevel)
                    {
                        btn[i][j].Text = ((i - 1) * 6 + j).ToString();
                        loadPictureButton(btn[i][j],"picture/frPlayMo/freePlayModeEachGame/victory.jpg");
                    }
                    else if ((i - 1) * 6 + j == nowLevel)
                    {
                        btn[i][j].Text = ((i - 1) * 6 + j).ToString();
                        loadPictureButton(btn[i][j], "picture/frPlayMo/freePlayModeEachGame/now.jpg");
                    }
                    else
                    {
                        loadPictureButton(btn[i][j], "picture/frPlayMo/freePlayModeEachGame/normal.jpg");
                    } 
                    Controls.Add(btn[i][j]);
                }
            }
        }

        // hiển thị nền của game
        private void createBackGround()
        {
            PictureBox picBackGround = new PictureBox();
            picBackGround.Size = new Size(1233, 702);
            picBackGround.Location = new Point(0, 0);
            picBackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(picBackGround);

            stt = randomNumber(1, 4);
            link = "picture/frPlayMo/freePlayModeEachGame/" + stt.ToString() + ".gif";
            loadPicture(picBackGround, link);

            transBackground(picBackGround, lblGame);
            
            link = "picture/frPlayMo/freePlayMode/";
            if (idGame == 1) link += "catTheWo.jpg";
            if (idGame == 2) link += "chseNum.jpg";
            if (idGame == 3) link += "fndDiCell.jpg";
            if (idGame == 4) link += "fndNum.jpg";
            if (idGame == 5) link += "fndSaCell.jpg";
            if (idGame == 6) link += "orBut.jpg";
            if (idGame == 7) link += "remMe.jpg";
            if (idGame == 8) link += "follArrow.jpg";
            loadPicture(picGame, link);
        }

        // gọi ra game CatTheWo
        private void callCatTheWo(int level, bool turnOffSound)
        {
            int[] scoreCatTheWo = { 0, 1, 2, 2, 3, 4, 4, 6, 7, 4, 5, 6, 7, 8, 9, 5, 7, 9, 11, 13, 14, 8, 12, 14, 16, 18, 15, 17, 19, 21, 25 };
            int[] roundCatTheWo = { 0, 3, 3, 5, 5, 5, 8, 8, 8, 10, 10, 10, 10, 10, 10, 15, 15, 15, 15, 15, 15, 20, 20, 20, 20, 20, 30, 30, 30, 30, 30 };
            int[] timeCatTheWo = { 0, 20, 20, 40, 40, 45, 60, 60, 75, 90, 90, 90, 95, 95, 95, 95, 95, 100, 100, 100, 100, 140, 140, 140, 140, 140, 180, 180, 180, 180, 180 };

            CatchTheWord frmCatTheWo = new CatchTheWord(level, "", scoreCatTheWo[level], roundCatTheWo[level], timeCatTheWo[level], turnOffSound, 2);
            frmCatTheWo.trans = data;
            frmCatTheWo.ShowDialog();
        }

        // gọi ra game ChseNum
        private void callChseNum(int level, bool turnOffSound)
        {
            int[] sizeChseNum = { 0, 3,  3,  3,  3,  3,  3,   4,  4,  4,  4,  4,  4,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5 , 6,  6,  6,  6,  6,  6  };
            int[] kindChseNum = { 0, 1,  1,  1,  2,  2,  2,   2,  2,  2,  3,  3,  3,  1,  1,  1,  1,  2,  2,  2,  2,  3,  3,  3,  3,  2,  2,  2,  3,  3,  3  };
            int[] timeChseNum = { 0, 20, 15, 10, 20, 15, 10,  20, 18, 16, 25, 20, 15, 15, 20, 25, 30, 30, 25, 20, 15, 40, 35, 30, 20, 30, 35, 40, 45, 50, 60 };

            ChooseNumber frmChseNum = new ChooseNumber(level, "", sizeChseNum[level], kindChseNum[level], timeChseNum[level], turnOffSound, 2);
            frmChseNum.trans = data;
            frmChseNum.ShowDialog();
        }

        // gọi ra game FndDiCell
        private void callFndDiCell(int level, bool turnOffSound)
        {
            int[] sizeFndDiCell  = {0, 4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5  };
            int[] typeFndDiCell  = {0, 1,  1,  1,  1,  2,  2,  2,  2,  3,  3,  3,  3,  1,  1,  1,  1,  2,  2,  2,  2,  3,  3,  3,  3,  1,  1,  2,  2,  3,  3  };
            int[] kindFndDiCell  = {0, 1,  1,  2,  3,  1,  1,  2,  3,  1,  1,  2,  3,  1,  2,  3,  3,  1,  2,  3,  3,  1,  2,  3,  3,  1,  1,  2,  2,  3,  3  };
            int[] scoreFndDiCell = {0, 3,  5,  3,  3,  3,  5,  3,  3,  3,  5,  3,  3,  6,  7,  8,  9,  6,  7,  8,  9,  6,  7,  8,  9,  10, 12, 10, 12, 10, 12 };
            int[] timeFndDiCell  = {0, 10, 10, 15, 15, 10, 10, 15, 15, 30, 40, 35, 35, 15, 15, 15, 15, 15, 15, 15, 15, 50, 50, 50, 50, 15, 15, 15, 15, 60, 70 };
            FindDifferentCell frmFndDiCell = new FindDifferentCell(level, "", sizeFndDiCell[level], typeFndDiCell[level], kindFndDiCell[level], scoreFndDiCell[level], timeFndDiCell[level], turnOffSound, 2);
            frmFndDiCell.trans = data;
            frmFndDiCell.ShowDialog();
        }

        // gọi ra game FndNum
        private void callFndNum(int level, bool turnOffSound)
        {
            int[] sizeFndNum = { 0, 4,  4,  4,  4,  4,  4,  5,  5,  5,  5,  5,  5,  6,  6,  6,  6,  6,  6,  7,  7,  7,  7,  7,  7,  8,  8,  8,  8,  8,   8,   8,   8   };
            int[] numFndNum =  { 0, 3,  4,  5,  6,  7,  8,  5,  7,  8,  9,  10, 11, 9,  10, 12, 13, 14, 15, 15, 16, 18, 19, 20, 22, 18, 20, 22, 24, 26,  28,  30,  40  };
            int[] timeFndNum = { 0, 13, 13, 13, 17, 17, 17, 23, 23, 25, 30, 35, 35, 40, 40, 40, 40, 45, 45, 50, 50, 55, 60, 65, 70, 70, 80, 85, 90, 100, 105, 110, 140 };

            FindNumDisplay frmFndNum = new FindNumDisplay(level, "", sizeFndNum[level], numFndNum[level], timeFndNum[level], turnOffSound, 2);
            frmFndNum.trans = data;
            frmFndNum.ShowDialog();
        }

        // gọi ra game FndSaCell
        private void callFndSaCell(int level, bool turnOffSound)
        {
            int[] heightFndSaCell =    { 0, 3,  3,  3,  3,  3,  3,  4,  4,  4,  4,  4,  4,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  7,  7,  7,  7,  7,  7  };
            int[] widthFndSaCell =     { 0, 4,  4,  4,  4,  4,  4,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6  };
            int[] scoreFndSaCell =     { 0, 4,  4,  6,  6,  8,  10, 8,  10, 10, 12, 14, 16, 16, 16, 16, 16, 16, 16, 16, 16, 18, 18, 18, 20, 20, 20, 20, 20, 22, 24 };
            int[] numChoiceFndSaCell = { 0, 10, 4,  10, 10, 14, 20, 20, 20, 16, 20, 22, 24, 28, 30, 30, 30, 28, 26, 24, 26, 30, 34, 36, 36, 40, 40, 40, 42, 44, 44 };
            int[] timeFndSaCell =      { 0, 30, 30, 30, 25, 35, 40, 30, 45, 45, 50, 50, 60, 70, 70, 50, 45, 50, 50, 40, 45, 50, 55, 60, 65, 70, 65, 60, 60, 65, 70 };

            FindSameCell frmFndSaCell = new FindSameCell(level, "", heightFndSaCell[level], widthFndSaCell[level], scoreFndSaCell[level], numChoiceFndSaCell[level], timeFndSaCell[level], turnOffSound, 2);
            frmFndSaCell.trans = data;
            frmFndSaCell.ShowDialog();
        }

        // gọi ra game OrBut
        private void callOrBut(int level, bool turnOffSound)
        {
            int[] sizeOrBut = { 0, 6,  6,  6,  6,  6,  6,  6, 6,  6,  6,  6,  6,  6, 6, 6,  6,  6,  6,  6, 6, 6,  6,  6,  6,  6, 6, 6, 6,  6,  6  };
            int[] numOrBut =  { 0, 2,  3,  4,  5,  6,  7,  3, 4,  5,  6,  7,  8,  4, 5, 6,  7,  8,  9,  5, 6, 7,  8,  9,  10, 6, 7, 8, 9,  10, 11 };
            int[] timeOrBut = { 0, 10, 10, 10, 10, 12, 14, 8, 10, 12, 14, 16, 18, 6, 8, 10, 12, 14, 16, 6, 8, 10, 12, 14, 14, 7, 8, 9, 10, 11, 12 };
            orderButton frmOrBut = new orderButton(level, "", sizeOrBut[level], numOrBut[level], timeOrBut[level], turnOffSound, 2);
            frmOrBut.trans = data;
            frmOrBut.ShowDialog();
        }
        // gọi ra game RemMe
        private void callRemMe(int level, bool turnOffSound)
        {
            int[] sizeRemMe =      { 0, 4,  4,  4,  4,  4,  4,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  5,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6,  6  };
            int[] numAnsRemMe =    { 0, 3,  4,  5,  6,  7,  8,  4,  4,  5,  5,  6,  6,  7,  7,  8,  8,  9,  9,  6,  6,  7,  7,  8,  8,  9,  9,  10, 10, 11, 11 };
            int[] numChoiceRemMe = { 0, 6,  6,  6,  8,  8,  8,  8,  8,  10, 10, 12, 12, 14, 14, 16, 16, 16, 16, 12, 12, 14, 14, 16, 16, 18, 18, 18, 18, 18, 18 };
            int[] timeRemMe =      { 0, 20, 20, 20, 20, 20, 20, 15, 15, 20, 20, 25, 25, 30, 30, 30, 25, 30, 25, 25, 25, 30, 35, 35, 30, 36, 30, 40, 36, 45, 30 };
            RememberMe frmRemMe = new RememberMe(level, "", sizeRemMe[level], numAnsRemMe[level], numChoiceRemMe[level], timeRemMe[level], turnOffSound, 2);
            frmRemMe.trans = data;
            frmRemMe.ShowDialog();
        }

        // gọi ra game follArrow
        private void callFollArrow(int level, bool turnOffSound)
        {
            int[] scoreFollArrow = { 0, 4,  5,  6,  7,  8,  9,  7,  9,  11, 13, 14, 15, 10, 14, 16, 18, 19, 20, 13, 15, 17, 19, 21, 23, 20, 22, 24, 26, 28, 30 };
            int[] timeFollArrow =  { 0, 10, 10, 10, 10, 10, 10, 15, 15, 15, 15, 15, 15, 20, 20, 20, 20, 20, 20, 25, 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30 };
      
            followArrow frmFollArrow=new followArrow(level,"",scoreFollArrow[level],timeFollArrow[level],turnOffSound,2);
            frmFollArrow.trans=data;
            frmFollArrow.ShowDialog();
        }

        // xử lí khi người chơi ấn vào các vòng của game
        private void click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            levelClick=Int16.Parse(btn.Name);
            if (levelClick <= nowLevel)
            {
                if (idGame == 1)
                {
                    wmpSoundTrack.close();
                    callCatTheWo(levelClick, turnOnOrOff);
                }
                if (idGame == 2)
                {
                    wmpSoundTrack.close();
                    callChseNum(levelClick, turnOnOrOff);
                }
                if (idGame == 3)
                {
                    wmpSoundTrack.close();
                    callFndDiCell(levelClick, turnOnOrOff);
                }
                if (idGame == 4)
                {
                    wmpSoundTrack.close();
                    callFndNum(levelClick, turnOnOrOff);   
                }
                if (idGame == 5)
                {
                    wmpSoundTrack.close();
                    callFndSaCell(levelClick, turnOnOrOff);
                }
                if (idGame == 6)
                {
                    wmpSoundTrack.close();
                    callOrBut(levelClick,turnOnOrOff);
                }
                if (idGame == 7)
                {
                    wmpSoundTrack.close();
                    callRemMe(levelClick, turnOnOrOff);
                }
                if (idGame == 8)
                {
                    wmpSoundTrack.close();
                    callFollArrow(levelClick, turnOnOrOff);
                }
            }
        }

        // đọc dữ liệu về các vòng mà người chơi đã đạt tới của mỗi game
        private void solve()
        {
            StreamReader inp = new StreamReader(@"database/frPlayMo/level.txt");
            for (int i = 1; i <= numberOfGame; i++) level[i] = inp.ReadLine();
            nowLevel = chuyenhoa(level[idGame]);

            createButton();
            createBackGround();
        }

        /* ghi vòng hiện tại của người chơi ra file txt*/
        public void data(int value)
        {
            if (turnOnOrOff == false)
            {
                try
                {
                    wmpSoundTrack.URL = @"sound/frPlayMo/freePlayModeEachGame/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }
            if (value == 1 && levelClick == nowLevel)
            {
                if (nowLevel == 30)
                    {
                        loadPictureButton(btn[5][6], "picture/frPlayMo/freePlayModeEachGame/victory.jpg");

                        playMusic("sound/frPlayMo/freePlayModeEachGame/victory.wav");

                        picMedal.Visible = true;
                        loadPicture(picMedal, "picture/frPlayMo/freePlayModeEachGame/medal.jpg");
                        
                        picFirework.Visible = true;
                        loadPicture(picFirework, "picture/frPlayMo/freePlayModeEachGame/firework.gif");         
                    }
                else
                {
                    for (int i = 1; i <= 5; i++)
                        for (int j = 1; j <= 6; j++)
                            if (btn[i][j].Name == nowLevel.ToString()) 
                                loadPictureButton(btn[i][j], "picture/frPlayMo/freePlayModeEachGame/victory.jpg");
                            else if (btn[i][j].Name == (nowLevel + 1).ToString())
                            {
                                btn[i][j].Text = ((i - 1) * 6 + j).ToString();
                                loadPictureButton(btn[i][j], "picture/frPlayMo/freePlayModeEachGame/now.jpg");
                            }
                    nowLevel += value;
                }
            }
            StreamWriter output = new StreamWriter(@"database/frPlayMo/level.txt");
            level[idGame] = mahoa(nowLevel);
            for (int i = 1; i <= numberOfGame; i++) output.WriteLine(level[i]);
            output.Close();
        }

        // tắt nhạc
        private void freePlayModeEachGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            picFirework.Visible = false;
            picMedal.Visible = false;
            try
            {
                wmpSoundTrack.close();
            }
            catch (Exception ex) { }

            try
            {
                sp.Stop();
            }
            catch (Exception ex) { }
        }
    }
}
