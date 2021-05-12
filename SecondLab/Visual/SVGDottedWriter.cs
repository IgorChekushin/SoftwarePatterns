using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class SVGDottedWriter : ASVGWriter
    {
        public override void DrawEnd(IPoint p)
        {
            content.Append($"<rect x=\"{p.GetX()}\" y=\"{p.GetY()}\" width=\"10\" height=\"10\" stroke=\"black\" fill=\"black\"/> \n");
            
        }

        public override void DrawSegment(IPoint start, IPoint finish)
        {
            content.Append($"<line x1=\"{(int)start.GetX()}\" y1=\"{(int)start.GetY()}\" x2=\"{(int)finish.GetX()}\" y2=\"{(int)finish.GetY()}\" stroke=\"black\" stroke-dasharray=\"5, 5\" />\n");
        }

        public override void DrawStart(IPoint p)
        {
            content.Append($"<rect x=\"{p.GetX()}\" y=\"{p.GetY()}\" width=\"10\" height=\"10\" stroke=\"black\" fill=\"black\"/>\n ");
        }
    }
}
