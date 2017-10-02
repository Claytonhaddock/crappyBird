using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace CrappyBird
{
    public partial class Form1 : Form
    {
        bool winning = true;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (winning)
            {
                Grass1.Left -= 2;
                Grass2.Left -= 2;
                Grass3.Left -= 2;
                Grass4.Left -= 2;
                Grass5.Left -= 2;
                Grass6.Left -= 2;
                Grass7.Left -= 2;
                Grass8.Left -= 2;
                bird.Top += 2;
            }
            if (btmPipe1.Visible && topPipe1.Visible && winning)
            {
                btmPipe1.Left -= 2;
                topPipe1.Left -= 2;
            }

            if (Grass8.Left == -30)
            {
                Grass8.Left = 30;
                Grass7.Left = 90;
                Grass5.Left = 210;
                Grass4.Left = 270;
                Grass3.Left = 330;
                Grass2.Left = 390;
                Grass1.Left = 450;
                Grass6.Left = 150;

            }
            if (bird.Top == 283)
            {
                winning = false;
            }
            if (bird.Left + 30 >= btmPipe1.Left && bird.Left + 30 <= btmPipe1.Left + 40 && bird.Top + 30 >= btmPipe1.Top && bird.Top + 30 <= btmPipe1.Top + 171)
            {
                winning = false;
            }
            if (bird.Left + 30 >= topPipe1.Left && bird.Left + 30 <= topPipe1.Left + 40 && bird.Top + 30 >= topPipe1.Top && bird.Top + 30 <= topPipe1.Top+40)
            {
                winning = false;
            }
            int Score = 0;
            if (bird.Left == btmPipe1.Left)
            {
                Score++;
                scoreNumber.Text = Score.ToString();
            }
        }
        
        private void ObstacleTimer_Tick(object sender, EventArgs e)
        {
            btmPipe1.Visible = true;
            topPipe1.Visible = true;
            btmPipe1.Location= new Point(450,141);
            topPipe1.Location = new Point(450, 0);
        }

        private void fly(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && winning)
            {
                bird.Top -= 50;
                
            }
        }
    }
}
