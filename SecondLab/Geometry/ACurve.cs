using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    abstract class ACurve : ICurve
    {
        protected IPoint a;
        protected IPoint b;


        public ACurve(IPoint a, IPoint b)
        {
            this.a = a;
            this.b = b;
        }
        /// <summary>
        /// provides points on the line
        /// </summary>
        /// <param name="t">number between 0 and 1</param>
        /// <param name="p">point</param>
        /// <returns></returns>
        abstract public void GetPoint(double t, out IPoint p);


    }
}
