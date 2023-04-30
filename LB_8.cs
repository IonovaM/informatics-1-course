using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_8_ionova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] array1 = new int[4, 3]; // Инициализируем массив
        private void button1_Click(object sender, EventArgs e)
        {
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            dataGridView1.RowCount = 4; // Кол-во строк
            dataGridView1.ColumnCount = 3; // Кол-во столбцов
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = array1[i, j].ToString();
                    // подгон ширины столбцов под размер содержимого
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count1 = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (array1[i, j] > 0)
                        count1++;
                }

            listBox2.Items.Add("Количество положительных элементов = " + count1.ToString());
        }
    }
}       
