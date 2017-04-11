using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint
{
    class Square : Rectangle
    {
        public Square(Point firstPoint, int width) : base(firstPoint, width, width)
        {


        }

        public void setSide(int side)
        {
            SetWidth(side);
            SetHeight(side);
        }

    }
}
