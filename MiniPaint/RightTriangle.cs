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

        private int Width;
        private int Height;

        public RightTriangle(Point firstPoint, int width, int height) : base(firstPoint)
        {
            SetWidth(width);
            SetHeight(height);
        }

        public void SetWidth(int width)
        {
            this.Width = width;
        }

        public void SetHeight(int height)
        {
            this.Height = height;
        }
        public int GetWidth()
        {
            return Width;
        }
        public int GetHeight()
        {
            return Height;
        }

        public override void Draw(Graphics graphicField)
        {
            //  graphicField.DrawLine(Pens.Green, GetFirstPoint().GetX(), GetFirstPoint().GetY(), GetFirstPoint().GetX() + GetWidth(), GetFirstPoint().GetY());
            // graphicField.DrawLine(Pens.Green, GetFirstPoint().GetX(), GetFirstPoint().GetY(), GetFirstPoint().GetX(), GetFirstPoint().GetY() + GetHeight());
            //graphicField.DrawLine(Pens.Green, GetFirstPoint().GetX(), GetFirstPoint().GetY() + GetHeight(), GetFirstPoint().GetX() + GetWidth(), GetFirstPoint().GetY());

        }
    }
}
