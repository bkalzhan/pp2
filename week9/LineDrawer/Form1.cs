using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDrawer
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        Pen pen;
        Point pointStart;
        Point pointFinish;
        bool isDrawing;

        public Form1()
        {
            InitializeComponent();
            gfx = this.CreateGraphics();
            pen = new Pen(Color.Black, 20);
            pointStart = new Point();
            pointFinish = new Point();
            isDrawing = false;
        }
        private void solidBrushSolidBrushNewSolidBrushColorFromArgb15922070ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                pen = new Pen(colorDialog1.Color, 20);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            pointStart = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                Rectangle rectangle = new Rectangle(e.Location.X - 10, e.Location.Y - 10, 20, 20);
                gfx.DrawEllipse(pen, rectangle);
            }
            pointStart = e.Location;
        }
    }
}
