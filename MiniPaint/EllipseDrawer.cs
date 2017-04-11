using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    class EllipseDrawer : FigureDrawer
    {
        Ellipse ellipse;
     
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
            temp.DrawEllipse(Pens.Black, ellipse.GetFirstPoint().GetX(), ellipse.GetFirstPoint().GetY(), ellipse.GetSecondPoint().GetX(), ellipse.GetSecondPoint().GetY());

            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {
                ellipse.SetSecondPoint(new Point(e.X, e.Y));
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

            ellipse = new Ellipse(new Point(e.X, e.Y), new Point(e.X, e.Y));
            tempDraw = (Bitmap)bmp.Clone();
            ownMouseDown = true;

        }

    }
}
