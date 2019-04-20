using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath gp;
        // int x = 0, y = 100;

        SolidBrush pen = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        int x = 0, y = 400;

        public void Draw()
        {
            Pen pen = new Pen(Color.Red, 5);
            gp = new GraphicsPath();
            g.Clear(Color.White);
            /*g.DrawLine(pen, x, y, x + 100, y - 100);
            g.DrawLine(pen, x + 100, y - 100, x + 200, y);
            g.DrawLine(pen, x + 200, y, x + 100, y + 100);
            g.DrawLine(pen, x + 100, y + 100, x, y); */
            g.DrawEllipse(pen, 700, 50, 50, 50);
            g.DrawLine(pen, x, y, x + 20, y - 20);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //gp.AddRectangle(new Rectangle(300, 200, 50, 50));
            //g.DrawEllipse(new Pen(Color.Gray, 5), 250, 200, 100, 100);
            //g.DrawRectangle(new Pen(Color.Gray, 5), 215, 230, 100, 100);
            //g.DrawLine(new Pen(Color.Gray, 5), 100, 200, 300, 350);
            //g.DrawPath(new Pen(Color.Black, 5), gp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            y -= 5;
            Draw();
        }
    }
}