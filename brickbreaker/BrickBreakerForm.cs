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

        int ballSpeed = 8;
        int ballDX = 1;
        int ballDY = 1;


        public BrickBreakerForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

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

            if (pt.Y < 0 || pt.Y > ClientRectangle.Height - imgBall.Height)
                ballDY = -ballDY;

        }

        private void BrickBreakerForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovePaddle(e.X);
        }
    }
}
