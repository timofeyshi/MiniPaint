using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    abstract class FigureDrawer : Panel
    {

        private Bitmap bmp;

        public Bitmap Bmp
        {
            get { return bmp; }
            set { bmp = value; }
        }

        public abstract void OnPaint(object sender, PaintEventArgs e);
        public abstract void OnMouseMove(Object sender, MouseEventArgs e);
        public abstract void OnMouseUp(Object sender, MouseEventArgs e);
        public abstract void OnMouseDown(Object sender, MouseEventArgs e);

    }
}
