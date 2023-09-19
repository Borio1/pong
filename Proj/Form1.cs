using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        public int y = -1;
        public int x = 0;
        public int W = 0;
        public int L = 0;
        Boolean start;
        public int side = -1;

        void win()
        {
            start = false;
            x = 0;
            y = 0;
            W++;
            side = 1;
            ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, 140);
            opponent.Location = new Point(Form1.ActiveForm.Width/2-100, 41);
        }
        void lose()
        {
            start = false;
            x = 0;
            y = 0;
            L++;
            side = -1;
            ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, 300);
            opponent.Location = new Point(Form1.ActiveForm.Width / 2 - 100, 41);
        }
        void opponentMove()
        {
            if (opponent.Location.X + 100 + rnd.Next(60) < ball.Location.X)
            {
                opponent.Left += 15;
            }
            if (opponent.Location.X + 100 + rnd.Next(60) > ball.Location.X && opponent.Location.X > 0)
            {
                opponent.Left -= 15;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score.Text = "Score: " + W + "/" + L;
            if (start)
            {
                ballMove();
                opponentMove();
                if (ball.Location.Y < -50)
                {
                    win();
                }
                if (ball.Location.Y > Form1.ActiveForm.Height)
                {
                    lose();
                }
            }
            
        }

        void turn()
        {
            if (ball.Bounds.IntersectsWith(body.Bounds))
            {
                y = 1;
                x = -2 * (ball.Location.X - body.Location.X - 100);
            }
            if (ball.Bounds.IntersectsWith(opponent.Bounds))
            {
                y = -1;
                x = -2 * (ball.Location.X - opponent.Location.X - 100);
            }
            if (ball.Location.X <= 0)
            {
                x = -Math.Abs(x);
            }
            if (ball.Location.X + 45 >= Form1.ActiveForm.Size.Width)
            {
                x = Math.Abs(x);
            }

        }
        void ballMove()
        {
            turn();
            ball.Top -= y * 20;
            ball.Left -= x / 10;
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && body.Location.X >= 1)
            {
                body.Left -= 20;
            }
            if (e.KeyCode == Keys.Right && body.Location.X <= Form1.ActiveForm.Size.Width-220)
            {
                body.Left += 20;
            }
            if (e.KeyCode == Keys.Space)
            {
                start = true;
                y = side;
            }
        }
        private void ball_Click(object sender, EventArgs e)
        {
      
        }

        private void score_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
