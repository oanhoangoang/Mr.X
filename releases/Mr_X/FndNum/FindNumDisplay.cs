using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FndNum
{
    public partial class FindNumDisplay : Form
    {
        private readonly Button[][] randomBtn = new Button[50][];
        private readonly int[] randomArray = new int[1000 + 10];
        private int[] originalArray = new int[1000 + 10];
        private readonly int sizeTable;
        private int contro = 1;
        private int locationRandom;
        private int minute, second;
        private int numberToFind;
        private int your_score;

        public FindNumDisplay(int size, int num, int timeToPlay)
        {
            InitializeComponent();
            sizeTable = size;
            numberToFind = num;
            minute = timeToPlay / 60;
            second = timeToPlay % 60;
        }

        private int randomNumber(int limitLow, int limitHigh)
        {
            Random rd = new Random();
            return rd.Next(limitLow, limitHigh + 1);
        }

        private void createButtonArray()
        {
            for (var i = 0; i < sizeTable; i++) randomBtn[i] = new Button[40];
            for (var i = 0; i < sizeTable; i++)
                for (var j = 0; j < sizeTable; j++)
                {
                    randomBtn[i][j] = new Button();
                    randomBtn[i][j].Size = new Size(70, 70);
                    randomBtn[i][j].Text = (j * sizeTable + i + 1).ToString();
                    randomBtn[i][j].Location = new Point(i * 80 + 60, j * 80 + 60);
                    randomBtn[i][j].BackColor = Color.Red;
                    randomBtn[i][j].FlatStyle = FlatStyle.Flat;
                    randomBtn[i][j].ForeColor = Color.White;
                 //   randomButton[i][j].Click += btnMediate_Click;
                    Controls.Add(randomBtn[i][j]);
                    randomBtn[i][j].Enabled = false;

                    pnlGameDisplayGray.Controls.Add(randomBtn[i][j]);
                }
        }
        private void createRandomArray()
        {
            for (var i = 1; i <= sizeTable * sizeTable; i++) originalArray[i] = i;
            for (var i = 1; i <= sizeTable*sizeTable; i++)
            {
                locationRandom = randomNumber(1, sizeTable * sizeTable - i + 1);
                randomArray[i] = originalArray[locationRandom];
                originalArray[locationRandom] = originalArray[sizeTable * sizeTable - i + 1];
            }
        }


        private void FindNumDisplay_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            createButtonArray();
           // tmrTimeToPlay.Enable = true;
        }

        private void tmrTimeToPlay_Tick(object sender, EventArgs e)
        {
         //   tb1.Text = randomArray[contro].ToString();
         //   lb9.Text = your_score.ToString();
            if (minute > 0 || second > 0)
            {
                if (second == 0 && minute > 0)
                {
                    second = 60;
                    minute--;
                }
                second--;
            }
           // nud1.Value = minute;
           // nud2.Value = second;

        }

        
    }
}
