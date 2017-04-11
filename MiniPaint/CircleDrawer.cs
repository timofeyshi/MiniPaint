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
        Bitmap bmp, tempDraw;

        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {

            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            temp.DrawEllipse(Pens.Black, circle.GetFirstPoint().GetX(), circle.GetFirstPoint().GetY(), circle.getSize(), circle.getSize());

            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }


        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {



                circle.setSize(e.X - circle.GetFirstPoint().GetX());

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

            circle = new Circle(new Point(e.X, e.Y), 0);
            tempDraw = (Bitmap)bmp.Clone();
            ownMouseDown = true;

        }
    }
}
