using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        bool goleft;
        bool goright;
        int speed = 5;
        int score = 0;
        bool isPressed;
        int totalEnemies = 12;
        int playerSpeed = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                makeBullet();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if(isPressed)
            {
                isPressed = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //El jugador se mueve a la derecha e izquierda
            if (goleft)
            {
                player.Left -= playerSpeed;
            }
            else if (goright)
            {
                player.Left += playerSpeed;
            }

            //Fin de el movimiento

            //Los enemigos se mueven en la pantalla
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "invaders")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();
                    }

                    ((PictureBox)x).Left += speed;

                    if (((PictureBox)x).Left > 720)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 10;

                        ((PictureBox)x).Left = -50;
                    }
                }
            }
            //Fin del movimiento de los enemigos en pantalla

            //Animamos las balas y removemos cuando salgan de la escena

            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {
                    y.Top -= 20;
                    if(((PictureBox)y).Top < this.Height - 490)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
            //Fin de la animacion de las balas
        }

        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width / 2;
            bullet.Top = player.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void gameOver()
        {
            timer1.Stop();
            label2.Text += " Game Over";
        }
    }
}
