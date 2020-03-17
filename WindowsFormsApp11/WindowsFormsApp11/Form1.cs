using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form

    {
        public bool Flag = true;
        public int temp;
        int a,b;
        public Form1()

        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            temp = 2;
            textBox1.Clear();
            label1.Text = "+";
            Flag = true;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            temp = 3;
            textBox1.Clear();
            label1.Text = "-";
            Flag = true;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            temp = 1;
            label1.Text = "*";
            Flag = true;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            temp = 4;
            textBox1.Clear();
            label1.Text = "/";
            Flag = true;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            actions();
            textBox1.Text = Convert.ToString(b);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = " ";
            Flag = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void actions()
        {
            switch (temp)
            {
                case 1:
                    b = a * int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a + int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a - int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
    }
   }   
