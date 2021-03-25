using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public interface ICurve
    {
        void GetPoint(double t, out IPoint p);
    }
}
