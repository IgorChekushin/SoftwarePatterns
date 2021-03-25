using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public class VisualBezier : VisualCurve
    {
        public VisualBezier(ICurve c) : base(c) { }


        public override void Draw(IWriter w)
        {
            IPoint p = new Point();

            doGetPoint(0, out p);
            w.DrawStart(p);

            for (double i = 0; i < 1; i = i + 0.001)
            {
                doGetPoint(i, out p);
                w.DrawSegment(p);
            }

            doGetPoint(1, out p);
            w.DrawEnd(p);
        }
    }
}
