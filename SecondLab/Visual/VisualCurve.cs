using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class VisualCurve :  IDrawable
    {
        private ICurve c;
        private const int n = 25;
        public VisualCurve(ICurve c)
        {
            this.c = c;
        }

        public  void Draw(IWriter w)
        {
            IPoint p = new Point();
            
            doGetPoint(0, out p);
            w.DrawStart(p);

            for (double i = 1; i < n; i++)
            {
                double st = i / n;
                double ft = (i + 1) / n;
                doGetPoint(st, out p);
                doGetPoint(ft, out IPoint p2);
                w.DrawSegment(p, p2);
            }

            doGetPoint(1, out p);
            w.DrawEnd(p);
        }

        protected void doGetPoint(double t, out IPoint p)
        {
            c.GetPoint(t, out p);
        }

    }
}
