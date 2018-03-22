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
            this.GameMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            this.GameMenu.SuspendLayout();
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
            this.imgBall.Location = new System.Drawing.Point(378, 456);
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
            this.lblGameOver.Font = new System.Drawing.Font("Astron Boy Rg", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(166, 35);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(464, 115);
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
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.Color.Transparent;
            this.GameMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameMenu.BackgroundImage")));
            this.GameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameMenu.Controls.Add(this.label1);
            this.GameMenu.Controls.Add(this.btnQuit);
            this.GameMenu.Controls.Add(this.btnResume);
            this.GameMenu.Controls.Add(this.btnNewGame);
            this.GameMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameMenu.Location = new System.Drawing.Point(200, 150);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(400, 300);
            this.GameMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Astron Boy Video", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "BRICKBREAKER MENU";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Teal;
            this.btnQuit.Font = new System.Drawing.Font("Astron Boy Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Location = new System.Drawing.Point(45, 190);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(300, 35);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Teal;
            this.btnResume.Enabled = false;
            this.btnResume.Font = new System.Drawing.Font("Astron Boy Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResume.Location = new System.Drawing.Point(45, 131);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(300, 35);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "RESUME";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Teal;
            this.btnNewGame.Font = new System.Drawing.Font("Astron Boy Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewGame.Location = new System.Drawing.Point(45, 73);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(300, 35);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Astron Boy Video", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCORE:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Astron Boy Video", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(106, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(98, 29);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "00000";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Astron Boy Rg", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountdown.Location = new System.Drawing.Point(627, 223);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(113, 115);
            this.lblCountdown.TabIndex = 6;
            this.lblCountdown.Text = "3";
            this.lblCountdown.Visible = false;
            // 
            // BrickBreakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameMenu);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.imgBall);
            this.Controls.Add(this.imgPaddle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BrickBreakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrickBreaker";
            this.Load += new System.EventHandler(this.BrickBreakerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BrickBreakerForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrickBreakerForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrickBreakerForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPaddle;
        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel GameMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCountdown;
    }
}

