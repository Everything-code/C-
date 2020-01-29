using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSimulator
{
    public partial class Nibbles : Form
    {
        private int appleNum = 0;
        private byte direction = 0;
        public Form RefToForm1 { get; set; }

        public Nibbles()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Nibbles_KeyDown);
        }

        private void Nibbles_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Catch the apples!");
            picApple.Image = Image.FromFile(@"C:\Users\DeV_NEN\Desktop\Project\GameSimulator\GameSimulator\Properties\apple.png");
            picSnakeHead.Image = Image.FromFile(@"C:\Users\DeV_NEN\Desktop\Project\GameSimulator\GameSimulator\Properties\snakeHead.png");
            RandomLocation();
            picSnakeHead.Location = new Point(10,10);
            time_Snake.Start();
        }

        private void RandomLocation()
        {
            Random rnd = new Random();
            int x = 1;
            int y = 1;
            while(!(((x%20) - 10) == 0) || !(((y%20)-10) == 0))
            {
                x = rnd.Next(10, 401);
                y = rnd.Next(10, 401);
            }
            //MessageBox.Show(x.ToString() + " " + y.ToString());
            picApple.Location = new Point(x, y);
        }     

        private void Nibbles_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Right) direction = 0;
            else if (e.KeyCode == Keys.Left) direction = 1;
            else if (e.KeyCode == Keys.Up) direction = 2;
            else if (e.KeyCode == Keys.Down) direction = 3;            
        }

        private void time_Snake_Tick(object sender, EventArgs e)
        {
            int x = picSnakeHead.Location.X;
            int y = picSnakeHead.Location.Y;

            if (direction == 0) x += 10;
            else if (direction == 1) x -= 10;
            else if (direction == 2) y -= 10;
            else if (direction == 3) y += 10;

            //Error checking
            if (picSnakeHead.Bounds.IntersectsWith(lblWall1.Bounds) || picSnakeHead.Bounds.IntersectsWith(lblWall2.Bounds) || picSnakeHead.Bounds.IntersectsWith(lblWall3.Bounds) || picSnakeHead.Bounds.IntersectsWith(lblWall4.Bounds))
            {
                this.Close();
                time_Snake.Stop();
                MessageBox.Show("The snake touched the border! You collected " + appleNum + " apples in total!");
                this.RefToForm1.Visible = true;                
            }

            //Catch apples
            if (picSnakeHead.Bounds.IntersectsWith(picApple.Bounds))
            {
                appleNum++;
                RandomLocation();
            }

            //increase speed
            if (appleNum == 1) time_Snake.Interval = 400;
            else if (appleNum == 2) time_Snake.Interval = 300;
            else if (appleNum == 3) time_Snake.Interval = 250;
            else if (appleNum == 4) time_Snake.Interval = 200;
            else if (appleNum == 5) time_Snake.Interval = 150;
            else if (appleNum == 6) time_Snake.Interval = 100;
            else if (appleNum == 7) time_Snake.Interval = 75;
            else if (appleNum == 8) time_Snake.Interval = 50;
            else if (appleNum == 9) time_Snake.Interval = 25;
            else if (appleNum == 10) time_Snake.Interval = 20;
            else if (appleNum == 11) time_Snake.Interval = 15;
            else if (appleNum == 12) time_Snake.Interval = 10;

            picSnakeHead.Location = new Point(x, y);
        }

        public int getappleNum()
        {
            return appleNum;
        }
    }
}
