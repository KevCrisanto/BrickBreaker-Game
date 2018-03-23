using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace brickbreaker
{
    public partial class BrickBreakerForm : Form
    {
        // Sounds for the game
        SoundPlayer startSound = new SoundPlayer(brickbreaker.Properties.Resources.start);
        SoundPlayer quitSound = new SoundPlayer(brickbreaker.Properties.Resources.quit);
        SoundPlayer countDownSound = new SoundPlayer(brickbreaker.Properties.Resources.countdown);
        SoundPlayer blockHitSound = new SoundPlayer(brickbreaker.Properties.Resources.Hit1);
        SoundPlayer wallHitSound = new SoundPlayer(brickbreaker.Properties.Resources.Hit2);
        SoundPlayer blockSpeedSound = new SoundPlayer(brickbreaker.Properties.Resources.speed);
        SoundPlayer paddleTouchSound = new SoundPlayer(brickbreaker.Properties.Resources.paddle_touch);

        Timer gameTimer = new Timer();
        Random rand = new Random();

        // Paddle speed
        int paddleSpeed = 50;
        bool useKeyboard = false;
        int keyboardDX = 0;

        // Ball variables
        int ballSpeed = 8;
        int ballDX = 1;
        int ballDY = 1;

        // Block variables
        Image[,] Blocks;
        int blockRows;
        int blockCols;
        int blockCount = 0;

        // Game variables
        bool gamePaused = true;
        int score = 0;

        public BrickBreakerForm()
        {
            InitializeComponent();
        }

        private void ShowMenu(bool Show = true)
        {
            btnKeyboard.Checked = useKeyboard;
            GameMenu.Visible = Show;
            Invalidate(); 
        }

        private bool IsPaused()
        {
            return gamePaused;
        }

        private void PauseGame(bool Pause = true)
        {
            ShowMenu(Pause);
            gameTimer.Enabled = !Pause;
            gamePaused = Pause;
            btnResume.Enabled = Pause;
        }

        private void ShowGameOver(string text = "Game Over")
        {
            lblGameOver.Text = text;
            lblGameOver.Left = (ClientRectangle.Width - lblGameOver.Width) / 2;
            lblGameOver.Top = 60;
            lblGameOver.Visible = true;
            gameTimer.Enabled = false;

            quitSound.Play();

            for (int i = 0; i < 10; ++i)
            {
                lblGameOver.Top += 15;
                Application.DoEvents();
                System.Threading.Thread.Sleep(45);
            }

            System.Threading.Thread.Sleep(2000);
            lblGameOver.Visible = false;
            PauseGame(true);
            btnResume.Enabled = false;
        }

        private int MakeBlocks(int rows, int cols)
        {
            blockRows = rows;
            blockCols = cols;

            Blocks = new Image[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    int index = rand.Next(0, imageList1.Images.Count);
                    Blocks[i, j] = imageList1.Images[index];
                    Blocks[i, j].Tag = index;
                }
            return rows * cols;
        }

        private void MovePaddle(int newXPos)
        {
            if (newXPos < 0)
                newXPos = 0;
            else if (newXPos > ClientRectangle.Width - imgPaddle.Width)
                newXPos = ClientRectangle.Width - imgPaddle.Width;

            imgPaddle.Left = newXPos;
        }

        private void BrickBreakerForm_Load(object sender, EventArgs e)
        {
            // Center paddle on screen
            MovePaddle((ClientRectangle.Width - imgPaddle.Width) / 2);

            // Center ball on screen
            imgBall.Left = (ClientRectangle.Width - imgPaddle.Width) / 2;
            imgBall.Top = 220;

            // Setup game timer
            gameTimer.Interval = 16; // Call timer every 16ms
            gameTimer.Tick += GameTimer_Tick;

            // Prepare our blocks
            blockCount = MakeBlocks(5, imageList1.Images.Count);

            // Game is paused when it starts
            PauseGame(true);
            btnResume.Enabled = false;

            startSound.Play();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Use keyboard if selected
            if (useKeyboard)
                MovePaddle(imgPaddle.Left + keyboardDX);

            //Ball movement
            Point pt = imgBall.Location;

            pt.X += ballSpeed * ballDX;
            pt.Y += ballSpeed * ballDY;
            imgBall.Location = pt;

            if (pt.X < 0 || pt.X > ClientRectangle.Width - imgBall.Width)
            {
                wallHitSound.Play();
                ballDX = -ballDX;
            }

            if (pt.Y < 0)
            {
                wallHitSound.Play();
                ballDY = -ballDY;
            }

            if (pt.Y > ClientRectangle.Height)
            {
                // Game Over
                ShowGameOver();
            }

            // Detect collision with paddle
            if (imgBall.Bounds.IntersectsWith(imgPaddle.Bounds))
            {
                paddleTouchSound.Play();
                ballDY = -ballDY;
            }

            //Detect collision with blocks
            Point[] pts = new Point[]
            {
                new Point(pt.X, pt.Y),  //left-top
                new Point(pt.X + imgBall.Width, pt.Y), //right-top
                new Point(pt.X, pt.Y+imgBall.Height), //left-bottom
                new Point(pt.X+imgBall.Width, pt.Y+imgBall.Height) //Right-bottom
            };

            int hitCount = 0;
            foreach (Point ptBall in pts)
            {
                int imgWidth = imageList1.ImageSize.Width;
                int imgHeight = imageList1.ImageSize.Height;
                int xpos = (ClientRectangle.Width - imgWidth * blockCols) / 2;
                int ypos = 70;
                int row = ptBall.Y - ypos;
                int col = ptBall.X - xpos;

                col /= imgWidth;
                row /= imgHeight;

                if (col >= 0 && col < blockCols && row >= 0 && row < blockRows)
                {
                    if (Blocks[row, col] != null)
                    {
                        if ((int)Blocks[row, col].Tag == 0)
                        {
                            // Increase speed after hitting a stone block
                            ballSpeed += 2;
                            if (hitCount == 0)
                                blockSpeedSound.Play();
                        }
                        else if (hitCount == 0)
                        {
                            blockHitSound.Play();
                        }

                        Blocks[row, col] = null;
                        Rectangle rc = new Rectangle(xpos + col * imgWidth, ypos + row * imgHeight, imgWidth, imgHeight);
                        Invalidate(rc);
                        ++hitCount;
                    }
                }
            }
            if (hitCount > 0)
            {
                //We have at least 1 block hit
                ballDY = -ballDY;

                score += hitCount;
                lblScore.Text = score.ToString("D5");
                blockCount -= hitCount;
                if(blockCount <= 0)
                {
                    // Game level is complete
                    ShowGameOver("Level Complete!");
                }
            }
        }

        private void BrickBreakerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPaused() || useKeyboard)
                return;
            MovePaddle(e.X);
        }

        private void BrickBreakerForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (GameMenu.Visible)
                return;

            int xpos;
            int ypos = 70;
            int imgWidth = imageList1.ImageSize.Width;
            int imgHeight = imageList1.ImageSize.Height;

            for (int i = 0; i < blockRows; ++i)
            {
                xpos = (ClientRectangle.Width - imgWidth * blockCols)/2; // Center blocks on screen
                for (int j = 0; j < blockCols; ++j)
                {
                    if (Blocks[i, j] != null)
                        g.DrawImage(Blocks[i, j], xpos, ypos);
                    xpos += imgWidth;
                }
                ypos += imgHeight;
            }
        }

        private void BrickBreakerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    ShowMenu(!GameMenu.Visible);
                    if(!IsPaused())
                        PauseGame();
                    break;
                case Keys.Q:
                    // Quit
                    Close();
                    break;
                case Keys.Left:
                    if(!IsPaused())
                        keyboardDX = -paddleSpeed;
                    break;
                case Keys.Right:
                    if (!IsPaused())
                        keyboardDX = paddleSpeed;
                    break;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Reset direction of ball
            ballDX = 1;
            ballDY = 1;

            // Reset Speed
            ballSpeed = 8;

            score = 0;
            lblScore.Text = score.ToString("D5");

            // Center paddle on screen
            MovePaddle((ClientRectangle.Width - imgPaddle.Width) / 2);

            // Center ball on screen
            imgBall.Left = (ClientRectangle.Width - imgPaddle.Width) / 2;
            imgBall.Top = 220;

            // Prepare our blocks
            blockCount = MakeBlocks(rand.Next(3, 8), imageList1.Images.Count);

            // Countdown
            lblCountdown.Text = "3";
            lblCountdown.Visible = true;
            ShowMenu(false);
            for (int i = 3; i >= 0; --i)
            {
                lblCountdown.Text = i.ToString();
                Application.DoEvents();
                countDownSound.Play();
                System.Threading.Thread.Sleep(1000);
            }
            lblCountdown.Visible = false;
            // Unpause after pressing "New Game" button
            PauseGame(false);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            PauseGame(false);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            useKeyboard = btnKeyboard.Checked;
        }

        private void BrickBreakerForm_KeyUp(object sender, KeyEventArgs e)
        {
            keyboardDX = 0;
        }
    }
}
