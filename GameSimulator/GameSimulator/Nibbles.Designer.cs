namespace GameSimulator
{
    partial class Nibbles
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
            this.lblWall1 = new System.Windows.Forms.Label();
            this.lblWall3 = new System.Windows.Forms.Label();
            this.lblWall4 = new System.Windows.Forms.Label();
            this.lblWall2 = new System.Windows.Forms.Label();
            this.picApple = new System.Windows.Forms.PictureBox();
            this.picSnakeHead = new System.Windows.Forms.PictureBox();
            this.time_Snake = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeHead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWall1
            // 
            this.lblWall1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWall1.Location = new System.Drawing.Point(0, -25);
            this.lblWall1.Name = "lblWall1";
            this.lblWall1.Size = new System.Drawing.Size(10, 470);
            this.lblWall1.TabIndex = 0;
            // 
            // lblWall3
            // 
            this.lblWall3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWall3.Location = new System.Drawing.Point(420, -25);
            this.lblWall3.Name = "lblWall3";
            this.lblWall3.Size = new System.Drawing.Size(10, 470);
            this.lblWall3.TabIndex = 1;
            // 
            // lblWall4
            // 
            this.lblWall4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWall4.Location = new System.Drawing.Point(-25, 420);
            this.lblWall4.Name = "lblWall4";
            this.lblWall4.Size = new System.Drawing.Size(470, 10);
            this.lblWall4.TabIndex = 2;
            // 
            // lblWall2
            // 
            this.lblWall2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWall2.Location = new System.Drawing.Point(-25, 0);
            this.lblWall2.Name = "lblWall2";
            this.lblWall2.Size = new System.Drawing.Size(470, 10);
            this.lblWall2.TabIndex = 3;
            // 
            // picApple
            // 
            this.picApple.Location = new System.Drawing.Point(400, 400);
            this.picApple.Name = "picApple";
            this.picApple.Size = new System.Drawing.Size(20, 20);
            this.picApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApple.TabIndex = 4;
            this.picApple.TabStop = false;
            // 
            // picSnakeHead
            // 
            this.picSnakeHead.Location = new System.Drawing.Point(204, 204);
            this.picSnakeHead.Name = "picSnakeHead";
            this.picSnakeHead.Size = new System.Drawing.Size(20, 20);
            this.picSnakeHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSnakeHead.TabIndex = 5;
            this.picSnakeHead.TabStop = false;
            // 
            // time_Snake
            // 
            this.time_Snake.Interval = 500;
            this.time_Snake.Tick += new System.EventHandler(this.time_Snake_Tick);
            // 
            // Nibbles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(429, 429);
            this.ControlBox = false;
            this.Controls.Add(this.picSnakeHead);
            this.Controls.Add(this.picApple);
            this.Controls.Add(this.lblWall2);
            this.Controls.Add(this.lblWall4);
            this.Controls.Add(this.lblWall3);
            this.Controls.Add(this.lblWall1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nibbles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nibbles";
            this.Load += new System.EventHandler(this.Nibbles_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nibbles_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWall1;
        private System.Windows.Forms.Label lblWall3;
        private System.Windows.Forms.Label lblWall4;
        private System.Windows.Forms.Label lblWall2;
        private System.Windows.Forms.PictureBox picApple;
        private System.Windows.Forms.PictureBox picSnakeHead;
        private System.Windows.Forms.Timer time_Snake;
    }
}