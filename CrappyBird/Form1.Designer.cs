namespace CrappyBird
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grass8 = new System.Windows.Forms.Panel();
            this.Grass7 = new System.Windows.Forms.Panel();
            this.Grass6 = new System.Windows.Forms.Panel();
            this.Grass5 = new System.Windows.Forms.Panel();
            this.Grass4 = new System.Windows.Forms.Panel();
            this.Grass3 = new System.Windows.Forms.Panel();
            this.Grass2 = new System.Windows.Forms.Panel();
            this.Grass1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ObstacleTimer = new System.Windows.Forms.Timer(this.components);
            this.btmPipe1 = new System.Windows.Forms.Panel();
            this.topPipe1 = new System.Windows.Forms.Panel();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scoreNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Grass8);
            this.panel1.Controls.Add(this.Grass7);
            this.panel1.Controls.Add(this.Grass6);
            this.panel1.Controls.Add(this.Grass5);
            this.panel1.Controls.Add(this.Grass4);
            this.panel1.Controls.Add(this.Grass3);
            this.panel1.Controls.Add(this.Grass2);
            this.panel1.Controls.Add(this.Grass1);
            this.panel1.Location = new System.Drawing.Point(-3, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 13);
            this.panel2.TabIndex = 2;
            // 
            // Grass8
            // 
            this.Grass8.BackColor = System.Drawing.Color.Green;
            this.Grass8.Location = new System.Drawing.Point(0, 0);
            this.Grass8.Name = "Grass8";
            this.Grass8.Size = new System.Drawing.Size(30, 30);
            this.Grass8.TabIndex = 1;
            // 
            // Grass7
            // 
            this.Grass7.BackColor = System.Drawing.Color.Green;
            this.Grass7.Location = new System.Drawing.Point(60, 0);
            this.Grass7.Name = "Grass7";
            this.Grass7.Size = new System.Drawing.Size(30, 30);
            this.Grass7.TabIndex = 1;
            // 
            // Grass6
            // 
            this.Grass6.BackColor = System.Drawing.Color.Green;
            this.Grass6.Location = new System.Drawing.Point(120, 0);
            this.Grass6.Name = "Grass6";
            this.Grass6.Size = new System.Drawing.Size(30, 30);
            this.Grass6.TabIndex = 1;
            // 
            // Grass5
            // 
            this.Grass5.BackColor = System.Drawing.Color.Green;
            this.Grass5.Location = new System.Drawing.Point(180, 0);
            this.Grass5.Name = "Grass5";
            this.Grass5.Size = new System.Drawing.Size(30, 30);
            this.Grass5.TabIndex = 1;
            // 
            // Grass4
            // 
            this.Grass4.BackColor = System.Drawing.Color.Green;
            this.Grass4.Location = new System.Drawing.Point(240, 0);
            this.Grass4.Name = "Grass4";
            this.Grass4.Size = new System.Drawing.Size(30, 30);
            this.Grass4.TabIndex = 1;
            // 
            // Grass3
            // 
            this.Grass3.BackColor = System.Drawing.Color.Green;
            this.Grass3.Location = new System.Drawing.Point(300, 0);
            this.Grass3.Name = "Grass3";
            this.Grass3.Size = new System.Drawing.Size(30, 30);
            this.Grass3.TabIndex = 1;
            // 
            // Grass2
            // 
            this.Grass2.BackColor = System.Drawing.Color.Green;
            this.Grass2.Location = new System.Drawing.Point(360, 0);
            this.Grass2.Name = "Grass2";
            this.Grass2.Size = new System.Drawing.Size(30, 30);
            this.Grass2.TabIndex = 1;
            // 
            // Grass1
            // 
            this.Grass1.BackColor = System.Drawing.Color.Green;
            this.Grass1.Location = new System.Drawing.Point(420, 0);
            this.Grass1.Name = "Grass1";
            this.Grass1.Size = new System.Drawing.Size(30, 30);
            this.Grass1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // ObstacleTimer
            // 
            this.ObstacleTimer.Enabled = true;
            this.ObstacleTimer.Interval = 4000;
            this.ObstacleTimer.Tick += new System.EventHandler(this.ObstacleTimer_Tick);
            // 
            // btmPipe1
            // 
            this.btmPipe1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btmPipe1.Location = new System.Drawing.Point(450, 144);
            this.btmPipe1.Name = "btmPipe1";
            this.btmPipe1.Size = new System.Drawing.Size(40, 171);
            this.btmPipe1.TabIndex = 2;
            this.btmPipe1.Visible = false;
            // 
            // topPipe1
            // 
            this.topPipe1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.topPipe1.Location = new System.Drawing.Point(450, 0);
            this.topPipe1.Name = "topPipe1";
            this.topPipe1.Size = new System.Drawing.Size(40, 40);
            this.topPipe1.TabIndex = 3;
            this.topPipe1.Visible = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Red;
            this.bird.Location = new System.Drawing.Point(38, 69);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(30, 30);
            this.bird.TabIndex = 4;
            this.bird.TabStop = false;
            // 
            // scoreNumber
            // 
            this.scoreNumber.AutoSize = true;
            this.scoreNumber.Location = new System.Drawing.Point(57, 9);
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(13, 13);
            this.scoreNumber.TabIndex = 5;
            this.scoreNumber.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(447, 342);
            this.Controls.Add(this.scoreNumber);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.topPipe1);
            this.Controls.Add(this.btmPipe1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fly);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Grass8;
        private System.Windows.Forms.Panel Grass7;
        private System.Windows.Forms.Panel Grass6;
        private System.Windows.Forms.Panel Grass5;
        private System.Windows.Forms.Panel Grass4;
        private System.Windows.Forms.Panel Grass3;
        private System.Windows.Forms.Panel Grass2;
        private System.Windows.Forms.Panel Grass1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer ObstacleTimer;
        private System.Windows.Forms.Panel btmPipe1;
        private System.Windows.Forms.Panel topPipe1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label scoreNumber;
    }
}

