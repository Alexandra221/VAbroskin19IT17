using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox2.Text.ToUpper().ToString();
            textBox1.Text = a;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox2.Text.ToUpper().ToLower();
            textBox1.Text = a;
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            // Ошибки в строке
            string text = textBox1.Text;
            string[] tr = new string[] { "стеклянный", "оловянный","деревянный" , "Ростов", "Ростислав", "росток" ,"ростовщик", "отрасль","жи", "ши", "ча", "ща", "чу", "щу" };
            string[] fal = new string[] { "стекляный", "оловяный", "деревяный", "Растов", "Растислав", "расток", "растовщик", "отросль", "жы", "шы", "чя", "щя", "чю", "щю" };
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                for (int j = 0; j < fal.Length; j++) // перебирание ошибок
                {
                    try
                    {
                        if (textBox1.Text.Contains(fal[j])) 
                            text = textBox1.Text.Replace(fal[j], tr[j]); // заменяем ошибки
                        textBox1.Text = text;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Строка не может быть пустой!");
                    }

                }
            }
        }

        private void Length_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text.Length.ToString();
            label3.Text = $"Длина строки:{a}";


        }

        private void Substring_CheckedChanged(object sender, EventArgs e)
        {
            {
                string text = textBox1.Text;
                text = textBox1.Text.Substring(7); // извлечение подстроки
                textBox2.Text = text;
            }
        }

        private void Transformation_CheckedChanged(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text.Replace("!", "?");
            textBox2.Text = textBox1.Text;
        }

        private void Errors_CheckedChanged(object sender, EventArgs e)
        {
            {
                int  c= 0;
                int d = 0;
                Char [] vowels = new char[] { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ё', 'ю', 'Е', 'А', 'Е', 'Ы', 'И', 'О', 'У', 'Э', 'Ю', 'Я' };
                Char [] consonants = new char[] { 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п',
                'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б', 'К', 'М', 'Б', 'Г', 'Ш', 'Щ', 'Х', 'Ф', 'З', 'В', 'П',
                'Р', 'Л', 'Ж', 'Д', 'С', 'Ч', 'Ц', 'Т', 'Н'};
                foreach (char s in textBox2.Text)
                {
                    if (vowels.Contains(s))
                    {
                        c++;
                    }
                    if (consonants.Contains(s))
                    {
                        d++;
                    }
                }
                string input = textBox1.Text;
                int a = 0;
                int b = 0;
                for (int i = 0; i < input.Length; i++)
                {

                    if (char.IsLetter(input[i]))
                        a++;
                    if (char.IsDigit(input[i]))
                        b++;
                }
                label4.Text = ("Букв : " + a.ToString());
                label5.Text = ("Цифр : " + b.ToString());
                label6.Text = ("Строк : " + textBox1.Lines.Length);
                label7.Text = ("Гласных : " + c.ToString());
                label8.Text = ("Согласных : " + d.ToString());


            }
        }
    }
}     