using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        public Form1()
        {
            InitializeComponent();
            gfx =CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.DarkBlue);
            Rectangle rect = new Rectangle(0, 0, 530,290);
            gfx.FillRectangle(brush, rect);
            stars(gfx,30, 40, 20);
            stars(gfx, 250, 25, 20);
            stars(gfx, 400, 70, 20);
            stars(gfx, 480, 100, 20);
            stars(gfx, 450, 150, 20);
            stars(gfx, 420, 250, 20);
            stars(gfx, 30, 200, 20);
            stars(gfx, 250, 220, 20);
            asteroids(gfx, 80, 60);
            asteroids(gfx, 100, 180);
            asteroids(gfx, 450, 80);
            asteroids(gfx, 380, 230);
            bullet(gfx, 280, 65);
            spaceship(gfx, 265, 145);
            gun(gfx, 265, 145);

        }
        public void stars(Graphics gfx, int a, int b, int h)
        {
            SolidBrush brush = new SolidBrush(Color.White);

            gfx.FillEllipse(brush, a, b, h, h);
            
        }
        public void asteroids(Graphics gfx, int a, int b)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            Point point1 = new Point(a, b - 20);
            Point point2 = new Point(a+10, b - 10);
            Point point3 = new Point(a+30, b - 10);
            Point point4 = new Point(a+10, b);
            Point point5 = new Point(a+30, b + 10);
            Point point6 = new Point(a+10, b + 10);
            Point point7 = new Point(a, b + 20);
            Point point8 = new Point(a-10, b + 10);
            Point point9 = new Point(a-30, b + 10);
            Point point10 = new Point(a-10, b);
            Point point11= new Point(a-30, b - 10);
            Point point12 = new Point(a-10, b -10);
            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12 };
            gfx.FillPolygon(brush, points);

        }
        public void bullet(Graphics gfx, int a, int b)
        {
            SolidBrush brush = new SolidBrush(Color.Green);
            Point point1 = new Point(a, b+14);
            Point point2 = new Point(a+3, b + 3);
            Point point3 = new Point(a+14, b);
            Point point4 = new Point(a+3, b -3);
            Point point5 = new Point(a, b - 14);
            Point point6 = new Point(a-3, b -3);
            Point point7 = new Point(a-14, b);
            Point point8 = new Point(a-3, b + 3);
            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8 };
            gfx.FillPolygon(brush, points);
        }
        public void spaceship(Graphics gfx, int a, int b)
        {
            SolidBrush brush = new SolidBrush(Color.Yellow);
            Point point1 = new Point(a, b-40);
            Point point2 = new Point(a+40, b - 20);
            Point point3 = new Point(a+40, b+20);
            Point point4 = new Point(a, b + 40);
            Point point5 = new Point(a-40, b + 20);
            Point point6 = new Point(a-40, b - 20);
            Point[] points = { point1, point2, point3, point4, point5, point6 };
            gfx.FillPolygon(brush, points);
        }
        public void gun(Graphics gfx, int a, int b)
        {
            SolidBrush brush = new SolidBrush(Color.Green);
            Point point1 = new Point(a, b - 20);
            Point point2 = new Point(a+20, b - 5);
            Point point3 = new Point(a+10, b - 5);
            Point point4 = new Point(a+10, b + 20);
            Point point5 = new Point(a-10, b + 20);
            Point point6 = new Point(a-10, b - 5);
            Point point7 = new Point(a-20, b - 5);
            Point[] points = { point1, point2, point3, point4, point5, point6, point7 };
            gfx.FillPolygon(brush, points);
        }
    }
}
