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
    public partial class Form1 : Form
    {
        Graphics gr;
        Brush br;
        Pen pen;
        List<ICurve> beziers = new List<ICurve>();
        List<ICurve> lines = new List<ICurve>();


        public Form1()
        {
            InitializeComponent();
           // gr = this.CreateGraphics();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // Draw left line
            gr = panel1.CreateGraphics();
            br = (Brush)Brushes.Black;
            pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            IPoint start = new Point();
            start.SetX(rnd.Next(0, 400));
            start.SetY(rnd.Next(0, 400));
            IPoint finish = new Point();
            finish.SetX(rnd.Next(0, 400));
            finish.SetY(rnd.Next(0, 400));

            ICurve line = new Line(start, finish);
            VisualCurve vCurve = new VisualCurve(line);
            lines.Add(line);

            AFormWriter dottedWriter = new DottedWriter(br, gr, pen);

            vCurve.Draw(dottedWriter);

            //Draw right bezier
            gr = panel2.CreateGraphics();
            br = (Brush)Brushes.Green;
            pen = new Pen(Color.Green);
            IPoint a = new Point();
            a.SetX(rnd.Next(0, 300));
            a.SetY(rnd.Next(0, 300));
            IPoint b = new Point();
            b.SetX(rnd.Next(0, 300));
            b.SetY(rnd.Next(0, 300));
            IPoint c = new Point();
            c.SetX(rnd.Next(0, 300));
            c.SetY(rnd.Next(0, 300));
            IPoint d = new Point();
            d.SetX(rnd.Next(0, 300));
            d.SetY(rnd.Next(0, 300));

            ICurve bezier = new Bezier(a, b, c, d);
            beziers.Add(bezier);

            vCurve = new VisualCurve(bezier);
            AFormWriter solidWriter = new SolidWriter(br, gr, pen);
            vCurve.Draw(solidWriter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ASVGWriter svgSolidWriter = new SVGSolidWriter();
            SVGSaver svgSaver = new SVGSaver(beziers);
            svgSaver.save(svgSolidWriter, "//bezier.svg");

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ASVGWriter svgDottedWriter = new SVGDottedWriter();
            SVGSaver svgSaver = new SVGSaver(lines);
            svgSaver.save(svgDottedWriter, "//line.svg");
        }
    }
}
