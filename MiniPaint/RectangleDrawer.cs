﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    class RectangleDrawer : FigureDrawer
    {
        Rectangle rectangle;

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
            temp.DrawRectangle(Pens.Red, rectangle.GetFirstPoint().getX(), rectangle.GetFirstPoint().getY(), rectangle.getHeight(), rectangle.getWidth());
            e.Graphics.DrawImageUnscaled(tempBitmap, 0, 0);
            temp.Dispose();
        }


        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {
                rectangle.setWidth(e.Y - rectangle.GetFirstPoint().getY());
                rectangle.setHeight(e.X - rectangle.GetFirstPoint().getX());
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

            rectangle = new Rectangle(new Point(e.X, e.Y), 0, 0);
            tempBitmap = (Bitmap)bitmap.Clone();
            ownMouseDown = true;

        }
    }
}
