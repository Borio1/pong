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
            this.opponent = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.speedSlow = new System.Windows.Forms.Button();
            this.speedNormal = new System.Windows.Forms.Button();
            this.speedFast = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.sizeBig = new System.Windows.Forms.Button();
            this.sizeNormal = new System.Windows.Forms.Button();
            this.sizeSmall = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponent)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.body.BackColor = System.Drawing.Color.White;
            this.body.Location = new System.Drawing.Point(300, 399);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(200, 21);
            this.body.TabIndex = 0;
            this.body.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(390, 300);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // opponent
            // 
            this.opponent.BackColor = System.Drawing.Color.White;
            this.opponent.Location = new System.Drawing.Point(300, 41);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(200, 21);
            this.opponent.TabIndex = 2;
            this.opponent.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.ForeColor = System.Drawing.Color.Lime;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(41, 13);
            this.score.TabIndex = 3;
            this.score.Text = "Score: ";
            // 
            // speedSlow
            // 
            this.speedSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.speedSlow.Location = new System.Drawing.Point(12, 200);
            this.speedSlow.Name = "speedSlow";
            this.speedSlow.Size = new System.Drawing.Size(240, 40);
            this.speedSlow.TabIndex = 1;
            this.speedSlow.TabStop = false;
            this.speedSlow.Text = "Slow";
            this.speedSlow.UseVisualStyleBackColor = true;
            this.speedSlow.Click += new System.EventHandler(this.speedS);
            // 
            // speedNormal
            // 
            this.speedNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.speedNormal.Location = new System.Drawing.Point(12, 260);
            this.speedNormal.Name = "speedNormal";
            this.speedNormal.Size = new System.Drawing.Size(240, 40);
            this.speedNormal.TabIndex = 1;
            this.speedNormal.TabStop = false;
            this.speedNormal.Text = "Normal";
            this.speedNormal.UseVisualStyleBackColor = true;
            this.speedNormal.Click += new System.EventHandler(this.speedN);
            // 
            // speedFast
            // 
            this.speedFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.speedFast.Location = new System.Drawing.Point(12, 320);
            this.speedFast.Name = "speedFast";
            this.speedFast.Size = new System.Drawing.Size(240, 40);
            this.speedFast.TabIndex = 1;
            this.speedFast.TabStop = false;
            this.speedFast.Text = "Fast";
            this.speedFast.UseVisualStyleBackColor = true;
            this.speedFast.Click += new System.EventHandler(this.speedF);
            // 
            // buttonStart
            // 
            this.buttonStart.CausesValidation = false;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.buttonStart.Location = new System.Drawing.Point(275, 100);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(240, 80);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startButton);
            // 
            // sizeBig
            // 
            this.sizeBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.sizeBig.Location = new System.Drawing.Point(532, 200);
            this.sizeBig.Name = "sizeBig";
            this.sizeBig.Size = new System.Drawing.Size(240, 40);
            this.sizeBig.TabIndex = 4;
            this.sizeBig.TabStop = false;
            this.sizeBig.Text = "Big";
            this.sizeBig.UseVisualStyleBackColor = true;
            this.sizeBig.Click += new System.EventHandler(this.sizeB);
            // 
            // sizeNormal
            // 
            this.sizeNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.sizeNormal.Location = new System.Drawing.Point(532, 260);
            this.sizeNormal.Name = "sizeNormal";
            this.sizeNormal.Size = new System.Drawing.Size(240, 40);
            this.sizeNormal.TabIndex = 5;
            this.sizeNormal.TabStop = false;
            this.sizeNormal.Text = "Normal";
            this.sizeNormal.UseVisualStyleBackColor = true;
            this.sizeNormal.Click += new System.EventHandler(this.sizeN);
            // 
            // sizeSmall
            // 
            this.sizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.sizeSmall.Location = new System.Drawing.Point(532, 320);
            this.sizeSmall.Name = "sizeSmall";
            this.sizeSmall.Size = new System.Drawing.Size(240, 40);
            this.sizeSmall.TabIndex = 6;
            this.sizeSmall.TabStop = false;
            this.sizeSmall.Text = "Small";
            this.sizeSmall.UseVisualStyleBackColor = true;
            this.sizeSmall.Click += new System.EventHandler(this.sizeS);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Lime;
            this.label.Location = new System.Drawing.Point(610, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(162, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Press \'Escape\' to open the menu";
            this.label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sizeSmall);
            this.Controls.Add(this.sizeNormal);
            this.Controls.Add(this.sizeBig);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.speedFast);
            this.Controls.Add(this.speedNormal);
            this.Controls.Add(this.speedSlow);
            this.Controls.Add(this.score);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.body);
            this.Name = "Form1";
            this.Text = "v";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox opponent;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button speedSlow;
        private System.Windows.Forms.Button speedNormal;
        private System.Windows.Forms.Button speedFast;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button sizeBig;
        private System.Windows.Forms.Button sizeNormal;
        private System.Windows.Forms.Button sizeSmall;
        private System.Windows.Forms.Label label;
    }
}

