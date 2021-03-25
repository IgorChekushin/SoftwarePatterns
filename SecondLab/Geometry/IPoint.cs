using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public interface IPoint
    {
        void SetX(double x);
        void SetY(double y);
        double GetX();
        double GetY();
    }
}
