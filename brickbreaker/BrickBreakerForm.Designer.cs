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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrickBreakerForm));
            this.imgPaddle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).BeginInit();
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
            // BrickBreakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.imgPaddle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BrickBreakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrickBreaker";
            this.Load += new System.EventHandler(this.BrickBreakerForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrickBreakerForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPaddle;
    }
}

