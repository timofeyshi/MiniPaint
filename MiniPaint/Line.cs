﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    class Line : Shapes
    {
        private Point secondPoint;

        public Line(Point firstPoint, Point secondPoint) : base(firstPoint)
        {
            this.secondPoint = secondPoint;
        }

        public Point getSecondPoint()
        {
            return secondPoint;
        }

        public void setSecondPoint(Point secondPoint)
        {
            this.secondPoint = secondPoint;
        }

        public override void Draw(Graphics graphicField)
        {
            graphicField.DrawLine(Pens.Black, GetFirstPoint().getX(), GetFirstPoint().getY(), secondPoint.getX(), secondPoint.getY());
        }
    }
}
