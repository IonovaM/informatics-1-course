using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_11_ionova
{
    //6. Разработайте программу анимации падения снежинки.

    public partial class Form1 : Form
    {
        static int n = 100;// количество звёзд
        Random r = new Random();
        Random rand = new Random();
        Pen p = new Pen(Color.White);
        int x1, y1;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //cоздание объектов Graphics
            g.DrawLine(p, x1, y1, x1 + 10, y1 + 10);
            g.DrawLine(p, x1, y1 + 10, x1 + 10, y1);
            g.DrawLine(p, x1 + 5, y1 - 2, x1 + 5, y1 + 12);
            g.DrawLine(p, x1 - 2, y1 + 5, x1 + 12, y1 + 5);        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y1 += 3;
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            x1 = rand.Next(2, 700);
            y1 = rand.Next(2, 400);
        }        
    }
}
