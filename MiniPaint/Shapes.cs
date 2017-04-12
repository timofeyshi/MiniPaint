﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    abstract class Shapes
    {
        private Point FirstPoint;

        public Shapes(Point firstPoint)
        {
            SetFirstPoint(firstPoint);
        }


        public void SetFirstPoint(Point firstPoint)
        {
            this.FirstPoint = firstPoint;
        }

        public Point GetFirstPoint()
        {
            return FirstPoint;
        }

       // abstract public void Draw(Graphics graphicField);

    }
}
