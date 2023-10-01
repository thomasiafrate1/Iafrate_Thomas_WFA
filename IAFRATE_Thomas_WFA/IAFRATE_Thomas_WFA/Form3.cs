using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAFRATE_Thomas_WFA
{
    public partial class Form3 : Form
    {

        bool goLeft, goRight, jumping;
        int jumpSpeed = 30;
        int jumpspeed = 25;
        int force = 10;
        int gravity = 25;
        bool isOnGround = false;
        int score = 0;
        int playerSpeed = 15;
        int initialJumpForce = -2;

        int movingSpeed = 5;
        int moveDistance = 0;
        bool movingUp = true;
        bool haskey = false;





        // gérer les images de fruits, animations
        int frameIndex = 0;
        List<Image> fruitImages = new List<Image>
            {
                Properties.Resources.Melon1,
                Properties.Resources.Melon2,
                Properties.Resources.Melon3,
                Properties.Resources.Melon4
            };

        public Form3()
        {
            InitializeComponent();


        }




        //méthode principale qui gère les mouvements, collisions etc...
        private void MainTimerEvent(object sender, EventArgs e)
        {

            //affichage du score
            labelLives.Text = "Vies : " + GameData.Vies.ToString();


            // gérer la collision des fruit + character
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameData.Score++;
                        label1.Text = "Score : " + GameData.Score.ToString();
                        x.Left = -100;
                    }

                    else
                    {
                        PictureBox fruit = (PictureBox)x;
                        fruit.BackgroundImage = fruitImages[frameIndex];
                    }
                }
            }





            // collision entre les piques et le character + réapparition
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "spades")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameData.Vies--;

                        if (GameData.Vies <= 0)
                        {
                            GameTimer.Stop();
                            GameOver gameover = new GameOver();
                            this.Hide();
                            gameover.Show();
                        }
                        else
                        {
                            Me.Location = new Point(45, 308);
                            labelLives.Text = "Vies : " + GameData.Vies.ToString();
                        }

                        break;
                    }
                }
            }





            // gérer le lien entre le cadenas et la clé 
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "key")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                        haskey = true;

                        foreach (Control y in this.Controls)
                        {
                            if (y is PictureBox && (string)y.Tag == "lock")
                            {
                                y.Visible = false;
                                break;
                            }
                        }
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "door")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds) && haskey)
                    {
                        GameTimer.Stop();
                        Fin newForm = new Fin();
                        newForm.Show();
                        this.Hide();
                    }
                }
            }

            //gére les mouvements de la plateforme bougeante
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platmove")
                {
                    if (movingUp)
                    {
                        x.Top -= movingSpeed;
                        moveDistance += movingSpeed;
                        if (moveDistance >= 190)
                        {
                            movingUp = false;
                        }
                    }
                    else
                    {
                        x.Top += movingSpeed;
                        moveDistance -= movingSpeed;
                        if (moveDistance <= 0)
                        {
                            movingUp = true;
                        }
                    }
                }
            }



            //gére l'animation des fruits
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    PictureBox fruit = (PictureBox)x;
                    fruit.BackgroundImage = fruitImages[frameIndex];
                }
            }

            frameIndex = (frameIndex + 1) % 4;


            // gravité du joueur
            if (jumping)
            {
                jumpspeed = -jumpSpeed;
                force--;
                if (force <= 0)
                {
                    jumping = false;
                }
            }
            else
            {
                jumpspeed = gravity;
            }

            Me.Top += jumpspeed;


            // collision entre le character et les plateformes statiques
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {

                        if (Me.Bottom < x.Bottom)
                        {
                            isOnGround = true;
                            force = 8;
                            Me.Top = x.Top - Me.Height;
                            jumpspeed = 0;
                        }

                        else if (jumping && Me.Top < x.Bottom)
                        {
                            jumping = false;
                        }
                    }
                }
            }

            //collision entre le joueur et les plateformes bougeante
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platmove")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {

                        if (Me.Bottom < x.Bottom)
                        {
                            isOnGround = true;
                            force = 8;
                            Me.Top = x.Top - Me.Height;
                            jumpspeed = 0;
                        }

                        else if (jumping && Me.Top < x.Bottom)
                        {
                            jumping = false;
                        }
                    }
                }
            }



            // gérer les mouvements par rapport à la fenetre
            if (Me.Top + Me.Height > this.ClientSize.Height)
            {
                Me.Top = this.ClientSize.Height - Me.Height;
                jumping = false;
            }
            if (goLeft == true && Me.Left > 20)
            {
                Me.Left -= playerSpeed;
            }
            if (goRight == true && Me.Left + (Me.Width + 20) < this.ClientSize.Width)
            {
                Me.Left += playerSpeed;
            }
            if (Me.Top + Me.Height > this.ClientSize.Height)
            {
                Me.Top = this.ClientSize.Height - Me.Height - 10;
                isOnGround = true;
            }
            if (jumping == true)
            {
                jumpspeed = -20;
                force -= 1;
            }
            else
            {
                jumpspeed = 20;
            }
            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            // animation blanc

            this.DoubleBuffered = true;
        }

        //gestion des touches lorsqu'elles sont enfoncées
        private void keyisdown(object sender, KeyEventArgs e)
        {

            //mouvement quand c'est appuyer  
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping && Me.Top + Me.Height >= this.ClientSize.Height)
            {
                jumping = true;
                force = 5;
            }
            if (e.KeyCode == Keys.Space && isOnGround)
            {
                jumping = true;
                isOnGround = false;
                force = 5;
            }

            //animation du joueur en appuyant
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                Me.Image = Properties.Resources.characterToLeft1;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                Me.Image = Properties.Resources.characterToRight1;
            }
        }
        //gestion des touches lorsqu'elles sont relachés
        private void keyisup(object sender, KeyEventArgs e)
        {

            //mouvement quand c'est relaché
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }


            //animation du joueur en relachant
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                Me.Image = Properties.Resources.character;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                Me.Image = Properties.Resources.character;

            }
        }
    }
}