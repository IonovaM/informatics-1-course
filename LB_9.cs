using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_7_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] array1 = new double[16];

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); //Создание объекта для генерации чисел
            for (int i = 0; i < 16; i++)
            {
                array1[i] = rand.Next(-50, 50); //Возвращаем случайное целое число из диапозона
                listBox1.Items.Add("array[" + i.ToString() + "] = " + array1[i].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double di;
            for (int i = 0; i < 16; i++)
            {
                double x = Math.Exp(array1[i]) + 2 * Math.Exp(-array1[i]);
                double y = Math.Sqrt(5 + Math.Sin(array1[i]));
                di = x / y;
                if (di > 0.1)
                    listBox2.Items.Add("di = " + Convert.ToString(di));
            }
        }
    }
}       
