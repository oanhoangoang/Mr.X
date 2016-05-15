using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frPlayMo
{
    public partial class freePlayMode : Form
    {
        // thứ thự của game người chơi chọn, đánh số từ 1 tới 8
        private int id;

        // tên game người chơi chọn
        private string name;

        // bật hay tắt nhạc
        private bool turnOnOrOff;

        // làm mất nền của label
        private void transBackground(Label lbl)
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
        }

        // hiển bảng game để người chơi chọn
        public freePlayMode(bool turnOffSound)
        {
            InitializeComponent();
            turnOnOrOff = turnOffSound;
            if (turnOffSound == false)
            {
                try
                {
                    wmpSoundTrack.URL = @"sound/frPlayMo/freePlayMode/soundTrack.mp3";
                }
                catch (Exception ex) { }
            }

            loadPicture(picBackGround,"picture/frPlayMo/freePlayMode/background.jpg");
            loadPicture(picCatTheWo, "picture/frPlayMo/freePlayMode/catTheWo.jpg");
            loadPicture(picChseNum, "picture/frPlayMo/freePlayMode/chseNum.jpg");
            loadPicture(picFndDiCell, "picture/frPlayMo/freePlayMode/fndDiCell.jpg");
            loadPicture(picFndNum, "picture/frPlayMo/freePlayMode/fndNum.jpg");
            loadPicture(picFndSaCell, "picture/frPlayMo/freePlayMode/fndSaCell.jpg");
            loadPicture(picOrBut, "picture/frPlayMo/freePlayMode/orBut.jpg");
            loadPicture(picRemMe, "picture/frPlayMo/freePlayMode/remMe.jpg");
            loadPicture(picFollArrow, "picture/frPlayMo/freePlayMode/follArrow.jpg");

            transBackground(lblCatTheWo);
            transBackground(lblChseNum);
            transBackground(lblFndDiCell);
            transBackground(lblFndNum);
            transBackground(lblFndSaCell);
            transBackground(lblOrBut);
            transBackground(lblRemMe);
            transBackground(lblFollArrow);
        }

        // xử lí khi người chơi ấn vào game
        private void pic_Click(object sender, EventArgs e)
        {
            try
            {
                wmpSoundTrack.close();
            }
            catch (Exception ex) { }
            PictureBox Mediate = (PictureBox)sender;
            if (Mediate.Name == "picCatTheWo") 
            { 
                id = 1;
                name = "Đuổi hình bắt chữ";
            }
            if (Mediate.Name == "picChseNum")
            {
                id = 2;
                name = "Chọn số";
            }
            if (Mediate.Name == "picFndDiCell") { 
                id = 3;
                name = "Tìm ô khác biệt";
            }
            if (Mediate.Name == "picFndNum")
            {
                id = 4;
                name = "Tìm số";
            }
            if (Mediate.Name == "picFndSaCell")
            {
                id = 5;
                name = "Chọn ô giống nhau";
            }
            if (Mediate.Name == "picOrBut")
            {
                id = 6;
                name = "Chọn theo thứ tự";
            }
            if (Mediate.Name == "picRemMe")
            {
                id = 7;
                name = "Ghi nhớ";
            }
            if (Mediate.Name == "picFollArrow")
            {
                id = 8;
                name = "Nhảy cùng Doraemon";
            }

            freePlayModeEachGame fm = new freePlayModeEachGame(id, name, turnOnOrOff);
            fm.ShowDialog();
        }

        // tắt nhạc
        private void freePlayMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                wmpSoundTrack.close();
            }
            catch (Exception ex) { }
        }
    }
}
