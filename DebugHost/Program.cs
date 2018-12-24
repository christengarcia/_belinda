using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugHost
{
    class Program
    {
        static void Main(string[] args)
        {
            NQuotes.DebugHost.Server.Start(args);
        }
    }
}
