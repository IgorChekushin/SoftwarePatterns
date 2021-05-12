using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class ConsoleWriter : IWriter
    {
        private List<IPoint> points = new List<IPoint>();

        public void DrawEnd(IPoint p)
        {
            points.Add(p);
            string line = PrepareLine();
            DrawLine(line);
        }

        public void DrawSegment(IPoint start, IPoint finish)
        {
            //Надо добавить все точки между стартом и финишом
            points.Add(start);
            points.Add(finish);
        }

        public void DrawStart(IPoint p)
        {
            points.Add(p);
        }
        private string PrepareLine()
        {
            string line = "";
            
            for(int iq = 0; iq < points.Count; iq++)
            {
                points[iq].SetX((int)points[iq].GetX());
                points[iq].SetY((int)points[iq].GetY());
            }
            points = points.Distinct(new PointComparer()).ToList();

            points = points.OrderBy(x => x.GetY()).ThenBy(x => x.GetX()).ToList();//.ThenByDescending(x => x.GetX());
            int max_X = (int)points.Max(x => x.GetX());
            int max_Y = (int)points.Max(x => x.GetY());

            int point_index = 0;
            int row_index = 1;

            for (int k = 0; k < max_X * max_Y; k++)
            {
                if (row_index <= max_X)
                {
                    if (point_index < points.Count)
                    {
                        if ((int)points[point_index].GetX() == row_index)
                        {
                            line += "+";
                            point_index++;
                        }
                        else
                        {
                            line += " ";
                        }
                    }
                    else
                    {
                        line += " ";
                    }
                }
                row_index++;
                
                if(row_index == max_X + 1)
                {
                    row_index = 1;
                    line += "\r\n";
                }

            }
            return line;
        }
        private void DrawLine(string line)
        {
            Console.Write(line);
        }
    }
}
