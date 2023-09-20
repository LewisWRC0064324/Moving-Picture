using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 3 < ClientRectangle.Height - pictureBox1.Height && pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 3);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 5 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            }
        }

        private async void buttonR_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X- 5, pictureBox1.Location.Y);
                await Task.Delay(500);
            }
        }

        private void buttonDU_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0 && pictureBox1.Location.X >0)

            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 3);
            }
        }

        private void buttonUR_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0 && pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)

            {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 3);
                }
        }

        private void buttonDR_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 3 < ClientRectangle.Height - pictureBox1.Height && pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 3);
            }
        }
    }
}
