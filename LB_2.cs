using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_2_ionova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text; // считывание значеня x
            double x = double.Parse(s); // перевод строки в число
            string v = textBox2.Text; // считывание значеня y
            double y = double.Parse(v); // перевод строки в число
            string w = textBox3.Text; // считывание значеня z
            double z = double.Parse(w); // перевод строки в число
            // вывод значения x в окно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // вывод значения y в окно
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            // вывод значения z в окно
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();



            // вычисление выражения:
            double a = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, (y + 2))));
            double b = (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
            double f = a * b;
            // вывод результат в окно
            textBox4.Text += Environment.NewLine + "Результат B = " + f.ToString();


        }
    }
}
