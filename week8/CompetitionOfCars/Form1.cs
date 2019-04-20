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

namespace CompetitionOfCars
{
    public partial class Form1 : Form
    {
        bool isLeftSide;
        bool isBottomSide;
        Graphics g;
        GraphicsPath gp;
        Pen pen = new Pen(Color.Blue, 5);

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            gp = new GraphicsPath();
        }
        int x = 0, y = 2;
        public void Moving()
        {
            g.Clear(Color.Red);
            g.DrawEllipse(pen, x, y, 5, 5);
        }

        public Rectangle GetRectangle(int x, int y)
        {
            Rectangle rect = new Rectangle(x, y, 5, 5);
            return rect;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x <500 && y==2)
            {
                g.Clear(Color.White);
                x += 10;
                y = 2;
                g.DrawEllipse(pen, GetRectangle(x, y));
                
            }
            if (x == 500 && y <200)
            {
                g.Clear(Color.White);
                x =500;
                y +=10;
                g.DrawEllipse(pen, GetRectangle(x, y));
            }
            if (x>0 && y==200)
            {
                g.Clear(Color.White);
                x-=10;
                y=200;
                g.DrawEllipse(pen, GetRectangle(x, y));
            }
            
        }
    }
}
