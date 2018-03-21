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
        public BrickBreakerForm()
        {
            InitializeComponent();
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

        }

        private void BrickBreakerForm_MouseMove(object sender, MouseEventArgs e)
        {
            MovePaddle(e.X);
        }
    }
}
