using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var batfile = "eclipse\\Launcher.bat";

            System.Diagnostics.Process.Start(batfile);
        }
    }
}
