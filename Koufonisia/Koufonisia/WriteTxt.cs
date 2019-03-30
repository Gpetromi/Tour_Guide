using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koufonisia
{
    class WriteTxt
    {
        //Function that takes as argument a string and saves it in a text file.
        public void WriteText(String s)
        {
            System.IO.File.AppendAllText("Info.txt", s+Environment.NewLine);
        }
        //Function that takes as argument a string and saves it in a text file.
        public void WriteEvent(String s)
        {
            System.IO.File.AppendAllText("Event.txt", s + Environment.NewLine);
        }
    }

    }
