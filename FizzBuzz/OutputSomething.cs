using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class OutputSomething
    {
        public OutputSomething(int divider, string replacer)
        {
            Divider = divider;
            Replacer = replacer;
        }

        public int Divider { get; }
        public string Replacer { get; }
    }
}
