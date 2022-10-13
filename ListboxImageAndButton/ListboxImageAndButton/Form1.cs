using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxImageAndButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "C:/Users/mbukka/source/repos/ListboxImageAndButton/ListboxImageAndButton/";
            if (listBox1.SelectedIndex == 0)
            {
                label1.Text = "";
                pictureBox1.ImageLocation = path + "images/car.png";
            }else if(listBox1.SelectedIndex == 1)
            {
                label1.Text = "";
                pictureBox1.ImageLocation = path + "images/scooter.jpg";
            }else if(listBox1.SelectedIndex == 2)
            {
                label1.Text = "";
                pictureBox1.ImageLocation = path + "images/bike.jpg";
            }else if(listBox1.SelectedIndex == 3)
            {
                label1.Text = "";
                pictureBox1.ImageLocation = path + "images/scooty.jpg";
            }else if(listBox1.SelectedIndex == 4)
            {
                label1.Text = "";
                pictureBox1.ImageLocation = path + "images/bus.png";
            }
            else
            {
                pictureBox1.ImageLocation = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                label1.Text = "1000";
            }else if(listBox1.SelectedIndex == 1)
            {
                label1.Text = "2000";
            }else if(listBox1.SelectedIndex == 2)
            {
                label1.Text = "3000";
            }else if (listBox1.SelectedIndex == 3)
            {
                label1.Text = "4000";
            }else if(listBox1.SelectedIndex == 4)
            {
                label1.Text = "5000";
            }
            else
            {
                label1.Text = " ";
            }
        }
    }
}
