using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormAddAndSubtract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            float first;
            float second;
            float output;
            first = Convert.ToInt32(textBox1.Text);
            second = Convert.ToInt32(textBox2.Text);
            output = first + second;
            textBox3.Text = output.ToString();
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            float first;
            float second;
            float output;
            first = Convert.ToInt32(textBox1.Text);
            second = Convert.ToInt32(textBox2.Text);
            output = first - second;
            textBox3.Text = output.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
