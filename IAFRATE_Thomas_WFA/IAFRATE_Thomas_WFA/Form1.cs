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
        int score = 0;
        int playerSpeed = 15;
        int initialJumpForce = -2;

        int frameIndex = 0;
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




        private void GameTimerEvent(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                {
                    PictureBox fruit = (PictureBox)x;
                    fruit.BackgroundImage = fruitImages[frameIndex];
                }
            }

            frameIndex = (frameIndex + 1) % 4; // Cela incrémente frameIndex à chaque tick, mais le garde entre 0 et 3



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "door")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop(); // Supposant que gameTimer est le nom de votre Timer
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.Show();
                    }
                }
            }



            ScoreTxt.Text = "Score :" + score;


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
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (Me.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        isOnGround = true;
                        force = 8;
                        Me.Top = x.Top - Me.Height + 10;
                        jumpspeed = 0;
                    }
                    x.BringToFront();
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

        private void AnimateCharacter()
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
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


        private void gamekeyisup(object sender, KeyEventArgs e)
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


        private void formclosed(object sender, FormClosedEventArgs e)
        {

        }

        private void RestartGame()
        {

        }

        private void MoveGameElements(string direction)
        {

        }




    }
}