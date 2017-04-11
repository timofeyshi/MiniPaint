using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint
{
    class Point
    {
        private int X, Y;
        public Point(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        public void SetX(int x)
        {
            this.X = x;

        }

        public void SetY(int y)
        {
            this.Y = y;
        }

        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;

        }
    }
}
