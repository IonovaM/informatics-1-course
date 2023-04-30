using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_6_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = (string)listBox1.Items[0]; //приводим объекты items к строке
            int len = str.Length; // получаем длину строки
            int count1 = 0; //счетчик нужных букв
            int i = 0; //счетчик индексов строки
            // перебираем все символы из строки
            while (i < len)
            {
                if ((str[i] > 'а') && (str[i] < 'я')) // определяем, является ли буква русской строчной
                    count1++;
                i++;
            }
            label1.Text = "Количество строчных русских букв = " + count1.ToString();
        }
    }
}       
