using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCli.Example2
{
    internal static class LogDataClass
    {
        public static Dictionary<DateTime, string> Logs { get; set; } = new Dictionary<DateTime, string>();
    }
}
