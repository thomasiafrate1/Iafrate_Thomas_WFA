namespace IAFRATE_Thomas_WFA
{
    public partial class Form1 : Form
    {   

        bool goLeft, goRight, jumping;
        int jumpSpeed = 15;
        int jumpspeed = 10;
        int force = 5;
        int gravity = 18;
        bool isOnGround = false;
        int score = 0;
        int playerSpeed = 15;
        int initialJumpForce = -2;


        List<Image> standRightImages = new List<Image>();
        List<Image> standLeftImages = new List<Image>();
        List<Image> walkRightImages = new List<Image>();
        List<Image> walkLeftImages = new List<Image>();
        int animationIndex = 0;

        public Form1()
        {
            InitializeComponent();

            standRightImages.Add(Properties.Resources.character);
            standLeftImages.Add(Properties.Resources.characterToLeft);

            walkRightImages.Add(Properties.Resources.characterToRight1);
            walkRightImages.Add(Properties.Resources.characterToRight2);

            walkLeftImages.Add(Properties.Resources.characterToLeft1);
            walkLeftImages.Add(Properties.Resources.characterToLeft2);

            Me.Image = standRightImages[0];
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
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
                        Me.Top = x.Top - Me.Height - 10;
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

            if (goLeft == true && Me.Left > 120)
            {
                Me.Left -= playerSpeed;
            }
            if (goRight == true && Me.Left + (Me.Width + 60) < this.ClientSize.Width)
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

            if (goLeft)
            {
                Me.Image = walkLeftImages[animationIndex];
                AnimateCharacter();
            }
            else if (goRight)
            {
                Me.Image = walkRightImages[animationIndex];
                AnimateCharacter();
            }
            else
            {

                Me.Image = (Me.Image == walkLeftImages[0] || Me.Image == walkLeftImages[1])
                        ? standLeftImages[0] : standRightImages[0];
            }
        }

        private void AnimateCharacter()
        {
            animationIndex++;
            if (animationIndex >= walkRightImages.Count)
            {
                animationIndex = 0;
            }
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