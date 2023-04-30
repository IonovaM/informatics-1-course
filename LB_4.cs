using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_4_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x0 = double.Parse(textBox1.Text); // считывание значеня x0 с переводом строки в число
            double xk = double.Parse(textBox2.Text); // считывание значеня xk с переводом строки в число
            double dx = double.Parse(textBox3.Text); // считывание значеня dx с переводом строки в число
            double b = double.Parse(textBox4.Text); // считывание значеня b с переводом строки в число
            while (x0 >= xk)
            {
                double y = Math.Pow(x0, 2) + Math.Tan(5 * x0 + b / x0);
                    textBox5.Text += "x = " + Convert.ToString(x0) + "\t" + "y(x) = " + Convert.ToString(y) + Environment.NewLine;
                x0 += dx;
            }

        }
    }
}