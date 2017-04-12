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
        private RightTriangle rightTriangle;
        private bool ownMouseDown = false;
       

        public override void OnPaint(object sender, PaintEventArgs e)
        {

            tempBitmap = (Bitmap)bitmap.Clone();
            Graphics temp = Graphics.FromImage(tempBitmap);
            temp.DrawLine(Pens.Green, rightTriangle.GetFirstPoint().getX(), rightTriangle.GetFirstPoint().getY(), rightTriangle.GetFirstPoint().getX() + rightTriangle.getWidth(), rightTriangle.GetFirstPoint().getY());
            temp.DrawLine(Pens.Green, rightTriangle.GetFirstPoint().getX(), rightTriangle.GetFirstPoint().getY(), rightTriangle.GetFirstPoint().getX(), rightTriangle.GetFirstPoint().getY() + rightTriangle.getHeight());
            temp.DrawLine(Pens.Green, rightTriangle.GetFirstPoint().getX(), rightTriangle.GetFirstPoint().getY() + rightTriangle.getHeight(), rightTriangle.GetFirstPoint().getX() + rightTriangle.getWidth(), rightTriangle.GetFirstPoint().getY());

            e.Graphics.DrawImageUnscaled(tempBitmap, 0, 0);
            temp.Dispose();
        }



        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {



                rightTriangle.setHeight(e.Y - rightTriangle.GetFirstPoint().getY());
                rightTriangle.setWidth(e.X - rightTriangle.GetFirstPoint().getX());


            }
        }


        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            ownMouseDown = false;
            bitmap = (Bitmap)tempBitmap.Clone();
            setMainBitmap(bitmap);
           
        }

        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {

            rightTriangle = new RightTriangle(new Point(e.X, e.Y), 0, 0);
            ownMouseDown = true;

        }
    }
}
