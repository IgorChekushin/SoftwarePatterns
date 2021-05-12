using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class DottedWriter : AFormWriter
    {
        public DottedWriter(Brush br, Graphics gr, Pen pen) : base()
        {
            this.br = br;
            this.gr = gr;
            this.pen = pen;
        }
        public override void DrawEnd(IPoint p)
        {
            gr.FillRectangle(br, (int)p.GetX(), (int)p.GetY(), 10, 10);
        }

        public override void DrawStart(IPoint p)
        {
            gr.FillRectangle(br, (int)p.GetX(), (int)p.GetY(), 10, 10);
        }
    }
}
