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


        int platMoveSpeed = 3;
        int platMoveDistance = 250;
        int platMoveDirection = 1;
        int platInitialTop; 


        int enemySpeed = 5; 
        bool movingRight = true; 

        int playerStartPositionX;
        int playerStartPositionY;

        int frameIndex = 0;

        // animation des fruits
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
            // position de départ des plateformes qui bougent
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platmove")
                {
                    platInitialTop = x.Top;
                }
            }

            // position de départ du character
            playerStartPositionX = Me.Left;
            playerStartPositionY = Me.Top;
        }


    
        


        // méthode qui gère les mouvements, collisions ect...
        private void MainTimerEvent(object sender, EventArgs e)
        {

            // enlever les fruits + score
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

            // collisions entre la porte et le character + passer niveau suivant
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "door")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop(); 
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.Show();
                    }
                }
            }


            // collisions ennemy + character + réaparition
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                   
                    if ((string)x.Tag == "enemie1" && Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        Me.Left = playerStartPositionX;
                        Me.Top = playerStartPositionY;
                    }

                   
                }
            }


            //mouvement de l'ennemy
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "enemie1")
                    {
                        PictureBox enemy = (PictureBox)x;

                        
                        if (movingRight)
                        {
                            enemy.Left += enemySpeed;
                            if (enemy.Left + enemy.Width > this.ClientSize.Width - 200) 
                                movingRight = false; 
                        }
                        else
                        {
                            enemy.Left -= enemySpeed;
                            if (enemy.Left < 0 + 330) 
                                movingRight = true; 
                        }
                    }

                   

                }
            }


            //mouvement de la plateforme bougeante
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platmove")
                {
                    x.Top += platMoveSpeed * platMoveDirection; 

                    
                    if (x.Top - platInitialTop >= platMoveDistance || x.Top - platInitialTop <= 0)
                    {
                        platMoveDirection *= -1;
                    }
                }
            }


            //animation des fruits
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    PictureBox fruit = (PictureBox)x;
                    fruit.BackgroundImage = fruitImages[frameIndex];
                }
            }

            frameIndex = (frameIndex + 1) % 4; 


            // gère le saut (gravité)
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


            // gère les collisions entre la plateforme statique et le character
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


            //gère les collisions entre la plateforme qui bougent et le character
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


            // gère les mouvements du character par rapport a la fenêtre
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

            // fluidifie le saut, sa vitesse
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


        //gère l'appuie de touche pour les mouvements du personnage + animation
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            //gère l'appuie de touche pour les mouvements du personnage
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


            // animation en marchant
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

        
        //gère le relachement des touches pour les animations et les mouvements
        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            // mouvements en lachant la touche
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }


            // animation en arretant d'appuyer
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
