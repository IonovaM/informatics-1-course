using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_1_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false; //Первая кнопка становится невидимой
            button3.Visible = false; //Третья кнопка становится невидимой
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true; //Первая кнопка становится видимой
            button2.Visible = false; //Вторая кнопка становится невидимой
            button4.Visible = false; //Четвертая кнопка становится невидимой
            button5.Visible = false; //Пятая кнопка становится невидимой
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true; //Первая кнопка становится видимой
            button2.Visible = true; //Вторая кнопка становится видимой
            button3.Visible = false; //Третья кнопка становится невидимой
            button4.Visible = true; //Четвертая кнопка становится видимой
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false; //Первая кнопка становится невидимой
            button4.Visible = false; //Четвертая кнопка становится невидимой
            button3.Visible = true; //Третья кнопка становится видимой
            button5.Visible = true; //Пятая кнопка становится видимой
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true; //Первая кнопка становится видимой
            button5.Visible = false; //Пятая кнопка становится невидимой
            button2.Visible = false; //Вторая кнопка становится невидимой
            button4.Visible = true; //Четвертая кнопка становится видимой
        }
    }
}
