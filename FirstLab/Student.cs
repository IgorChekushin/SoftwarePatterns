using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Student : IListener
    {
        public Notebook Notebook { get; } = new Notebook();

        public void Listen(string voice)
        {
            Console.WriteLine("The student hears the instructor");
            Write(voice);
        }
        void Write(string voice)
        {
            Notebook.Write(voice);
        }
    }
}
