using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class Line : ACurve
    {
        public Line(IPoint a, IPoint b) : base(a,b)
        {
            this.a = a;
            this.b = b;
        }

        public override void GetPoint(double t, out IPoint p)
        {
            p = new Point();
            double x = (1 - t) * a.GetX() + t * b.GetX();
            double y = (1 - t) * a.GetY() + t * b.GetY();
            
            p.SetX(x);
            p.SetY(y);
        }   
    }
}
