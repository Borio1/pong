namespace Proj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.body = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.body.BackColor = System.Drawing.Color.Lime;
            this.body.Location = new System.Drawing.Point(0, 399);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(200, 21);
            this.body.TabIndex = 0;
            this.body.TabStop = false;
            this.body.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(160, 380);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.body);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ball;
    }
}

