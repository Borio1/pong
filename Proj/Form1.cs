using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Random rnd = new Random();

        public int ySpeed = -1;
        public int xSpeed = 0;
        public int W = 0;
        public int L = 0;
        public Boolean start;
        public Boolean ready;
        public int side = -1;
        public double speed = 1;
        public int gameActive = 0;
        public int size = 0;
        public double widthMulti = 1;
        public double heightMulti = 1;
        public Boolean moveLeft;
        public Boolean moveRight;
        public Boolean ballOwned = true;
        void win()
        {
            start = false; label.Show();
            xSpeed = rnd.Next(-100, 100);
            ySpeed = 0;
            W++;
            side = 1;
            timer1.Interval = 40;
            ballOwned = false;
            ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, 140);
            opponent.Location = new Point(Form1.ActiveForm.Width/2 - 100, 41);
            body.Location = new Point(Form1.ActiveForm.Width / 2 - 100 - 20 * size, Form1.ActiveForm.Height - 110);
        }
        void lose()
        {
            start = false; label.Show();
            xSpeed = 0;
            ySpeed = 0;
            L++;
            side = -1;
            timer1.Interval = 40;
            ballOwned = true;
            ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, Convert.ToInt32(Math.Round(body.Location.Y - 99 - 0 * (heightMulti - 1))));
            opponent.Location = new Point(Form1.ActiveForm.Width / 2 - 100, 41);
            body.Location = new Point(Form1.ActiveForm.Width / 2 - 100 - 20 * size, Form1.ActiveForm.Height - 110);
        }
        void opponentMove()
        {
            if (opponent.Location.X + 100 + rnd.Next(60) < ball.Location.X && (ball.Location.X > opponent.Location.X + 130 || xSpeed > 0))
            {
                opponent.Left += Convert.ToInt32(Math.Round(7 * speed * (1.0 / (heightMulti / 8.0 + 0.875)) * (widthMulti / 1.5 + 0.6667))) * gameActive;
            }
            if (opponent.Location.X + 100 + rnd.Next(60) > ball.Location.X && (ball.Location.X < opponent.Location.X + 70  || xSpeed > 0) && opponent.Location.X > 0)
            {
                opponent.Left -= Convert.ToInt32(Math.Round(7 * speed * (1.0 / (heightMulti / 8.0 + 0.875)) * (widthMulti / 1.5 + 0.6667))) * gameActive;
            }
        }
        private void startButton(object sender, EventArgs e)
        {
            gameActive = 1;
            label.Show();

            buttonStart.Enabled = false; buttonStart.Hide();
            speedSlow.Enabled = false; speedSlow.Hide();
            speedNormal.Enabled = false; speedNormal.Hide();
            speedFast.Enabled = false; speedFast.Hide();
            sizeSmall.Enabled = false; sizeSmall.Hide();
            sizeNormal.Enabled = false; sizeNormal.Hide();
            sizeBig.Enabled = false; sizeBig.Hide();
        }
        void pauseButton()
        {
            if(!start)
            {
                label.Hide();
                gameActive = 0;

                buttonStart.Enabled = true; buttonStart.Show();
                speedSlow.Enabled = true; speedSlow.Show();
                speedNormal.Enabled = true; speedNormal.Show();
                speedFast.Enabled = true; speedFast.Show();
                sizeSmall.Enabled = true; sizeSmall.Show();
                sizeNormal.Enabled = true; sizeNormal.Show();
                sizeBig.Enabled = true; sizeBig.Show();
            }
            
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
        private void sizeS(object sender, EventArgs e)
        {
            body.Width = 160;
            if (size == 0)
            {
                body.Left += 20;
            }
            if (size == 1)
            {
                body.Left += 40;
            }
            size = -1;
        }
        private void sizeN(object sender, EventArgs e)
        {
            body.Width = 200;
            if(size == -1)
            {
                body.Left -= 20;
            }
            if(size == 1)
            {
                body.Left += 20;
            }
            size = 0;
        }
        private void sizeB(object sender, EventArgs e)
        {
            body.Width = 240;
            if (size == -1)
            {
                body.Left -= 40;
            }
            if (size == 0)
            {
                body.Left -= 20;
            }
            size = 1;
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
                xSpeed = Convert.ToInt32(Math.Round( -2 * (ball.Location.X - body.Location.X - (90 + 20 * size)) * (1 - size * 0.2)));
                if (timer1.Interval > 20 && ready)
                {
                    timer1.Interval--;
                    ready = false;
                }
            }
            if (ball.Bounds.IntersectsWith(opponent.Bounds))
            {
                ySpeed = -1;
                xSpeed = -2 * (ball.Location.X - opponent.Location.X - 90);
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
            ball.Top -= Convert.ToInt32(Math.Round(ySpeed * 10 * speed * heightMulti)) * gameActive;
            ball.Left -= Convert.ToInt32(Math.Round(xSpeed / 17 * speed * (widthMulti / 3.0 + 0.6667))) * gameActive;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && body.Location.X >= 1)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right && body.Location.X <= Form1.ActiveForm.Size.Width - 221 - 40 * size)
            {
                moveRight = true;
            }
            if(e.KeyCode == Keys.Escape)
            {
                pauseButton();
            }
            if (start == false && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
            {
                start = true; label.Hide();
                ySpeed = side;
            }
            
        }
        private void setup(object sender, EventArgs e)
        {
            if (start)
            {
                start = false; pauseButton(); L++; startButton(sender, e);
            }

            widthMulti = Form1.ActiveForm.Width / 800.0;
            heightMulti = Form1.ActiveForm.Height / 500.0;
            if(ballOwned)
            {
                ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, body.Location.Y - 99);
            }
            else
            {
                ball.Location = new Point(Form1.ActiveForm.Width / 2 - 10, opponent.Location.Y + 119);
            }
            label.Location = new Point(Form1.ActiveForm.Width - 190, 9);
            opponent.Location = new Point(Form1.ActiveForm.Width / 2 - 100, 41);
            body.Location = new Point(Form1.ActiveForm.Width / 2 - 100 - 20 * size, Form1.ActiveForm.Height - 101);
            buttonStart.Location = new Point(Form1.ActiveForm.Width / 2 - 120, Form1.ActiveForm.Height / 5 + 40);
            speedSlow.Location = new Point(buttonStart.Left - 265, buttonStart.Top + 100);
            speedNormal.Location = new Point(buttonStart.Left - 265, buttonStart.Top + 160);
            speedFast.Location = new Point(buttonStart.Left - 265, buttonStart.Top + 220);
            sizeSmall.Location = new Point(buttonStart.Left + 257, buttonStart.Top + 220);
            sizeNormal.Location = new Point(buttonStart.Left + 257, buttonStart.Top + 160);
            sizeBig.Location = new Point(buttonStart.Left + 257, buttonStart.Top + 100);
        }

        private void timer3_Tick(object sender, EventArgs e)
        { 
            if(moveLeft && body.Location.X >= 1)
            {
                body.Left -= Convert.ToInt32(Math.Floor(5 * gameActive * (widthMulti / 2.0) + 0.5));
            }
            if(moveRight && body.Location.X <= Form1.ActiveForm.Size.Width - 218 - 40 * size)
            {
                body.Left += Convert.ToInt32(Math.Floor(5 * gameActive * (widthMulti / 2.0) + 0.5));
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }
    }
}
