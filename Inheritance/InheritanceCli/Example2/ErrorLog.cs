using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCli.Example2
{
    class ErrorLog : Log
    {
        public override void Write(string message)
        {
            base.Write($"ERROR {message}");
        }
    }
}
