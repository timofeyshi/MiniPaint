using System;
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
        Bitmap bmp, tempDraw;


        public void setBmp(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        public override void OnPaint(object sender, PaintEventArgs e)
        {

            tempDraw = (Bitmap)bmp.Clone();
            Graphics temp = Graphics.FromImage(tempDraw);
            //DrawRectangle(Pens.Black, rectangle.GetFirstPoint().GetX(), rectangle.GetFirstPoint().GetY(), rectangle.GetHeight(), rectangle.GetWidth());
            temp.DrawRectangle(Pens.Black, square.GetFirstPoint().GetX(), square.GetFirstPoint().GetY(), square.GetHeight(), square.GetWidth());

            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {

                square.SetWidth(e.Y - square.GetFirstPoint().GetY());
                square.SetHeight(e.Y - square.GetFirstPoint().GetY());


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

            square = new Square(new Point(e.X, e.Y), 0);
            tempDraw = (Bitmap)bmp.Clone();
            ownMouseDown = true;

        }

    }
}
