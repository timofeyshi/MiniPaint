using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {

        public Bitmap mainBitMap;
        bool mouseDown = false;
        PaintEventHandler paintEvent;

        LineDrawer lineDrawer;
        RectangleDrawer rectangleDrawer;
        SquareDrawer squareDrawer;
        TriangleDrawer triangleDrawer;
        EllipseDrawer ellipseDrawer;
        CircleDrawer circleDrawer;
        FigureDrawer figureDrawer;

        MouseEventHandler[] mouseEvents = new MouseEventHandler[3];

        public Form1()
        {
            InitializeComponent();
            Graphics g = panelForDrawing.CreateGraphics();
            mainBitMap = new Bitmap(panelForDrawing.Width, panelForDrawing.Height);
            lineDrawer = new LineDrawer();
            rectangleDrawer = new RectangleDrawer();
            squareDrawer = new SquareDrawer();
            triangleDrawer = new TriangleDrawer();
            ellipseDrawer = new EllipseDrawer();
            circleDrawer = new CircleDrawer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteMouseEvensts()
        {
            if (mouseEvents[0] != null)
            {
                panelForDrawing.MouseDown -= mouseEvents[0];
                panelForDrawing.MouseMove -= mouseEvents[1];
                panelForDrawing.MouseUp -= mouseEvents[2];
                panelForDrawing.Paint -= paintEvent;
            }
        }

        private void AddMouseEvents()
        {
            panelForDrawing.MouseDown += mouseEvents[0];
            panelForDrawing.MouseMove += mouseEvents[1];
            panelForDrawing.MouseUp += mouseEvents[2];
            panelForDrawing.Paint += paintEvent;
        }

        private void ChangeMouseEvents(MouseEventHandler mouseDown, MouseEventHandler mouseMove, MouseEventHandler mouseUp, PaintEventHandler paint)
        {
            mouseEvents[0] = mouseDown;
            mouseEvents[1] = mouseMove;
            mouseEvents[2] = mouseUp;
            this.paintEvent = paint;
        }

        private void panelForDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelForDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelForDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                panelForDrawing.Refresh();
                panelForDrawing.Update();
            }
        }

        private void AddNewDrawer(FigureDrawer drawer)
        {
            if (figureDrawer != null)
                mainBitMap = figureDrawer.getMainBitmap();
            figureDrawer = drawer;
            drawer.setBmp(mainBitMap);
            DeleteMouseEvensts();
            ChangeMouseEvents(drawer.OnMouseDown, drawer.OnMouseMove, drawer.OnMouseUp, drawer.OnPaint);
            AddMouseEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewDrawer(lineDrawer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewDrawer(rectangleDrawer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewDrawer(squareDrawer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewDrawer(ellipseDrawer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNewDrawer(circleDrawer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNewDrawer(triangleDrawer);
        }
    }
}
