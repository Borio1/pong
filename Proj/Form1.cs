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

        public int ySpeed = -1;
        public int xSpeed = 0;
        public int W = 0;
        public int L = 0;
        public Boolean start;
        public Boolean ready;
        public int side = -1;
        public double speed = 1;
        public int gameActive = 0;

        void win()
        {
            start = false;
            xSpeed = 0;
            ySpeed = 0;
            W++;
            side = 1;
            ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, 140);
            opponent.Location = new Point(Form1.ActiveForm.Width/2-100, 41);
            body.Location = new Point(Form1.ActiveForm.Width / 2 - 100, 399);
        }
        void lose()
        {
            start = false;
            xSpeed = 0;
            ySpeed = 0;
            L++;
            side = -1;
            ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, 300);
            opponent.Location = new Point(Form1.ActiveForm.Width / 2 - 100, 41);
            body.Location = new Point(Form1.ActiveForm.Width / 2 - 100, 399);
        }
        void opponentMove()
        {
            if (opponent.Location.X + 100 + rnd.Next(60) < ball.Location.X)
            {
                opponent.Left += Convert.ToInt32(Math.Round(7 * speed)) * gameActive;
            }
            if (opponent.Location.X + 100 + rnd.Next(60) > ball.Location.X && opponent.Location.X > 0)
            {
                opponent.Left -= Convert.ToInt32(Math.Round(7 * speed)) * gameActive;
            }
        }
        private void startButton(object sender, EventArgs e)
        {
            gameActive = 1;

            buttonStart.Enabled = false; buttonStart.Hide();
            speedSlow.Enabled = false; speedSlow.Hide();
            speedNormal.Enabled = false; speedNormal.Hide();
            speedFast.Enabled = false; speedFast.Hide();
        }
        void pauseButton()
        {
            gameActive = 0;

            buttonStart.Enabled = true; buttonStart.Show();
            speedSlow.Enabled = true; speedSlow.Show();
            speedNormal.Enabled = true; speedNormal.Show();
            speedFast.Enabled = true; speedFast.Show();
        }
        private void speedS(object sender, EventArgs e)
        {
            speed = 0.8;
        }
        private void speedN(object sender, EventArgs e)
        {
            speed = 1;
        }
        private void speedF(object sender, EventArgs e)
        {
            speed = 1.2;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ready = true;
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
                ySpeed = 1;
                xSpeed = -2 * (ball.Location.X - body.Location.X - 100);
                if (timer1.Interval > 20 && ready)
                {
                    timer1.Interval--;
                    ready = false;
                }
            }
            if (ball.Bounds.IntersectsWith(opponent.Bounds))
            {
                ySpeed = -1;
                xSpeed = -2 * (ball.Location.X - opponent.Location.X - 100);
            }
            if (ball.Location.X <= 0)
            {
                xSpeed = -Math.Abs(xSpeed);
            }
            if (ball.Location.X + 45 >= Form1.ActiveForm.Size.Width)
            {
                xSpeed = Math.Abs(xSpeed);
            }

        }
        void ballMove()
        {
            turn();
            ball.Top -= Convert.ToInt32(Math.Round(ySpeed * 10 * speed)) * gameActive;
            ball.Left -= Convert.ToInt32(Math.Round(xSpeed / 20 * speed)) * gameActive;
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && body.Location.X >= 1)
            {
                body.Left -= 20 * gameActive;
            }
            if (e.KeyCode == Keys.Right && body.Location.X <= Form1.ActiveForm.Size.Width-220)
            {
                body.Left += 20 * gameActive;
            }
            if(e.KeyCode == Keys.Escape)
            {
                pauseButton();
            }
            if (start == false && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
            {
                start = true;
                ySpeed = side;
            }
        }
        private void ball_Click(object sender, EventArgs e)
        {
      
        }
    }
}
