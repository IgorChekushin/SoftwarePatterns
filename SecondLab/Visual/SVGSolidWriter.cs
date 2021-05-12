using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class SVGSolidWriter : ASVGWriter
    {
        public override void DrawEnd(IPoint p)
        {
            content.Append($"<circle cx = \"{p.GetX()}\" cy = \"{p.GetY()}\" r = \"10\" fill = \"green\" />");
        }

        public override void DrawSegment(IPoint start, IPoint finish)
        {
            content.Append($"<line x1=\"{ (int)start.GetX()}\" y1=\"{(int)start.GetY()}\" x2=\"{(int)finish.GetX()}\" y2=\"{(int)finish.GetY()}\" stroke = \"green\" />");
        }

        public override void DrawStart(IPoint p)
        {
            content.Append($"<circle cx = \"{p.GetX()}\" cy = \"{p.GetY()}\" r = \"10\" fill = \"green\" />");
        }
    }
}
