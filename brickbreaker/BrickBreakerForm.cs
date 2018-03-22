using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brickbreaker
{
    public partial class BrickBreakerForm : Form
    {
        Timer gameTimer = new Timer();
        Random rand = new Random();

        // Ball variables
        int ballSpeed = 8;
        int ballDX = 1;
        int ballDY = 1;

        // Block variables
        Image[,] Blocks;
        int blockRows;
        int blockCols;
        int blockCount = 0;

        public BrickBreakerForm()
        {
            InitializeComponent();
        }

        private int MakeBlocks(int rows, int cols)
        {
            Blocks = new Image[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    int index = rand.Next(0, imageList1.Images.Count);
                    Blocks[i, j] = imageList1.Images[index];
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
            imgBall.Top = 250;

            // Setup game timer
            gameTimer.Interval = 16; // Call timer every 16ms
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Enabled = true;

            // Prepare our blocks
            blockRows = 5;
            blockCols = imageList1.Images.Count;
            blockCount = MakeBlocks(blockRows, blockCols);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Ball movement
            Point pt = imgBall.Location;
            pt.X += ballSpeed * ballDX;
            pt.Y += ballSpeed * ballDY;
            imgBall.Location = pt;

            if (pt.X < 0 || pt.X > ClientRectangle.Width - imgBall.Width)
                ballDX = -ballDX;

            if (pt.Y < 0)
                ballDY = -ballDY;

            if (pt.Y > ClientRectangle.Height)
            {
                // Game Over
                lblGameOver.Visible = true;
                gameTimer.Enabled = false;
            }

            // Detect collision with paddle
            if (imgBall.Bounds.IntersectsWith(imgPaddle.Bounds))
                ballDY = -ballDY;
        }

        private void BrickBreakerForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovePaddle(e.X);
        }

        private void BrickBreakerForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int ypos = 70;
            int imgWidth = imageList1.ImageSize.Width;
            int imgHeight = imageList1.ImageSize.Height;

            for (int i = 0; i < blockRows; ++i)
            {
                int xpos = (ClientRectangle.Width - imgWidth * blockCols)/2; // Center blocks on screen
                for (int j = 0; j < blockCols; ++j)
                {
                    g.DrawImage(Blocks[i, j], xpos, ypos);
                    xpos += imgWidth;
                }
                ypos += imgHeight;
            }
        }
    }
}
