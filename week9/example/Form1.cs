using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Form1 : Form
    {
        Point point1;
        Point point2;
        Point pointStart;
        Pen pen;
        Graphics gfx;
        bool is1;

        public Form1()
        {
            InitializeComponent();
            point1 = new Point();
            point2 = new Point();
            pointStart = new Point();
            pen = new Pen(Color.Red, 1);
            gfx = this.CreateGraphics();
            is1 = false;
        }

         private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
            is1 =! is1;
            if (is1)
            {
                point1 = e.Location;
            }
            else
            {
                point2 = e.Location;

                int absWidth = Math.Abs(point2.X - point1.X);
                int absHeight = Math.Abs(point2.Y - point1.Y);

                pointStart.X = Math.Min(point1.X, point2.X);
                pointStart.Y = Math.Min(point1.Y, point2.Y);
                /*  if (point1.X<point2.X && point1.Y < point2.Y)
                  {
                      pointStart.X = point1.X;
                      pointStart.Y = point1.Y;
                  }
                  else if (point1.X > point2.X && point1.Y > point2.Y)
                  {
                      pointStart.X = point2.X;
                      pointStart.Y = point2.Y;
                  }
                  else if (point1.X < point2.X && point1.Y > point2.Y)
                  {
                      pointStart.X = point1.X;
                      pointStart.Y = point2.Y;
                  }
                  else// if (point1.X > point2.X && point1.Y > point2.Y)
                  {
                      pointStart.X = point2.X;
                      pointStart.Y = point1.Y;
                  }*/

                Rectangle rectangle;
                rectangle = new Rectangle(pointStart.X, pointStart.Y, absWidth, absHeight);

                gfx.DrawRectangle(pen, rectangle);
                gfx.DrawEllipse(pen, rectangle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(15, 220, 70));
            gfx.FillEllipse(solidBrush, 20, 20, 100, 150);
        }
    }
}
