using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class Bezier : ACurve
    {
        IPoint c;
        IPoint d;
        public Bezier(IPoint a, IPoint b, IPoint c, IPoint d) : base(a, b)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override void GetPoint(double t, out IPoint p)
        {
            p = new Point();
            double x = 0;
            double y = 0;

            x = Math.Pow((1 - t), 3) * a.GetX() + 3 * t * Math.Pow((1 - t), 2) * b.GetX() + 3 * t * t * (1 - t) * c.GetX() + t * t * t * d.GetX();
            y = Math.Pow((1 - t), 3) * a.GetY() + 3 * t * Math.Pow((1 - t), 2) * b.GetY() + 3 * t * t * (1 - t) * c.GetY() + t * t * t * d.GetY();

            p.SetX(x);
            p.SetY(y);
        }
    }
}
