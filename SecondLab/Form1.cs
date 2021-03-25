using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTool
{
    public partial class Form1 : Form, IWriter
    {
        Graphics gr;
        Brush br = (Brush)Brushes.Black;
        
        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
        }
        public void DrawSegment(IPoint p)
        {
            gr.FillRectangle(br, (float)p.GetX(), (float)p.GetY(), 1, 1);
        }
        public void DrawStart(IPoint p)
        {
            gr.FillRectangle(br, (float)p.GetX(), (float)p.GetY(), 10, 10);
        }
        public void DrawEnd(IPoint p)
        {
            gr.FillRectangle(br, (float)p.GetX(), (float)p.GetY(), 10, 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPoint start = new Point();
            start.SetX(100);
            start.SetY(100);
            IPoint finish = new Point();
            finish.SetX(300);
            finish.SetY(400);

            ICurve curve = new Line(start, finish);

            VisualCurve vCurve = new VisualLine(curve);
            vCurve.Draw(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPoint a = new Point();
            a.SetX(100);
            a.SetY(400);
            IPoint b = new Point();
            b.SetX(400);
            b.SetY(250);
            IPoint c = new Point();
            c.SetX(100);
            c.SetY(100);
            IPoint d = new Point();
            d.SetX(250);
            d.SetY(400);

            ICurve curve = new Bezier(a, b, c, d);

            VisualCurve vCurve = new VisualBezier(curve);
            vCurve.Draw(this);
        }
    }
}
