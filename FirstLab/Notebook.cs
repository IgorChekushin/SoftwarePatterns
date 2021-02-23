using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Notebook
    {
        public string Data {private set; get;}

        public void Write(string voice)
        {
            Data = voice;
        }
    }    
}
