using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public abstract class VisualCurve :  IDrawable
    {
        private ICurve c;
        public VisualCurve(ICurve c)
        {
            this.c = c;
        }

        
        abstract public void Draw(IWriter w);



        protected void doGetPoint(double t, out IPoint p)
        {
            c.GetPoint(t, out p);
        }

    }
}
