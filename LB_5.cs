using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_5_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 1;
        int m = 1;
        int f = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Создание объекта для генерации чисел по горизонтали
            int rand = rnd.Next(100, 800); //Возвращаем случайное целое число из диапозона

            Random rndm = new Random(); //Создание объекта для генерации чисел по вертикали
            int randm = rndm.Next(100, 500); //Возвращаем случайное целое число из диапозона

            Button b = new Button();
            b.Parent = this;
            b.Location = new Point(rand, randm);
            b.Text = "Кнопка";
            b.Size = new Size(150, 46);

            k++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Создание объекта для генерации чисел по горизонтали
            int rand = rnd.Next(100, 800); //Возвращаем случайное целое число из диапозона

            Random rndm = new Random(); //Создание объекта для генерации чисел по вертикали
            int randm = rndm.Next(100, 500); //Возвращаем случайное целое число из диапозона

            Label lbl = new Label();
            lbl.Parent = this;
            lbl.Location = new Point(rand, randm);
            lbl.Text = "Метка";
            lbl.Size = new Size(83, 32);

            m++;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Создание объекта для генерации чисел по горизонтали
            int rand = rnd.Next(100, 800); //Возвращаем случайное целое число из диапозона

            Random rndm = new Random(); //Создание объекта для генерации чисел по вертикали
            int randm = rndm.Next(100, 500); //Возвращаем случайное целое число из диапозона

            TextBox txt = new TextBox();
            txt.Parent = this;
            txt.Location = new Point(rand, randm);
            txt.Text = "Поле ввода";
            txt.Size = new Size(150, 39);

            f++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На форме " + k + " кнопки (кнопок)" + Environment.NewLine + 
                "На форме " + m + " метки (меток)" + Environment.NewLine + 
                "На форме " + f + " поля (полей)");
        }
    }
}       
