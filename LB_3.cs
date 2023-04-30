using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_3_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = 0;

            // Получение исходных данных из TextBox
            double x = double.Parse(textBox1.Text); // считывание значеня x с переводом строки в число
            double b = double.Parse(textBox2.Text); // считывание значеня b с переводом строки в число

            // Вывод исходных данных в окно результатов
            // вывод значения x в окно
            textBox4.Text += Environment.NewLine + "При X = " + x.ToString();
            // вывод значения b в окно
            textBox4.Text += Environment.NewLine + "При b = " + b.ToString();

            if (radioButton1.Checked)
            {
                //MessageBox.Show("Выбрана функция: гиперболический синус");
                f = Math.Sinh(x);
            }
            else if (radioButton2.Checked)
            {
                //MessageBox.Show("Выбрана функция: х в квадрате");
                f = Math.Pow(x, 2);
            }
            else if (radioButton3.Checked)
            {
                //MessageBox.Show("Выбрана функция: экспонента в степени х");
                f = Math.Exp(x);
            }

            // Вычисление выражения
            double g;
            if ((0.5 < x * b) && (x * b < 10))
                g = Math.Exp(f - Math.Abs(b));
            else
            if ((0.1 < x * b) && (x * b < 0.5))
            g = Math.Sqrt(Math.Abs(f + b));
            else
                g = 2 * Math.Pow(f, 2);

            // Вывод результата
            textBox4.Text += Environment.NewLine + "g = " + g.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
        }
    }
}
