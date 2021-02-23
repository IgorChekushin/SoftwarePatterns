using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Instructor : IListener
    {
        public void Listen(string voice)
        {
            Console.WriteLine("The instructor hears the instructor");
        }
        public void Say(Room r, string voice)
        {
            r.Say(voice);
        }
    }
}
