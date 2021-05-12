using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    abstract class ASVGWriter : IWriter
    {
        protected StringBuilder content = new StringBuilder();

        public ASVGWriter()
        {
            content.Append("<svg viewBox=\"0 0 500 500\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\">\n");
        }

        public StringBuilder GetContent()
        {
            return this.content;
        }
        public abstract void DrawEnd(IPoint p);

        public abstract void DrawSegment(IPoint start, IPoint finish);


        public abstract void DrawStart(IPoint p);
    }
}
