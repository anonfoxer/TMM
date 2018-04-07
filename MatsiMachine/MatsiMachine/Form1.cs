using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatsiMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by anonfoxer.\nInspired by his friend Matsi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input one string in the first box, input another in the second.\nPress the button.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This machine takes the input of the second string and replaces it after every other word in the first input.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please input some text!");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please input some text!");
            }
            /* Will use the rest of this section to figure out how to send the rest of the program to the
             * console, or to Program.cs */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4000;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4000;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://anonhub.weebly.com/other-programs.html");
        }
    }
}
