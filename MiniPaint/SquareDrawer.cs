﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    class SquareDrawer : FigureDrawer
    {
        Square square;


        private bool ownMouseDown = false;
        Bitmap bitmap, tempBitmap;


        public void setBmp(Bitmap bmp)
        {
            this.bitmap = bmp;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {

            tempBitmap = (Bitmap)bitmap.Clone();
            Graphics temp = Graphics.FromImage(tempBitmap);
            //DrawRectangle(Pens.Black, rectangle.GetFirstPoint().GetX(), rectangle.GetFirstPoint().GetY(), rectangle.GetHeight(), rectangle.GetWidth());
            temp.DrawRectangle(Pens.Black, square.GetFirstPoint().getX(), square.GetFirstPoint().getY(), square.getHeight(), square.getWidth());

            e.Graphics.DrawImageUnscaled(tempBitmap, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {

                square.setWidth(e.Y - square.GetFirstPoint().getY());
                square.setHeight(e.Y - square.GetFirstPoint().getY());


            }
        }


        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            ownMouseDown = false;
            bitmap = (Bitmap)tempBitmap.Clone();
            MainBitmap = bitmap;
        }

        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {

            square = new Square(new Point(e.X, e.Y), 0);
            tempBitmap = (Bitmap)bitmap.Clone();
            ownMouseDown = true;

        }

    }
}
