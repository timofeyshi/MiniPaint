using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    class CircleDrawer : FigureDrawer
    {
        Circle circle;
       
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
            temp.DrawEllipse(Pens.Black, circle.GetFirstPoint().getX(), circle.GetFirstPoint().getY(), circle.getSize(), circle.getSize());

            e.Graphics.DrawImageUnscaled(tempBitmap, 0, 0);
            temp.Dispose();
        }


        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {
                circle.setSize(e.X - circle.GetFirstPoint().getX());
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

            circle = new Circle(new Point(e.X, e.Y), 0);
            tempBitmap = (Bitmap)bitmap.Clone();
            ownMouseDown = true;

        }
    }
}
