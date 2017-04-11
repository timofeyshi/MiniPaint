using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    class TriangleDrawer : FigureDrawer
    {
        RightTriangle rightTriangle;
        

        private bool ownMouseDown = false;
        Bitmap bmp, tempDraw;

        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {

            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            // temp.DrawRectangle(Pens.Red, rectangle.GetFirstPoint().GetX(), rectangle.GetFirstPoint().GetY(), rectangle.GetHeight(), rectangle.GetWidth());
            temp.DrawLine(Pens.Green, rightTriangle.GetFirstPoint().GetX(), rightTriangle.GetFirstPoint().GetY(), rightTriangle.GetFirstPoint().GetX() + rightTriangle.GetWidth(), rightTriangle.GetFirstPoint().GetY());
            temp.DrawLine(Pens.Green, rightTriangle.GetFirstPoint().GetX(), rightTriangle.GetFirstPoint().GetY(), rightTriangle.GetFirstPoint().GetX(), rightTriangle.GetFirstPoint().GetY() + rightTriangle.GetHeight());
            temp.DrawLine(Pens.Green, rightTriangle.GetFirstPoint().GetX(), rightTriangle.GetFirstPoint().GetY() + rightTriangle.GetHeight(), rightTriangle.GetFirstPoint().GetX() + rightTriangle.GetWidth(), rightTriangle.GetFirstPoint().GetY());

            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }



        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {



                rightTriangle.SetHeight(e.Y - rightTriangle.GetFirstPoint().GetY());
                rightTriangle.SetWidth(e.X - rightTriangle.GetFirstPoint().GetX());


            }
        }


        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            ownMouseDown = false;
            bmp = (Bitmap)tempDraw.Clone();
            Bmp = bmp;
        }

        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {

            rightTriangle = new RightTriangle(new Point(e.X, e.Y), 0, 0);
            tempDraw = (Bitmap)bmp.Clone();
            ownMouseDown = true;

        }
    }
}
