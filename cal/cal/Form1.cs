using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public int Flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            Flag = 0;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Flag == 0)
                label1.Text = Convert.ToString((Convert.ToInt32(textBox1.Text)) + (Convert.ToInt32(textBox2.Text)));
            if (Flag == 1)
                label1.Text = Convert.ToString((Convert.ToInt32(textBox1.Text)) - (Convert.ToInt32(textBox2.Text)));
            if (Flag == 2)
                label1.Text = Convert.ToString((Convert.ToInt32(textBox1.Text)) / (Convert.ToInt32(textBox2.Text)));
            if (Flag == 3)
                label1.Text = Convert.ToString((Convert.ToInt32(textBox1.Text)) * (Convert.ToInt32(textBox2.Text)));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //clear
            textBox1.Text = " ";
            textBox2.Text = " ";
            label1.Text = " ";
            label2.Text = " ";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Flag = 3;
            label2.Text = "*";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Flag = 2;
            label2.Text = "/";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            Flag = 1;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
