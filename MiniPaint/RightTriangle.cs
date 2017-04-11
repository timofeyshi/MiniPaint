using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    class RightTriangle : Shapes
    {

        private int width;
        private int height;

        public RightTriangle(Point firstPoint, int width, int height) : base(firstPoint)
        {
            setWidth(width);
            setHeight(height);
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }

        public override void Draw(Graphics graphicField)
        {
            //  graphicField.DrawLine(Pens.Green, GetFirstPoint().GetX(), GetFirstPoint().GetY(), GetFirstPoint().GetX() + GetWidth(), GetFirstPoint().GetY());
            // graphicField.DrawLine(Pens.Green, GetFirstPoint().GetX(), GetFirstPoint().GetY(), GetFirstPoint().GetX(), GetFirstPoint().GetY() + GetHeight());
            //graphicField.DrawLine(Pens.Green, GetFirstPoint().GetX(), GetFirstPoint().GetY() + GetHeight(), GetFirstPoint().GetX() + GetWidth(), GetFirstPoint().GetY());

        }
    }
}
