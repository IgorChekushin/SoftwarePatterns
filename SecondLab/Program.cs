using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTool
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f1 = new Form1();
            Application.Run(f1);


            //IPoint a = new Point();
            //a.SetX(1);
            //a.SetY(200);
            //IPoint b = new Point();
            //b.SetX(200);
            //b.SetY(100);
            //IPoint c = new Point();
            //c.SetX(1);
            //c.SetY(1);
            //IPoint d = new Point();
            //d.SetX(100);
            //d.SetY(200);

            //ICurve curve = new Bezier(a, b, c, d);

            //VisualCurve vCurve = new VisualCurve(curve);
            //vCurve.Draw(new ConsoleWriter());


            //Console.ReadLine();

        }
    }
}
