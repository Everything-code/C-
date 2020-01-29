using System;
using System.Threading;
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
    public partial class MemoryPuzzle : Form
    {
        public Form RefToForm1 { get; set; }
        private Boolean flag = false;
        private int[] arraynum = new int[16];
        private Button btn = null;
        private int solved = 0;

        public MemoryPuzzle()
        {
            InitializeComponent();       
        }

        private void MemoryPuzzle_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PictureBox[] first = { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16};
            List<int> randomlist = new List<int>();
            int num = 0;
            string card = null;

            for(int i = 0; i<16;i++)
            {
                num = rnd.Next(0, 16);
                if (!randomlist.Contains(num)) {
                    randomlist.Add(num);
                    switch (num)
                    {
                        case 0:
                        case 1:
                            card = "pencil";
                            arraynum[i] = 1;
                            break;
                        case 2:
                        case 3:
                            card = "book";
                            arraynum[i] = 2;
                            break;
                        case 4:
                        case 5:
                            card = "notebook";
                            arraynum[i] = 3;
                            break;
                        case 6:
                        case 7:
                            card = "console";
                            arraynum[i] = 4;
                            break;
                        case 8:
                        case 9:
                            card = "phone";
                            arraynum[i] = 5;
                            break;
                        case 10:
                        case 11:
                            card = "printer";
                            arraynum[i] = 6;
                            break;
                        case 12:
                        case 13:
                            card = "eraser";
                            arraynum[i] = 7;
                            break;
                        default:
                            card = "cpu";
                            arraynum[i] = 8;
                            break;
                    }
                    first[i].Image = Image.FromFile(@"C:\Users\DeV_NEN\Desktop\Project\GameSimulator\GameSimulator\Properties\" + card + ".jpg");                    
                }
                else
                {
                    i--;
                }                    
            }
            lblTimeDisplay.Text = "20";
            MessageBox.Show("Solve the memory puzzle before the timer hits 0!");
            time_Memory.Start();
        }

        private void btnClick1_Click(object sender, EventArgs e)
        {
            Button button = btnClick1;
            PictureBox pic = pic1;            
            checkformatch(button, pic);                        
        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            Button button = btnClick2;
            PictureBox pic = pic2;                        
            checkformatch(button, pic);
        }

        private void btnClick3_Click(object sender, EventArgs e)
        {
            Button button = btnClick3;
            PictureBox pic = pic3;
            checkformatch(button, pic);
        }

        private void btnClick4_Click(object sender, EventArgs e)
        {
            Button button = btnClick4;
            PictureBox pic = pic4;
            checkformatch(button, pic);
        }

        private void btnClick5_Click(object sender, EventArgs e)
        {
            Button button = btnClick5;
            PictureBox pic = pic5;
            checkformatch(button, pic);
        }

        private void btnClick6_Click(object sender, EventArgs e)
        {
            Button button = btnClick6;
            PictureBox pic = pic6;
            checkformatch(button, pic);
        }

        private void btnClick7_Click(object sender, EventArgs e)
        {
            Button button = btnClick7;
            PictureBox pic = pic7;
            checkformatch(button, pic);
        }

        private void btnClick8_Click(object sender, EventArgs e)
        {
            Button button = btnClick8;
            PictureBox pic = pic8;
            checkformatch(button, pic);
        }

        private void btnClick9_Click(object sender, EventArgs e)
        {
            Button button = btnClick9;
            PictureBox pic = pic9;
            checkformatch(button, pic);
        }

        private void btnClick10_Click(object sender, EventArgs e)
        {
            Button button = btnClick10;
            PictureBox pic = pic10;
            checkformatch(button, pic);
        }

        private void btnClick11_Click(object sender, EventArgs e)
        {
            Button button = btnClick11;
            PictureBox pic = pic11;
            checkformatch(button, pic);
        }

        private void btnClick12_Click(object sender, EventArgs e)
        {
            Button button = btnClick12;
            PictureBox pic = pic12;
            checkformatch(button, pic);
        }

        private void btnClick13_Click(object sender, EventArgs e)
        {
            Button button = btnClick13;
            PictureBox pic = pic13;
            checkformatch(button, pic);
        }

        private void btnClick14_Click(object sender, EventArgs e)
        {
            Button button = btnClick14;
            PictureBox pic = pic14;
            checkformatch(button, pic);
        }

        private void btnClick15_Click(object sender, EventArgs e)
        {
            Button button = btnClick15;
            PictureBox pic = pic15;
            checkformatch(button, pic);
        }

        private void btnClick16_Click(object sender, EventArgs e)
        {
            Button button = btnClick16;
            PictureBox pic = pic16;
            checkformatch(button, pic);
        }

        private void checkformatch(Button button, PictureBox pic)
        {
            Button[] all = { btnClick1, btnClick2, btnClick3, btnClick4, btnClick5, btnClick6, btnClick7, btnClick8, btnClick9, btnClick10, btnClick11, btnClick12, btnClick13, btnClick14, btnClick15, btnClick16};
            PictureBox[] picture = { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16 };
            int value = 0;

            button.Visible = false;

            if (flag)
            {
                flag = false;                
                for (int i = 0; i < 16; i++)
                {
                    if (button == all[i])
                    {
                        value = i;
                        break;
                    }
                }                
                for (int i = 0; i < 16; i++)
                {
                    if (btn == all[i])
                    {
                        if (!(arraynum[value] == arraynum[i]))
                        {
                            btn.Visible = true;                     
                            button.Visible = true;
                        }
                        break;
                    }
                }
                btn = null;
            }
            else
            {
                flag = true;
                btn = button;
            }
            checkfinished();
        }

        private void checkfinished()
        {
            Button[] all = { btnClick1, btnClick2, btnClick3, btnClick4, btnClick5, btnClick6, btnClick7, btnClick8, btnClick9, btnClick10, btnClick11, btnClick12, btnClick13, btnClick14, btnClick15, btnClick16 };
            Boolean done = false;
            for (int i = 0; i < 16; i++)
            {
                if (all[i].Visible)
                {
                    done = false;
                    break;
                }
                done = true;
            }

            if (done)
            {
                this.Close();
                time_Memory.Stop();
                solved = 33;             
                MessageBox.Show("Congratulations! You just completed the memory puzzle!");
                this.RefToForm1.Visible = true;
            }

        }

        private void time_Memory_Tick(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = ((Int32.Parse(lblTimeDisplay.Text)) - 1).ToString() ;
            if (lblTimeDisplay.Text == "0")
            {
                this.Close();
                time_Memory.Stop();

                Button[] all = { btnClick1, btnClick2, btnClick3, btnClick4, btnClick5, btnClick6, btnClick7, btnClick8, btnClick9, btnClick10, btnClick11, btnClick12, btnClick13, btnClick14, btnClick15, btnClick16 };
                solved = 0;

                for (int i = 0; i < 16; i++)
                {
                    if (!all[i].Visible) solved += 2;
                }

                MessageBox.Show("The time is up!");
                this.RefToForm1.Visible = true;
            }
        }

        private void ms_delay(Button button)
        {
            var start = DateTime.Now;
            TimeSpan ts = TimeSpan.FromSeconds(1);

            while (DateTime.Now < start + ts)
            {
                button.Visible = false;
            }
        }

        public int getSolved()
        {
            return solved;
        }

        
    }
}

