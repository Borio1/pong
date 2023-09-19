using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int y = 1;
        int x = 1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballMove();
        }

        void turn()
        {
            if(ball.Bounds.IntersectsWith(body.Bounds))
            {
                y = 1;
                x = -2 * (ball.Location.X - body.Location.X - 100);
            }
            if (ball.Location.Y <= 0)
            {
                y = -1;
            }
            if (ball.Location.X <= 0)
            {
                x = -Math.Abs(x);
            }
            if (ball.Location.X+40 >= Form1.ActiveForm.Size.Width)
            {
                x = Math.Abs(x);
            }

        }
        void ballMove()
        {
            turn();
            ball.Top -= y * 20;
            ball.Left -= x/10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                body.Left -= 20;
            }
            if (e.KeyCode == Keys.Right)
            {
                body.Left += 20;
            }
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
