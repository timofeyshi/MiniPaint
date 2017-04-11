using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    class Rectangle : Shapes
    {
        private int Width;
        private int Height;



        public Rectangle(Point firstPoint, int width, int height) : base(firstPoint)
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

            //     graphicField.DrawRectangle(Pens.Black, GetFirstPoint().GetX(), GetFirstPoint().GetY() ,GetHeight(),  GetWidth());
        }

    }
}
