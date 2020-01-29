namespace GameSimulator
{
    partial class Dodger
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
            this.lblGround = new System.Windows.Forms.Label();
            this.lblDodger = new System.Windows.Forms.Label();
            this.timeSlowest = new System.Windows.Forms.Timer(this.components);
            this.timeSlow = new System.Windows.Forms.Timer(this.components);
            this.timeFast = new System.Windows.Forms.Timer(this.components);
            this.timeFastest = new System.Windows.Forms.Timer(this.components);
            this.timeGetObstacle = new System.Windows.Forms.Timer(this.components);
            this.timeChecker = new System.Windows.Forms.Timer(this.components);
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblGround
            // 
            this.lblGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGround.Location = new System.Drawing.Point(-15, 594);
            this.lblGround.Name = "lblGround";
            this.lblGround.Size = new System.Drawing.Size(426, 26);
            this.lblGround.TabIndex = 0;
            // 
            // lblDodger
            // 
            this.lblDodger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDodger.Location = new System.Drawing.Point(377, 569);
            this.lblDodger.Name = "lblDodger";
            this.lblDodger.Size = new System.Drawing.Size(25, 25);
            this.lblDodger.TabIndex = 1;
            // 
            // timeSlowest
            // 
            this.timeSlowest.Tick += new System.EventHandler(this.timeSlowest_Tick);
            // 
            // timeSlow
            // 
            this.timeSlow.Tick += new System.EventHandler(this.timeSlow_Tick);
            // 
            // timeFast
            // 
            this.timeFast.Tick += new System.EventHandler(this.timeFast_Tick);
            // 
            // timeFastest
            // 
            this.timeFastest.Tick += new System.EventHandler(this.timeFastest_Tick);
            // 
            // timeGetObstacle
            // 
            this.timeGetObstacle.Interval = 4000;
            this.timeGetObstacle.Tick += new System.EventHandler(this.timeGetObstacle_Tick);
            // 
            // timeChecker
            // 
            this.timeChecker.Tick += new System.EventHandler(this.timeChecker_Tick);
            // 
            // timeUpdate
            // 
            this.timeUpdate.Interval = 1000;
            this.timeUpdate.Tick += new System.EventHandler(this.timeUpdate_Tick);
            // 
            // Dodger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 619);
            this.ControlBox = false;
            this.Controls.Add(this.lblDodger);
            this.Controls.Add(this.lblGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dodger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodger";
            this.Load += new System.EventHandler(this.Dodger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dodger_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGround;
        private System.Windows.Forms.Label lblDodger;
        private System.Windows.Forms.Timer timeSlowest;
        private System.Windows.Forms.Timer timeSlow;
        private System.Windows.Forms.Timer timeFast;
        private System.Windows.Forms.Timer timeFastest;
        private System.Windows.Forms.Timer timeGetObstacle;
        private System.Windows.Forms.Timer timeChecker;
        private System.Windows.Forms.Timer timeUpdate;
    }
}