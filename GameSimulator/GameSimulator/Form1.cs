using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameSimulator
{
    public partial class Form1 : Form
    {        
        private int count = 0;
        private MemoryPuzzle puzzle = new MemoryPuzzle();
        private Nibbles snake = new Nibbles();
        private Dodger dodge = new Dodger();

        public Form1()
        {
            InitializeComponent();

            String message = "Please play all three games to win!";
            String caption = "Instructions";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            timeFinish.Start();
        }      
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to restart the Game Simulator?", "Restart", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Restart();                
            }
            else
            {
                this.Close();
            }

            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            puzzle.RefToForm1 = this;
            this.Visible = false;
            puzzle.Show();
            updateCount();
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            btnPlay2.Enabled = false;
            snake.RefToForm1 = this;
            this.Visible = false;
            snake.Show();
            updateCount();
        }

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            btnPlay3.Enabled = false;
            dodge.RefToForm1 = this;
            this.Visible = false;
            dodge.Show();
            updateCount();
        }

        private void timeFinish_Tick(object sender, EventArgs e)
        {            
            if (count == 3 && this.Visible)
            {                
                int timeMemory = puzzle.getSolved();
                int apple = snake.getappleNum();
                int timeDodger = dodge.getTime();
                int rubble = dodge.getDodge();
                int score = 0;

                //determining the score for memorypuzzle                
                score += timeMemory;

                //determining the score for nibble
                score += (int)(2 * (apple));

                //determining the score for dodger
                int data = (int)(33*timeDodger*rubble/500);
                if (data > 0)
                {
                    score += data;
                }               

                count = 0;
                timeFinish.Stop();

                string path = @"C:\Users\DeV_NEN\Desktop\Project\GameSimulator\GameSimulator\Score.txt";
                LinkedList<int> info = new LinkedList<int>();
                int rank = 1;

                if (File.Exists(path))
                {
                    //reading from a text file
                    StreamReader sr = new StreamReader(path);                   
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        info.AddLast(System.Convert.ToInt32(line));
                        line = sr.ReadLine();
                    }                    
                    sr.Close();
                    //Writing to the text file
                    StreamWriter sw = File.AppendText(path);
                    sw.WriteLine(score);
                    sw.Close();
                }

                info.AddLast(score);                

                for (int i = 0; i < info.Count; i++)
                {
                    LinkedListNode<int> node = info.First;
                    info.RemoveFirst();
                    info.AddLast(node);
                    if (node.Value > score) rank++;
                }

                MessageBox.Show("Congratulations! You have completed all the games! Your score is: " + score.ToString() + "! You are ranked " + rank.ToString() + " in our system!");               
            }
        }

        public void updateCount()
        {
            count += 1;
        }
    }
}
