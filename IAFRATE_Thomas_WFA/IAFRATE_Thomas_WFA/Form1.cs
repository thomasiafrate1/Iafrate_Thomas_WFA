using System;

namespace IAFRATE_Thomas_WFA
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, jumping;
        int jumpSpeed = 30;
        int jumpspeed = 25;
        int force = 10;
        int gravity = 25;
        bool isOnGround = false;

        int playerSpeed = 15;
        int initialJumpForce = -2;

        int frameIndex = 0;

        // liste des images de fruit pour faire l'animation
        List<Image> fruitImages = new List<Image>
            {
                Properties.Resources.Cherries1,
                Properties.Resources.Cherries2,
                Properties.Resources.Cherries3,
                Properties.Resources.Cherries4
            };


        public Form1()
        {
            InitializeComponent();


        }

      



        // méthode timer qui gère les collisions, les animations etc...
        private void GameTimerEvent(object sender, EventArgs e)
        {
            // boucle pour mettre à jour les images de fruits
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    PictureBox fruit = (PictureBox)x;
                    fruit.BackgroundImage = fruitImages[frameIndex];
                }
            }

            frameIndex = (frameIndex + 1) % 4;


            // boucle pour la collision entre le character et la porte
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "door")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.Show();
                    }
                }
            }


            // boucle pour la collision entre le joueur et les fruit + mettre à jour le score 
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



            // gérer le saut du personnage
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



            // boucle pour les collisions entre le joueur et les plateformes
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



            // gérer les mouvements du personnage par rapport a la fenêtre
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


      


        // gérer lorsque les touches sont enfoncées
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            //déplacer le personnage
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

            // animation quand on bouge
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

        // gérer lorsque les touches sont relâchées
        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            // arreter les mouvements
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }


            // animation quand on bouge plus
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