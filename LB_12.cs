using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_12_ionova
{
    /*Создайте функцию, выводящую на изображение треугольник. 
     * Для всех точек вне треугольника оставьте только канал B. 
     * Все точки внутри треугольника переводятся в градации серого цвета.*/

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        Graphics g;
        // Действия при нажатии кнопки загрузки изображения
        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g;
            // Описываем объект класса OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Задаем расширения файлов
            dialog.Filter = "Image files (*.BMP, *.JPG, + *.GIF, *.PNG)| *.bmp; *.jpg; *.gif; *.png";
            // Вызываем диалог и проверяем выбран ли файл
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Invalidate();
                // Загружаем изображение из выбранного файла
                Image image = Image.FromFile(dialog.FileName);
                int width = pictureBox1.Width;
                int height = pictureBox1.Height;
                //pictureBox1.Width = width;
                //pictureBox1.Height = height;
                // Создаем и загружаем изображение в формате bmp
                bmp = new Bitmap(image, width, height);
                // Записываем изображение в pictureBox1
                pictureBox1.Image = bmp;
                // Подготавливаем объект Graphics для рисования
                g = Graphics.FromImage(pictureBox1.Image);
                //this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Pen pen = new Pen(Color.Black, 2);
            Random rnd = new Random();
            Point[] points = new Point[3];
            points[0].X = rnd.Next(10, 100); points[0].Y = rnd.Next(10, 300);
            points[1].X = rnd.Next(100, 300); points[1].Y = rnd.Next(10, 300);
            points[2].X = rnd.Next(300, 500); points[2].Y = rnd.Next(10, 300);
            g.DrawPolygon(pen, points);

     

            // Циклы для перебора всех пикселей на изображении
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int a = (i - points[0].X) * (j - points[1].Y) - (i - points[1].X) * (j - points[0].Y);
                    int b = (i - points[1].X) * (j - points[2].Y) - (i - points[2].X) * (j - points[1].Y);
                    int c = (i - points[2].X) * (j - points[0].Y) - (i - points[0].X) * (j - points[2].Y);

                    if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                    {
                        // Извлекаем в R значение красного цвета
                        int R = bmp.GetPixel(i, j).R;
                        // Извлекаем в G значение зеленого цвета
                        int G = bmp.GetPixel(i, j).G;
                        // Извлекаем в B значение синего цвета
                        int B = bmp.GetPixel(i, j).B;
                        // Высчитываем среднее арифметическое
                        int Gray = (R = G + B) / 3;
                        // Переводим число в значение цвета.
                        // 255 – показывает степень прозрачности.
                        // Остальные значения одинаковы
                        Color p = Color.FromArgb(255, Gray, Gray,
                        Gray);
                        // Записываем цвет в текущую точку
                        bmp.SetPixel(i, j, p);
                        //Console.WriteLine("Принадлежит треугольнику");
                    }
                    else
                    {
                        Color color = bmp.GetPixel(i, j);
                        bmp.SetPixel(i, j, Color.FromArgb(0, 0, color.B));
                        //Console.WriteLine("Не принадлежит треугольнике");
                    }
                }
            // Вызываем функцию перерисовки окна
            Refresh();
        }
    }
} 
