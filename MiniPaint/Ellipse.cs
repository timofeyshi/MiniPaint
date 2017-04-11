using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    class Ellipse : Shapes
    {
        private Point SecondPoint;


        public Ellipse(Point firstPoint, Point secondPoint) : base(firstPoint)
        {
            SetSecondPoint(secondPoint);
        }

        public void SetSecondPoint(Point secondPoint)
        {
            SecondPoint = secondPoint;
        }

        public Point GetSecondPoint()
        {
            return SecondPoint;
        }

        public override void Draw(Graphics graphicField)
        {
            // graphicField.DrawEllipse(Pens.Black, GetFirstPoint().GetX(), GetFirstPoint().GetY(), SecondPoint.GetX(), SecondPoint.GetY());
        }
    }
}
