using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class SVGSaver
    {
        private List<ICurve> curves;
        private const int n = 25;

        public SVGSaver(List<ICurve> curves)
        {
            this.curves = curves;
        }

        public void save(ASVGWriter svgWriter, string fileName)
        {

            IPoint p = new Point();
            foreach (var curve in curves)
            {
                curve.GetPoint(0, out p);
                svgWriter.DrawStart(p);

                for (double i = 1; i < n; i++)
                {
                    double st = i / n;
                    double ft = (i + 1) / n;
                    curve.GetPoint(st, out p);
                    curve.GetPoint(ft, out IPoint p2);
                    svgWriter.DrawSegment(p, p2);
                }
                curve.GetPoint(1, out p);
                svgWriter.DrawEnd(p);
            }


            svgWriter.GetContent().Append("</svg>");
            string path = Directory.GetCurrentDirectory();
            string filePath = path + fileName;
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);
                File.WriteAllText(filePath, svgWriter.GetContent().ToString());
            }
            else
            {
                File.WriteAllText(filePath, svgWriter.GetContent().ToString());
            }
        }
    }
}
