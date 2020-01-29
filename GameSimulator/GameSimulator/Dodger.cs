using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSimulator
{
    public partial class Dodger : Form
    {
        public Form RefToForm1 { get; set; }
        private int obstacle = 0;
        private int dodged = 0;
        private int time = 0;
        private LinkedList<Label> listingSlowest = new LinkedList<Label>();
        private LinkedList<Label> listingSlow = new LinkedList<Label>();
        private LinkedList<Label> listingFast = new LinkedList<Label>();
        private LinkedList<Label> listingFastest = new LinkedList<Label>();

        public Dodger()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Dodger_KeyDown);
        }

        private void Dodger_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dodge the cubes!");
            lblDodger.Location = new Point(0, 570);
            timeChecker.Start();
            timeGetObstacle.Start();
            timeSlowest.Start();
            timeSlow.Start();
            timeFast.Start();
            timeFastest.Start();
            timeUpdate.Start();
        }

        private void Dodger_KeyDown(object sender, KeyEventArgs e)
        {
            int x = lblDodger.Location.X;
            int y = lblDodger.Location.Y;

            if (e.KeyCode == Keys.Right && x < 376) x += 5;            
            else if (e.KeyCode == Keys.Left && x > 4) x -= 5;

            lblDodger.Location = new Point(x, y);
        }

        private void timeSlowest_Tick(object sender, EventArgs e)
        {
                     
            
            if (listingSlowest.Count() > 0)
            {
                for (int i = 0; i < listingSlowest.Count; i++)
                {
                    LinkedListNode < Label> newLabel = listingSlowest.First;
                    if (newLabel.Value.Location.Y > 600)
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 5);
                        listingSlowest.RemoveFirst();
                        dodged++;
                    }
                    else
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 5);
                        listingSlowest.RemoveFirst();
                        listingSlowest.AddLast(newLabel);
                    }                    
                }
            }

        }

        private void timeSlow_Tick(object sender, EventArgs e)
        {
            if (listingSlow.Count() > 0)
            {
                for (int i = 0; i < listingSlow.Count; i++)
                {
                    LinkedListNode<Label> newLabel = listingSlow.First;
                    if (newLabel.Value.Location.Y > 600)
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 10);
                        listingSlow.RemoveFirst();
                        dodged++;
                    }
                    else
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 10);
                        listingSlow.RemoveFirst();
                        listingSlow.AddLast(newLabel);
                    }                    
                }
            }
        }

        private void timeFast_Tick(object sender, EventArgs e)
        {
            if (listingFast.Count() > 0)
            {
                for (int i = 0; i < listingFast.Count; i++)
                {
                    LinkedListNode<Label> newLabel = listingFast.First;
                    if (newLabel.Value.Location.Y > 600)
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 15);
                        listingFast.RemoveFirst();
                        dodged++;
                    }
                    else
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 15);
                        listingFast.RemoveFirst();
                        listingFast.AddLast(newLabel);
                    }                    
                }
            }
        }

        private void timeFastest_Tick(object sender, EventArgs e)
        {
            if (listingFastest.Count() > 0)
            {
                for (int i = 0; i < listingFastest.Count; i++)
                {
                    LinkedListNode<Label> newLabel = listingFastest.First;
                    if (newLabel.Value.Location.Y > 600)
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 20);
                        listingFastest.RemoveFirst();
                        dodged++;
                    }
                    else
                    {
                        newLabel.Value.Location = new Point(newLabel.Value.Location.X, newLabel.Value.Location.Y + 20);
                        listingFastest.RemoveFirst();
                        listingFastest.AddLast(newLabel);
                    }                    
                }
            }
        }

        private void timeGetObstacle_Tick(object sender, EventArgs e)
        {           
            if(timeGetObstacle.Interval > 400)
            {
                timeGetObstacle.Interval = timeGetObstacle.Interval - 200;
            }            

            if (obstacle % 5  == 0) {
                Random rnd = new Random();
                Label newBox = new Label();
                Size area = new Size(rnd.Next(20,61),rnd.Next(20,61));
                obstacle++;
                newBox.AutoSize = false;
                newBox.Text = "";
                newBox.Size = area;
                newBox.BackColor = System.Drawing.Color.Gray;
                newBox.Location = new Point(rnd.Next(0, 381), 0);
                newBox.Name = "lblObstacle" + obstacle.ToString();
                this.Controls.Add(newBox);
                listingFastest.AddLast(newBox);
            }
            else if(obstacle % 3 == 0)
            {
                Random rnd = new Random();
                Label newBox = new Label();
                Size area = new Size(rnd.Next(20, 61), rnd.Next(20, 61));
                obstacle++;
                newBox.AutoSize = false;
                newBox.Text = "";
                newBox.Size = area;
                newBox.BackColor = System.Drawing.Color.Gray;
                newBox.Location = new Point(rnd.Next(0, 381), 0);
                newBox.Name = "lblObstacle" + obstacle.ToString();
                this.Controls.Add(newBox);
                listingFast.AddLast(newBox);
            }
            else if (obstacle % 2 == 0)
            {
                Random rnd = new Random();
                Label newBox = new Label();
                Size area = new Size(rnd.Next(20, 61), rnd.Next(20, 61));
                obstacle++;
                newBox.AutoSize = false;
                newBox.Text = "";
                newBox.Size = area;
                newBox.BackColor = System.Drawing.Color.Gray;
                newBox.Location = new Point(rnd.Next(0, 381), 0);
                newBox.Name = "lblObstacle" + obstacle.ToString();
                this.Controls.Add(newBox);
                listingSlow.AddLast(newBox);
            }
            else
            {
                Random rnd = new Random();
                Label newBox = new Label();
                Size area = new Size(rnd.Next(20, 61), rnd.Next(20, 61));
                obstacle++;
                newBox.AutoSize = false;
                newBox.Text = "";
                newBox.Size = area;
                newBox.BackColor = System.Drawing.Color.Gray;
                newBox.Location = new Point(rnd.Next(0, 381), 0);
                newBox.Name = "lblObstacle" + obstacle.ToString();
                this.Controls.Add(newBox);
                listingSlowest.AddLast(newBox);
            }
        }

        private void timeChecker_Tick(object sender, EventArgs e)
        {
            //Checking for intersect
            for (int i = 0; i < listingSlowest.Count; i++)
            {
                LinkedListNode<Label> newLabel = listingSlowest.First;
                listingSlowest.RemoveFirst();
                listingSlowest.AddLast(newLabel);
                if (lblDodger.Bounds.IntersectsWith(newLabel.Value.Bounds))
                {
                    Finished();
                }                    
            }

            //Checking for intersect
            for (int i = 0; i < listingSlow.Count; i++)
            {
                LinkedListNode<Label> newLabel = listingSlow.First;
                listingSlow.RemoveFirst();
                listingSlow.AddLast(newLabel);
                if (lblDodger.Bounds.IntersectsWith(newLabel.Value.Bounds))
                {
                    Finished();
                }
            }

            //Checking for intersect
            for (int i = 0; i < listingFast.Count; i++)
            {
                LinkedListNode<Label> newLabel = listingFast.First;
                listingFast.RemoveFirst();
                listingFast.AddLast(newLabel);
                if (lblDodger.Bounds.IntersectsWith(newLabel.Value.Bounds))
                {
                    Finished();
                }
            }

            //Checking for intersect
            for (int i = 0; i < listingFastest.Count; i++)
            {
                LinkedListNode<Label> newLabel = listingFastest.First;
                listingFastest.RemoveFirst();
                listingFastest.AddLast(newLabel);
                if (lblDodger.Bounds.IntersectsWith(newLabel.Value.Bounds))
                {
                    Finished();
                }
            }

        }


        private void Finished()
        {
            timeChecker.Stop();
            timeGetObstacle.Stop();
            timeSlowest.Stop();
            timeSlow.Stop();
            timeFast.Stop();
            timeFastest.Stop();
            timeUpdate.Stop();
            this.Close();
            MessageBox.Show("You successfully dodged " + dodged + " objects in " + time + " seconds!");
            this.RefToForm1.Visible = true;
        }

        private void timeUpdate_Tick(object sender, EventArgs e)
        {
            time++;
        }

        public int getTime()
        {
            return time;
        }

        public int getDodge()
        {
            return dodged;
        }
    }
}
