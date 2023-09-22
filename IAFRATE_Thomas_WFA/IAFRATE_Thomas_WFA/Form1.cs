namespace IAFRATE_Thomas_WFA
{
    public partial class Form1 : Form
    {   

        bool goLeft, goRight, jumping;
        int jumpSpeed = 15;
        int jumpspeed = 10;
        int force = 5;
        int gravity = 2;
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
            Me.Top += jumpspeed;


            if (jumping)
            {
                jumpspeed += gravity;
                Me.Top += jumpspeed;
                force--;
                if (force <= 0)
                    jumping = false;
            }
            else
            {
                Me.Top += jumpspeed;
            }

            if (goLeft == true && Me.Left > 120)
            {
                Me.Left -= playerSpeed;
            }
            if (goRight == true && Me.Left + (Me.Width + 60) < this.ClientSize.Width)
            {
                Me.Left += playerSpeed;
            }

            if (jumping == true)
            {
                jumpspeed = -70;
                force -= 1;
            }
            else
            {
                jumpspeed = 70;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }


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
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                jumpspeed = jumpSpeed; // fixe la vitesse du saut à une valeur constante
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
            if (jumping == true)
            {
                jumping = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Plateform4_Click(object sender, EventArgs e)
        {

        }

        private void Me_Click(object sender, EventArgs e)
        {

        }
    }
}