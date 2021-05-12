using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{

    class PointComparer : IEqualityComparer<IPoint>
    {
        public bool Equals(IPoint x, IPoint y)
        {
            if (x.GetX() == y.GetX())
            {
                if (x.GetY() == y.GetY())
                    return true;
                else
                    return false;
            }
            else { return false; }
        }
        public int GetHashCode(IPoint codeh)
        {
            return 0;
        }
    }

}
