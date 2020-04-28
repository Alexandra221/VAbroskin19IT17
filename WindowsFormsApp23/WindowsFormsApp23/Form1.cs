using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Low_activity = 0.30;
        double Average_activity = 0.45;
        double High_activity = 0.60;
        double a;
        double b;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void recordingdata_TextChanged(object sender, EventArgs e)
        {
            //Запись данных
            FileStream text_1 = new FileStream("C:\\text_1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(text_1);
            writer.Write("Необходимое количество воды: " + textBox2.Text);
            writer.Close();
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Low_activity + a*0.04;
                textBox2.Text = b.ToString();
            }


            else if (this.checkBox2.Checked)
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Average_activity + a *0.04;
                textBox2.Text = b.ToString();

            }

            else if (this.checkBox3.Checked)
            {
                a = Convert.ToInt32(textBox1.Text);
                b = High_activity + a *0.04;
                textBox2.Text = b.ToString();

            }

        }

        private void data_Click(object sender, EventArgs e)
        {
            // Считывание данных
            FileStream text_2 = new FileStream("C:\\text_2.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(text_2);
            textBox1.Text = reader.ReadToEnd();
            reader.Close();
        }
    }
}
