namespace IAFRATE_Thomas_WFA
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, haskey;
        int jumpspeed = 10;
        int force = 8;

        int score = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            ScoreTxt.Text = "Score :" + score;

            if(goLeft == true && Me.Left > 60)
            {
                Me.Left -= playerSpeed;
            }
            if(goRight == true && Me.Left + (Me.Width + 60) < this.ClientSize.Width)
            {
                Me.Left += playerSpeed; 
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
    }
}