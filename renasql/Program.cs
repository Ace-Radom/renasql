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
            for (; ; )
            {
                Console.Write("renasql> ");
                string rCommand = Console.ReadLine();
                rCommand = rCommand.Trim(); // delete spaces at front and back
                if (rCommand != "")
                {
                    if (rCommand[0] == '.')
                    {
                        rCommand = rCommand.Substring(1);
                        controlcmd.parse(rCommand);
                        return;
                    }
                    string sqlcmd = rCommand;
                    while (rCommand.Substring(rCommand.Length - 1, 1) != ";")
                    {
                        sqlcmd += " ";
                        Console.Write(" ..... > ");
                        rCommand = Console.ReadLine();
                        sqlcmd += rCommand;
                    } // read command until ; is given
                    Console.WriteLine(sqlcmd);
                    // sqlcipher.parse(sqlcmd);
                }
            }
        }
    }
}