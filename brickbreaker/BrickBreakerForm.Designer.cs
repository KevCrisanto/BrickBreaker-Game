namespace brickbreaker
{
    partial class BrickBreakerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrickBreakerForm));
            this.imgPaddle = new System.Windows.Forms.PictureBox();
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPaddle
            // 
            this.imgPaddle.BackColor = System.Drawing.Color.Transparent;
            this.imgPaddle.Image = ((System.Drawing.Image)(resources.GetObject("imgPaddle.Image")));
            this.imgPaddle.Location = new System.Drawing.Point(340, 500);
            this.imgPaddle.Name = "imgPaddle";
            this.imgPaddle.Size = new System.Drawing.Size(116, 12);
            this.imgPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPaddle.TabIndex = 0;
            this.imgPaddle.TabStop = false;
            // 
            // imgBall
            // 
            this.imgBall.BackColor = System.Drawing.Color.Transparent;
            this.imgBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgBall.Image = ((System.Drawing.Image)(resources.GetObject("imgBall.Image")));
            this.imgBall.Location = new System.Drawing.Point(514, 263);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(32, 32);
            this.imgBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBall.TabIndex = 1;
            this.imgBall.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(228, 165);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(348, 73);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stone_block.png");
            this.imageList1.Images.SetKeyName(1, "blue_block.png");
            this.imageList1.Images.SetKeyName(2, "brown_block.png");
            this.imageList1.Images.SetKeyName(3, "green_block.png");
            this.imageList1.Images.SetKeyName(4, "pink_block.png");
            this.imageList1.Images.SetKeyName(5, "red_block.png");
            this.imageList1.Images.SetKeyName(6, "skyblue_block.png");
            this.imageList1.Images.SetKeyName(7, "violet_block.png");
            this.imageList1.Images.SetKeyName(8, "yellow_block.png");
            // 
            // BrickBreakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.imgBall);
            this.Controls.Add(this.imgPaddle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BrickBreakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrickBreaker";
            this.Load += new System.EventHandler(this.BrickBreakerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BrickBreakerForm_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrickBreakerForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPaddle;
        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ImageList imageList1;
    }
}

