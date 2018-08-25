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
        int speedenemie = 8;



        public Form1() {


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

            //Fin de el movimiento del jugador

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

                    if (((PictureBox)x).Left > 470)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 20;

                        ((PictureBox)x).Left = -30;
                    }
                }
            }

            //Los enemigos se mueven en la pantalla
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "invaders2")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();
                    }

                    ((PictureBox)x).Left += speed;

                    if (((PictureBox)x).Left > 470)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 40;

                        ((PictureBox)x).Left = -40;
                    }
                }
            }
            //Fin del movimiento de los enemigos en pantalla

            //Animamos las balas y removemos cuando salgan de la escena
            foreach (Control y in this.Controls) {
                if (y is PictureBox && y.Tag == "bullet")
                {   y.Top -= 20;
                    if(((PictureBox)y).Top < this.Height - 490) {
                        this.Controls.Remove(y);
                    }
                }
            }
            //Fin de la animacion de las balas

            //Las balas logran destruir a los enemigos
            foreach (Control a in this.Controls) {
                foreach (Control b in this.Controls) {
                    if (a is PictureBox && a.Tag == "invaders" || a.Tag =="invaders2") {
                        if (b is PictureBox && (b.Tag == "bullet" || b.Tag == "tank")) {
                            if (a.Bounds.IntersectsWith(b.Bounds)) {
                                score++;
                                this.Controls.Remove(a);
                                this.Controls.Remove(b);
                            }
                        }
                    }
                }
                if (speedenemie == totalEnemies - 1)
                {
                    speedenemie = 8;
                }
            }

            //Mostrando el puntaje y fin del juego al ganar

            label1.Text = "Score: " + score;

            if (score > totalEnemies - 1) {
                gameOver();
                MessageBox.Show("Haz salvado la tierra");
            }
        }

        private void makeBullet() {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width / 2;
            bullet.Top = player.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        //Colision de enemigos y balas
        private void gameOver()
        {
            timer1.Stop();
            label2.Text += " Game Over";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
