using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        public static void Main()
        {
            var student = new Student();
            var instructor = new Instructor();
            var room = new Room();
  
            room.Enter(student);
            room.Enter(instructor);

            instructor.Say(room, "Hello, students");

            Console.WriteLine($"The student wrote \"{student.Notebook.Data}\"");
            Console.ReadLine();
        }
    }
}
