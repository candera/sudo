using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Wangdera.SuDo
{
    class Program
    {
        static void Main(string[] args)
        {
            var psi = new ProcessStartInfo(args[0]);
            psi.Verb = "runas";

            if (args.Length > 1)
            {
                psi.Arguments = string.Join(" ", args.Skip(1).ToArray());
            }

            Process.Start(psi); 
        }
    }
}
