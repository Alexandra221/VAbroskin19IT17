using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public bool Flag = true;
        public int temp;
        int a;
        double b;
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seven(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void one(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void two (object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void three(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void four (object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void five(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void six(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void eight(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void nine(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void equal(object sender, EventArgs e)
        {
            actions();
            textBox1.Text = Convert.ToString(b);
        }

        private void cleaning(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = " ";
            Flag = true;
        }

        private void plus(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 1;
                textBox1.Clear();
                label1.Text = "+";
                Flag = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Incorrect form!";
            }
        }

        private void minus(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 2;
                textBox1.Clear();
                label1.Text = "-";
                Flag = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Incorrect form!";
            }
        }

        private void multiplication(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 3;
                textBox1.Clear();
                label1.Text = "*";
                Flag = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Incorrect form!";
            }

        }

        private void division(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                temp = 4;
                textBox1.Clear();
                label1.Text = "/";
                Flag = true;
            }
            catch (FormatException)
            {
                textBox1.Text = "Incorrect form!";
            }
        }

        private void square_root(object sender, EventArgs e)
        {
            try
            {

                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 5;
            }
            catch (FormatException)
            {
                label1.Text = "Error!";
            }
            finally
            {
                label2.Text = $"√{a}";
            }
        }

        private void sin (object sender, EventArgs e)
        {
            try
            {

                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 6;
            }
            catch (FormatException)
            {
                label1.Text = "Error!";
            }
            finally
            {
                label2.Text = $"sin{a}";
            }
        }

        private void cos(object sender, EventArgs e)
        {
            try
            {

                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 7;
            }
            catch (FormatException)
            {
                label1.Text = "Error!";
            }
            finally
            {
                label2.Text = $"cos{a}";
            }
        }

        private void tg (object sender, EventArgs e)
        {
            try
            {

                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 8;
            }
            catch (FormatException)
            {
                label1.Text = "Error!";
            }
            finally
            {
                label2.Text = $"tg{a}";
            }
        }

        private void log(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 10;
            }
            catch (FormatException)
            {
                label1.Text = "Error!";// исключение на ввод букв
            }
            finally
            {
                label2.Text = $"log{a}";
            }
        }

        private void square(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                temp = 9;
            }
            catch (FormatException)
            {
                label1.Text = "Error!"; // исключение на ввод букв
            }
            finally
            {
                label2.Text = $"{a}^2";
            }


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
   

        private void zero(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void actions()// Равно
        {
            switch (temp)
            {

                case 1:
                    {
                        b = a + int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 2:
                    {
                        b = a - int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 3:
                    {
                        b = a * int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 4:
                    try
                    {
                        b = a / int.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (DivideByZeroException) // Деление на ноль
                    {
                        label1.Text = "Division by zero.";
                    }
                    finally
                    {

                    }
                    break;
                case 5:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Sin(a);
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Cos(a);
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = Math.Pow(a, 2);
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = Math.Log(a);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }


    } 
 }
