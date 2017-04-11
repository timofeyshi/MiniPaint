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
        private Point secondPoint;


        public Ellipse(Point firstPoint, Point secondPoint) : base(firstPoint)
        {
            setSecondPoint(secondPoint);
        }

        public void setSecondPoint(Point secondPoint)
        {
            this.secondPoint = secondPoint;
        }

        public Point getSecondPoint()
        {
            return secondPoint;
        }

        public override void Draw(Graphics graphicField)
        {
            // graphicField.DrawEllipse(Pens.Black, GetFirstPoint().GetX(), GetFirstPoint().GetY(), SecondPoint.GetX(), SecondPoint.GetY());
        }
    }
}
