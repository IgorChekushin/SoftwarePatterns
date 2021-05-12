using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    abstract class AFormWriter : IWriter
    {
        protected Brush br;
        protected Graphics gr;
        protected Pen pen;
        public abstract void DrawEnd(IPoint p);

        public  void DrawSegment(IPoint start, IPoint finish)
        {
            gr.DrawLine(pen, (float)start.GetX(), (float)start.GetY(), (float)finish.GetX(), (float)finish.GetY());
        }

        public abstract void DrawStart(IPoint p);
    }
}
