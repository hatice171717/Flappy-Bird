namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int boruH�z� = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvents(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            BoruAlt.Left -= boruH�z�;
            BoruUst.Left -= boruH�z�;
            scoreText.Text = "Score: " + score;
            if (BoruAlt.Left<-150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left<-180)
            {
                BoruUst.Left = 950;
                score++;
            }
            if (FlappyBird.Bounds.IntersectsWith(BoruAlt.Bounds)||FlappyBird.Bounds.IntersectsWith(BoruUst.Bounds)||FlappyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }
            if (score>5)
            {
                boruH�z� = 15;
            }
            if (FlappyBird.Top<-25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}