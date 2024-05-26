using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tik_Tak_Toe.Properties;

namespace Tik_Tak_Toe
{
    public partial class Form1 : Form
    {
        bool IsX = true;
        public void ChangeText()
        {
            if (IsX)
            {
                texPlayer.Text = "Player1";
            }
            else
            {
                texPlayer.Text = "Player2";
            }
        }
       public void ChangeImage(PictureBox PicChoice)
        {
            if (IsX)
            {
                PicChoice.Image = Resources.X;
                IsX = false;
                PicChoice.Tag = "X";
            }
            else
            {
                PicChoice.Image = Resources.O;
                IsX = true;
                PicChoice.Tag = "O";
            }
            TheWiner();
            ChangeText();
            PicChoice.Enabled = false;
        }
        public bool CheckWinner(PictureBox Box1, PictureBox Box2, PictureBox Box3)
        {
            if (Box1.Tag.ToString()!="?"&& Box1.Tag.ToString()== Box2.Tag.ToString()&&Box1.Tag.ToString()== Box3.Tag.ToString())
            {
                Box1.BackColor = Color.GreenYellow;
                Box2.BackColor = Color.GreenYellow;
                Box3.BackColor = Color.GreenYellow;
                texWinner.Text = IsX ? "Player1" : "Player2";
                groupBox1.Enabled = false;
                return true;
            }
            return false;     
        }
        public void TheWiner()
        {
            if (CheckWinner(pk1, pk2, pk3))
                return;
            if (CheckWinner(pk4, pk5, pk6))
                return;
            if (CheckWinner(pk7, pk8, pk9))
                return;
            if (CheckWinner(pk1, pk4, pk7))
                return;
            if (CheckWinner(pk2, pk5, pk8))
                return;
            if (CheckWinner(pk3, pk6, pk9))
                return;
            if (CheckWinner(pk1, pk5, pk9))
                return;
            if (CheckWinner(pk3, pk5, pk7))
                return;
        }
        public void RestartButton(PictureBox Box)
        {
            Box.Enabled = true;
            Box.Tag = "?";
            Box.BackColor = Color.Transparent;
            Box.Image = Resources.question_mark_96;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void pk_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 400, 100, 400, 500);
            e.Graphics.DrawLine(pen, 600, 100, 600, 500);
            e.Graphics.DrawLine(pen, 220, 230, 800, 230);
            e.Graphics.DrawLine(pen, 220, 380, 800, 380);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            texPlayer.Text = "No One";
            texWinner.Text = "No One";
            groupBox1.Enabled = true;

            RestartButton(pk1);
            RestartButton(pk2);
            RestartButton(pk3);
            RestartButton(pk4);
            RestartButton(pk5);
            RestartButton(pk6);
            RestartButton(pk7);
            RestartButton(pk8);
            RestartButton(pk9);
        }
    }
}
