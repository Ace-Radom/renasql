using System;

namespace renasql
{
    internal class renasql_main
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "RenaSQL CLI version " + sv.major.ToString() + "." + sv.minor.ToString() + "." + sv.patch.ToString() + "\n" +
                "Enter \".help\" for usage hints" + "\n"
            );
        }
    }
}