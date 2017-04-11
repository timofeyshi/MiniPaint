using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace MiniPaint
{
    class LineDrawer : FigureDrawer
    {

        private Line line;
        private bool ownMouseDown = false;
        private Bitmap bmp, tempDraw;

        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {

            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            temp.DrawLine(Pens.Black, line.GetFirstPoint().GetX(), line.GetFirstPoint().GetY(), line.getSecondPoint().GetX(), line.getSecondPoint().GetY());
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }



        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {
                line.setSecondPoint(new Point(e.X, e.Y));
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

            line = new Line(new Point(e.X, e.Y), new Point(e.X, e.Y));
            tempDraw = (Bitmap)bmp.Clone();
            ownMouseDown = true;


        }

    }
}
