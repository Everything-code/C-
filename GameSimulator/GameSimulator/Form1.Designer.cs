namespace GameSimulator
{
    partial class Form1
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
            this.lblGameSimulator = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.btnPlay3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timeFinish = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblGameSimulator
            // 
            this.lblGameSimulator.AutoSize = true;
            this.lblGameSimulator.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSimulator.Location = new System.Drawing.Point(42, 31);
            this.lblGameSimulator.Name = "lblGameSimulator";
            this.lblGameSimulator.Size = new System.Drawing.Size(258, 32);
            this.lblGameSimulator.TabIndex = 0;
            this.lblGameSimulator.Text = "Game Simulator";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(48, 89);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(252, 41);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Game 1";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay2.Location = new System.Drawing.Point(48, 153);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(252, 41);
            this.btnPlay2.TabIndex = 2;
            this.btnPlay2.Text = "Game 2";
            this.btnPlay2.UseVisualStyleBackColor = false;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // btnPlay3
            // 
            this.btnPlay3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPlay3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay3.Location = new System.Drawing.Point(48, 219);
            this.btnPlay3.Name = "btnPlay3";
            this.btnPlay3.Size = new System.Drawing.Size(252, 41);
            this.btnPlay3.TabIndex = 3;
            this.btnPlay3.Text = "Game 3";
            this.btnPlay3.UseVisualStyleBackColor = false;
            this.btnPlay3.Click += new System.EventHandler(this.btnPlay3_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(48, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timeFinish
            // 
            this.timeFinish.Tick += new System.EventHandler(this.timeFinish_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(346, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay3);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGameSimulator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameSimulator;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Button btnPlay3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timeFinish;
    }
}

