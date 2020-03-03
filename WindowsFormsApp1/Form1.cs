using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = Calculator;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int a, b;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                a = a + b;
                label1.Text = Convert.ToString(a);
            }
            else

            {
                MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    a = a - b;
                    label1.Text = Convert.ToString(a);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    a = a * b;
                    label1.Text = Convert.ToString(a);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)

                {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    if (b == 0)
                        MessageBox.Show(text: "Делить на ноль нелязя!");
                    else
                    {
                        a = a / b;
                        label1.Text = Convert.ToString(a);
                    }
                }

                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
        }
    }
}
