using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionOfCars
{
    class Obj
    {

        public Obj()
        {
            
        }
        public Rectangle GetRectangle(int x, int y, int n, int m)
        {
            Rectangle rect = new Rectangle(x, y, n, m);
            return rect;
        }
    }
}
