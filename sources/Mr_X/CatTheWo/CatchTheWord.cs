using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CatTheWo
{
    public partial class CatchTheWord : Form
    {
        // điểm qua vòng
        private int scoreToPass;

        // số vòng chơi
        private int numberOfRound;

        // thời gian chơi, tính bằng phút
        private int minute;

        //thời gian chơi, tính bằng giây
        private int second;

        // số điểm của người chơi
        private int yourScore;

        // vòng hiện tại
        private int nowRound;

        // hiện các chữ cái của đáp án
        private Button[][] cellOfAnswer = new Button[100000 + 10][];

        // bàn phím bấm cho người chơi
        private Button[][] keyboard = new Button[20 + 10][];

        // số lỗi người chơi mỗi vòng
        private int mistake;

        // số dòng trong datase, số lượng ảnh có thể sử dụng
        private int size = 994;

        // vị trí câu hỏi, nằm trong khoảng từ 1->size
        private int posQuestion;

        // link dẫn đến hình ảnh thứ posQuestion 
        private string directory;

        // arrayAnswer[i]= đáp án hình ảnh thứ i, các phần tử đánh số từ 1->size
        private string[] arrayAnswer=new string[2000+10];

        // câu trả lời của vòng hiện tại, lấy dữ liệu từ arrayAnswer
        private string answerNow;

        // đếm số lượng chữ cái xuất hiện trong câu trả lời của vòng hiện tại (answerNow)
        private int numberOfAlphabet;
        
        // tính số lượng chữ của đáp án giống với ô mà người chơi nhấn
        private int cal;

        // số ô mà người chơi đã mở ở vòng hiện tại
        private int cellOnNowRound;

        // lấy các giá trị: số điểm qua vòng,số vòng chơi, thời gian gian
        public CatchTheWord(int score, int round, int time)
        {
            InitializeComponent();

            scoreToPass = score;
            numberOfRound = round;
            minute = time / 60;
            second = time % 60;

            StreamReader read = File.OpenText(@"database/CatTheWo/answer.txt");
            for (int i = 1; i <= size; i++) arrayAnswer[i] = read.ReadLine();

            try
            {
                picMc.Image = Image.FromFile(@"picture/CatTheWo/mc.jpg");
                picMc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex) { }

            try
            {
                picGameDisplay.Image = Image.FromFile(@"picture/CatTheWo/gameDisplay.jpg");
                picGameDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex) { }

            try
            {
                wmpSoundTrack.URL = @"sound/CatTheWo/soundTrack.mp3";
            }
            catch (Exception ex) { }
        }

        // lấy ngẫu nhiên một số trong khoảng từ limitLow tới limitHigh
        private int randomNumber(int limitLow, int limitHigh)
        {
            Random rd = new Random();
            return rd.Next(limitLow, limitHigh + 1);
        }

        // làm chậm thời gian đi x milisecond
        private void timeDelay(int x)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(x);
            });
            t.Wait();
        }

        // bắt đầu chơi game: bắt đầu đếm thời gian, tạo bàn phím để nhấn và tạo câu hỏi
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            tmrTimeToPlay.Enabled = true;
            yourScore = 0;
            nowRound = 0;
            createKeyboard();
            newquestion();
            btnSkip.Visible = true;
        }

        // tạo bàn phím để người chơi nhấn
        private void createKeyboard(){
            for (int i = 1; i <= 3; i++) keyboard[i] = new Button[30];

            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 10; j++)
                {
                    keyboard[i][j] = new Button();
                    keyboard[i][j].Size = new Size(25, 29);
                    keyboard[i][j].Location = new Point( (j-1)*52+10,(i-1)*42+520);

                    keyboard[i][j].FlatStyle = FlatStyle.Flat;
                    keyboard[i][j].ForeColor = ColorTranslator.FromHtml("#F2784B");
                    keyboard[i][j].Click += new EventHandler(btnMediate_Click);
                    Controls.Add(keyboard[i][j]);
                    pnlGameDisplayGray.Controls.Add(keyboard[i][j]);
                }

            keyboard[1][1].Text = "A";
            keyboard[1][2].Text = "Ă";
            keyboard[1][3].Text = "Â";
            keyboard[1][4].Text = "B";
            keyboard[1][5].Text = "C";
            keyboard[1][6].Text = "D";
            keyboard[1][7].Text = "Đ";
            keyboard[1][8].Text = "E";
            keyboard[1][9].Text = "Ê";
            keyboard[1][10].Text = "G";

            keyboard[2][1].Text = "H";
            keyboard[2][2].Text = "I";
            keyboard[2][3].Text = "K";
            keyboard[2][4].Text = "L";
            keyboard[2][5].Text = "M";
            keyboard[2][6].Text = "N";
            keyboard[2][7].Text = "O"; 
            keyboard[2][8].Text = "Ô";
            keyboard[2][9].Text = "Ơ";
            keyboard[2][10].Text = "P";

            keyboard[3][1].Text = "Q";
            keyboard[3][2].Text = "R";
            keyboard[3][3].Text = "S";
            keyboard[3][4].Text = "T";
            keyboard[3][5].Text = "U";
            keyboard[3][6].Text = "Ư";
            keyboard[3][7].Text = "V";
            keyboard[3][8].Text = "X";
            keyboard[3][9].Text = "Y";

            keyboard[3][10].Visible = false;
        }

        // tạo các chữ cái của đáp án, dưới dạng các button
        private void createCellOfAnswer()
        {
            cellOfAnswer[nowRound] = new Button[20];
            for (int i = 0; i < answerNow.Length; i++)
                if (answerNow[i] != ' ')
                {
                    cellOfAnswer[nowRound][i] = new Button();
                    cellOfAnswer[nowRound][i].Size = new Size(25, 29);
                    cellOfAnswer[nowRound][i].Location = new Point(i * 27 + 10, 405);

                    cellOfAnswer[nowRound][i].FlatStyle = FlatStyle.Flat;
                    cellOfAnswer[nowRound][i].Enabled = false;
                    cellOfAnswer[nowRound][i].ForeColor = ColorTranslator.FromHtml("#F2784B");
                    Controls.Add(cellOfAnswer[nowRound][i]);
                    pnlGameDisplayGray.Controls.Add(cellOfAnswer[nowRound][i]);
                }
        }

        // tạo câu hỏi mới: tạo mới các chữ cái của đáp án
        private void newquestion()
        {
            if (nowRound>0)
            for (int i = 0; i < answerNow.Length; i++)
                if (answerNow[i] != ' ') cellOfAnswer[nowRound][i].Visible = false;        

            cellOnNowRound = 0;
            nowRound++;
            txtRound.Text = "Vòng " + nowRound.ToString();
            txtAnswer.Text = "";
            mistake = 0;
            posQuestion = randomNumber(1, size);
            try
            {
                picGameDisplay.Image = null;
                directory = @"picture/CatTheWo/" + posQuestion.ToString() + ".jpg";
                picGameDisplay.Image = Image.FromFile(directory);
                picGameDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex) { }

            try
            {
                picTalk.Image = Image.FromFile(@"picture/CatTheWo/hint.jpg");
                picTalk.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex) { }
            numberOfAlphabet = 0;
            answerNow = arrayAnswer[posQuestion];
            for (int i = 0; i < answerNow.Length; i++)
                if (answerNow[i] != ' ') numberOfAlphabet++;
            
            lblHint.Visible = true;
            lblHint.Text = numberOfAlphabet.ToString() + " chữ cái.";

            createCellOfAnswer();
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 10; j++)
                    if (keyboard[i][j].Visible == true )
                    if (keyboard[i][j].Enabled == false) keyboard[i][j].Enabled = true;

        }

        // bắt đầu đếm ngược thời gian chơi
        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
            txtScore.Text = yourScore.ToString();
            txtScoreToPass.Text = scoreToPass.ToString();
            txtNumberOfRound.Text = numberOfRound.ToString();

            nudMinute.Value = minute;
            nudSecond.Value = second;
            if ( (minute > 0 || second > 0) && nowRound<=numberOfRound )
            {
                if (second == 0 && minute > 0)
                {
                    minute--;
                    second = 60;
                }
                second--;
            }
            else
            {
                tmrTimeToPlay.Stop();
                answer();
            }
        }
        // xử lí khi người chơi nhấn bỏ qua câu hỏi: hiện đáp án, làm chậm thời gian và tạo mới câu hỏi
        private void btnSkip_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "Đáp án : " + answerNow;
            timeDelay(1000);
            newquestion();
        }

        // kiểm tra xem hai kí tự có dấu và không dấu có khớp hay không
        private bool check(int x, int y)
        {
            if (x == (int)'A')
            if (y == (int)'À' || y == (int)'Á' || y == (int)'Ã' || y == (int)'Ạ' || y == (int)'Ả' ) return true;

            if (x == (int)'Ă')
            if (y == (int)'Ằ' || y == (int)'Ắ' || y == (int)'Ẵ' || y == (int)'Ặ' || y == (int)'Ẳ' ) return true;

            if (x == (int)'Â')
            if (y == (int)'Ầ' || y == (int)'Ấ' || y == (int)'Ẫ' || y == (int)'Ậ' || y == (int)'Ẩ' ) return true;

            if (x == (int)'E')
            if (y == (int)'È' || y == (int)'É' || y == (int)'Ẽ' || y == (int)'Ẹ' || y == (int)'Ẻ' ) return true;

            if (x == (int)'Ê')
            if (y == (int)'Ề' || y == (int)'Ế' || y == (int)'Ễ' || y == (int)'Ệ' || y == (int)'Ể' ) return true;

            if (x == (int)'I')
            if (y == (int)'Ì' || y == (int)'Í' || y == (int)'Ĩ' || y == (int)'Ị' || y == (int)'Ỉ') return true;

            if (x == (int)'O')
            if (y == (int)'Ò' || y == (int)'Ó' || y == (int)'Õ' || y == (int)'Ọ' || y == (int)'Ỏ') return true;

            if (x == (int)'Ô')
            if (y == (int)'Ồ' || y == (int)'Ố' || y == (int)'Ỗ' || y == (int)'Ộ' || y == (int)'Ổ') return true;

            if (x == (int)'Ơ')
            if (y == (int)'Ờ' || y == (int)'Ớ' || y == (int)'Ỡ' || y == (int)'Ợ' || y == (int)'Ở') return true;

            if (x == (int)'U')
            if (y == (int)'Ù' || y == (int)'Ú' || y == (int)'Ũ' || y == (int)'Ụ' || y == (int)'Ủ') return true;

            if (x == (int)'Ư')
            if (y == (int)'Ừ' || y == (int)'Ứ' || y == (int)'Ữ' || y == (int)'Ự' || y == (int)'Ử' ) return true;


            if (x == (int)'Y')
            if (y == (int)'Ỳ' || y == (int)'Ý' || y == (int)'Ỹ' || y == (int)'Ỵ' || y == (int)'Ỷ') return true;
            
            if ((int)x == (int)y) return true;
            return false;
        }

        // xử lí khi người chơi nhấn vào bàn phím
        private void btnMediate_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"sound/CatTheWo/click.wav");
            sp.Play();

            timeDelay(200);

            Button btnMedia=(Button)sender;
           
            cal = 0;
            for (int i = 0; i < answerNow.Length; i++)
                if (answerNow[i] != ' ')
                    if (check( (int) btnMedia.Text[0], (int) answerNow[i] )==true) {
                        cal++;
                        cellOnNowRound++;
                        cellOfAnswer[nowRound][i].Text=btnMedia.Text;

                        SoundPlayer sphappy = new SoundPlayer(@"sound/CatTheWo/happy.wav");
                        sphappy.Play();

                        timeDelay(200);
                    }
            if (cal == 0)
            {
                SoundPlayer spsad = new SoundPlayer(@"sound/CatTheWo/sad.wav");
                spsad.Play();
                mistake++;
                timeDelay(200);
            }
            else
            {
                btnMedia.Enabled = false; 
                if (cellOnNowRound == numberOfAlphabet)
                {
                    SoundPlayer spPassRound = new SoundPlayer(@"sound/CatTheWo/passRound.wav");
                    spPassRound.Play();
                    picTalk.Image = Image.FromFile(@"picture/CatTheWo/talk.jpg");
                    picTalk.SizeMode = PictureBoxSizeMode.StretchImage;
                    lblHint.Visible = false;
                    yourScore++;
                    timeDelay(1300);
                    newquestion();
                }
            }

            if (mistake == 5)
            {
                txtAnswer.Text = "Đáp án : " + answerNow;
                timeDelay(800);
                newquestion();
            }
        }

        // trả về kết quả người chơi
        private void answer()
        {
            btnSkip.Enabled = false;
            txtAnswer.Text = "Đáp án : " + answerNow;
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 10; j++) keyboard[i][j].Enabled = false;
  
            if (yourScore >= scoreToPass)
            {
                MessageBox.Show("Chúc mừng bạn đã vượt qua thử thách này", "Thông báo");
            }
            else
            {
                MessageBox.Show("Rất tiếc bạn đã không vượt qua thử thách này. Chúc may mắn", "Thông báo");
            }
        }

        // tắt nhạc khi đóng chương trình
        private void CatchTheWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmpSoundTrack.close();
        }

        //tắt game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
