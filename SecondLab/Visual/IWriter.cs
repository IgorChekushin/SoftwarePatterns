using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    public interface IWriter
    {
        void DrawSegment(IPoint p);
        void DrawStart(IPoint p);
        void DrawEnd(IPoint p);
    }
}
