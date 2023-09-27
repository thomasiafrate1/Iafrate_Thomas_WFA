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
    public partial class Form2 : Form
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


        int platMoveSpeed = 3; // Vitesse de déplacement de la plateforme.
        int platMoveDistance = 250; // Distance maximale de déplacement.
        int platMoveDirection = 1; // Direction du déplacement. 1 pour monter, -1 pour descendre.
        int platInitialTop; // Position initiale de la plateforme.


        int enemySpeed = 5; // Vous pouvez ajuster cette valeur pour que l'ennemi se déplace plus rapidement ou plus lentement
        bool movingRight = true; // Une variable pour déterminer si l'ennemi se déplace vers la droite ou vers la gauche

        int playerStartPositionX;
        int playerStartPositionY;

        int frameIndex = 0;
        List<Image> fruitImages = new List<Image>
            {
                Properties.Resources.Pineapple1,
                Properties.Resources.Pineapple2,
                Properties.Resources.Pineapple3,
                Properties.Resources.Pineapple4
            };


        public Form2()
        {
            InitializeComponent();
            // Trouver la plateforme avec le tag "platmove" et définir sa position initiale.
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platmove")
                {
                    platInitialTop = x.Top;
                }
            }

            playerStartPositionX = Me.Left;
            playerStartPositionY = Me.Top;
        }



        private void MainTimerEvent(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    // Vérification de la collision avec l'ennemi
                    if ((string)x.Tag == "enemie1" && Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        // Remet le personnage à sa position de départ
                        Me.Left = playerStartPositionX;
                        Me.Top = playerStartPositionY;
                    }

                    // ...
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "enemie1")
                    {
                        PictureBox enemy = (PictureBox)x;

                        // Déplacez l'ennemi horizontalement
                        if (movingRight)
                        {
                            enemy.Left += enemySpeed;
                            if (enemy.Left + enemy.Width > this.ClientSize.Width - 200) // vérifie si l'ennemi a atteint le bord droit
                                movingRight = false; // changez la direction
                        }
                        else
                        {
                            enemy.Left -= enemySpeed;
                            if (enemy.Left < 0 + 330) // vérifie si l'ennemi a atteint le bord gauche
                                movingRight = true; // changez la direction
                        }
                    }

                    // logique pour les autres PictureBox...

                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platmove")
                {
                    x.Top += platMoveSpeed * platMoveDirection; // Déplacer la plateforme.

                    // Si la plateforme a atteint la limite de sa distance de déplacement, changer la direction.
                    if (x.Top - platInitialTop >= platMoveDistance || x.Top - platInitialTop <= 0)
                    {
                        platMoveDirection *= -1;
                    }
                }
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    PictureBox fruit = (PictureBox)x;
                    fruit.BackgroundImage = fruitImages[frameIndex];
                }
            }

            frameIndex = (frameIndex + 1) % 4; // Cela incrémente frameIndex à chaque tick, mais le garde entre 0 et 3



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

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform" || (string)x.Tag == "platmove")
                    {
                        if (Me.Bounds.IntersectsWith(x.Bounds) && !jumping)
                        {
                            isOnGround = true;
                            force = 8;
                            Me.Top = x.Top - Me.Height + 10;
                            jumpspeed = 0;

                            // Si la plateforme est mobile, déplacez le personnage avec la plateforme.
                            if ((string)x.Tag == "platmove")
                            {
                                Me.Top += platMoveSpeed * platMoveDirection;
                            }
                        }
                        x.BringToFront();
                    }
                }
            }


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

            // animation

            this.DoubleBuffered = true;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
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

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

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
