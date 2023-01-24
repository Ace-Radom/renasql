using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renasql
{
    internal class controlcmd
    {
        public static void parse(string cmd)
        {
            if (cmd == "quit")
            {
                Process.GetCurrentProcess().Kill();
                // shutdown current process when "quit" ccmd entered
                return;
            }

            if (cmd == "help")
            {
                printhelp();
                return;
            }

            if (cmd == "version")
            {
                printversion();
                return;
            }
        }

        private static void printhelp()
        {
            Console.WriteLine("============== RenaSQL Help Page ==============");
            Console.WriteLine(".help      show this help page");
            Console.WriteLine(".version   show RenaSQL version");
            Console.WriteLine(".quit      exit this program");
        }

        private static void printversion()
        {
            Console.WriteLine("RenaSQL version " + sv.major.ToString() + "." + sv.minor.ToString() + "." + sv.patch.ToString());
        }
    }
}
