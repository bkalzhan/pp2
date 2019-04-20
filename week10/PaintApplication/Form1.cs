using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApplication
{
    enum Tool
    {
        Pencil,
        Rubber,
        Rectangle,
        Triangle,
        Ellipse,
        Fill,
        Star,
        Line
    }

    enum BitmapMode
    {
        New,
        File
    }
    public partial class Form1 : Form
    {
        Point startPoint = default(Point);
        Point finishPoint = default(Point);
        Pen pen;
        Bitmap bitmap;
        BitmapMode bitmapMode = default(BitmapMode);
        Tool activeTool = default(Tool);
        Color activeColor = Color.Black;
        Graphics gfx;
        float toolWidth = default(float);
        int count = 0;
        bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();
            toolWidth = float.Parse(numericUpDown1.Value.ToString());
            pen = new Pen(activeColor, toolWidth);
            bitmapMode = BitmapMode.New;
            SetUpPictureBox();

        }

        private void SetUpPictureBox()
        {
            if (bitmapMode == BitmapMode.New)
            {
                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            else if (bitmapMode ==BitmapMode.File)
            {
                bitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
            }
            gfx = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }

        private Rectangle GetRectangle()
        {
            Rectangle rect = new Rectangle(
                Math.Min(startPoint.X, finishPoint.X), Math.Min(startPoint.Y, finishPoint.Y),
                Math.Abs(startPoint.X - finishPoint.X), Math.Abs(startPoint.Y - finishPoint.Y));
            return rect;
        }
       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            toolWidth = float.Parse(numericUpDown1.Value.ToString());
            pen.Width = toolWidth;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmapMode = BitmapMode.File;
                SetUpPictureBox();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                activeColor = colorDialog1.Color;
                pen.Color = activeColor;
            }
        }

        private void pencilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pencil;
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Fill;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Rectangle;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Triangle;
        }

        private void rubberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Rubber;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Ellipse;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Line;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Star;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;

            switch (activeTool)
            {
                case Tool.Pencil:
                    isDrawing = true;
                    break;
                case Tool.Rubber:
                    isDrawing = true;
                    break;
                case Tool.Rectangle:
                    break;
                case Tool.Triangle:
                    break;
                case Tool.Ellipse:
                    break;
                case Tool.Fill:
                    FloodFill floodFill = new FloodFill(ref bitmap, e.Location);
                    floodFill.Fill(activeColor);
                    break;
                case Tool.Star:
                    break;
                case Tool.Line:
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                finishPoint = e.Location;

                switch (activeTool)
                {
                    case Tool.Pencil:
                        if (isDrawing)
                        {
                            RectangleF rect1 = new RectangleF(e.Location.X - pen.Width / 2, e.Location.Y - pen.Width / 2, pen.Width, pen.Width);
                            gfx.DrawEllipse(pen, rect1);
                        }
                        startPoint = e.Location;
                        break;
                    case Tool.Rubber:
                        if (isDrawing)
                        {
                            Pen pen1 = new Pen(Color.White, toolWidth);
                            RectangleF rect1 = new RectangleF(e.Location.X - pen.Width / 2, e.Location.Y - pen.Width / 2, pen.Width, pen.Width);
                            gfx.DrawEllipse(pen1, rect1);
                        }
                        startPoint = e.Location;
                        break;
                    case Tool.Rectangle:
                        break;
                    case Tool.Triangle:
                        break;
                    case Tool.Ellipse:
                        break;
                    case Tool.Fill:
                        break;
                    case Tool.Star:
                        break;
                    case Tool.Line:
                        break;
                    default:
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            finishPoint = e.Location;

            switch (activeTool)
            {
                case Tool.Pencil:
                    isDrawing = false;
                    break;
                case Tool.Rubber:
                    isDrawing = false;
                    break;
                case Tool.Rectangle:
                    gfx.DrawRectangle(pen, GetRectangle());
                    break;
                case Tool.Triangle:
                    break;
                case Tool.Ellipse:
                    gfx.DrawEllipse(pen, GetRectangle());
                    break;
                case Tool.Fill:
                    break;
                case Tool.Star:
                    break;
                case Tool.Line:
                    gfx.DrawLine(pen, startPoint, finishPoint);
                    break;
                default:
                    break;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = count++.ToString();

            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Rubber:
                    break;
                case Tool.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle());
                    break;
                case Tool.Triangle:

                    break;
                case Tool.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle());
                    break;
                case Tool.Fill:
                    break;
                case Tool.Star:
                    break;
                case Tool.Line:
                    e.Graphics.DrawLine(pen, startPoint, finishPoint);
                    break;
                default:
                    break;
            }
        }
    }
}
