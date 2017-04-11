using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint
{
    class Circle : Ellipse
    {
        public Circle(Point center, int r) : base(new Point(center.GetX(), center.GetY()), new Point(center.GetX() + r, center.GetY() + r))
        {

        }

        public void setSize(int size)
        {
            SetSecondPoint(new Point(GetFirstPoint().GetX() + size, GetFirstPoint().GetY() + size));
        }
        public int getSize()
        {
            int size = GetSecondPoint().GetX() - GetFirstPoint().GetX();
            return size;
        }

    }
}
