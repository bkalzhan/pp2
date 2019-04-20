using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        int a = 0, b = 0, count=0;
        double c = 0;

        private void button19_Click(object sender, EventArgs e)
        {
            b=Convert.ToInt32(textBox1.Text);
            switch (znak)
            {
                case '+': c = a + b;
                    break;
                case '-':c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
                case ')':
                    c = findGCD(a, b);
                    break;
                case '(':
                    c = findLCM(a, b);
                    break;
                default:
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            int k = a;
            for(int i=1; i<=k; i++)
            {
                if (k % i == 0) { count++; }
            }
            textBox1.Text = count.ToString();
            count = 0;
        }

        char znak = '+';

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }
        public int findGCD(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return findGCD(y, x % y);
            }
        }
        int n = 1;
        public int findLCM(int x, int y)
        {
            int max = Math.Max(x, y);
            if(max%x==0 && max % y == 0)
            {
                return max;
            }
            else
            {
                n++;
                return findLCM(n * max, y);
            }
        }
    }
}
