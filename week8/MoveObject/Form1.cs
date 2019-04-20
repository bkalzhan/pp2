using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        int x = 0, dx = 10;
        int y = 0, dy=10;


        enum Direction
        {
            None,
            Left,
            Right,
            Up,
            Down
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(brush, x, y, 10, 10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dir = Direction.Right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dir = Direction.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dir = Direction.Up;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dir = Direction.Down;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dir = Direction.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dir == Direction.Right)
            {
                x += dx;
            }
            else if (dir == Direction.Left)
            {
                x -= dx;
            }

            else if (dir == Direction.Up)
            {
                y -= dy;
            }
            else if (dir == Direction.Down)
            {
                y += dy;
            }
            if (x + 55 > Width)
            {
                brush.Color = Color.AliceBlue;
                dx = 0;
            }
            else if (x < 0)
            {
                brush.Color = Color.Black;
                dx = 0;
            }



            if (y + 50 > Height)
            {
                brush.Color = Color.BlueViolet;
                dy = 0;
            }
            else if (y < 0)
            {
                brush.Color = Color.Brown;
                dy = 0;
            }

            Refresh();
        }

        Direction dir;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Red);
            timer1.Enabled = true;
        }
    }
}


