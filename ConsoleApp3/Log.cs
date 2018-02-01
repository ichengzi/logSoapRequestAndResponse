using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Logger
    {
        public static void Error(string str)
        {
            //Console.WriteLine(str);
            System.Diagnostics.Debug.WriteLine(str);
        }

        public static void Debug(string str)
        {
            //Console.WriteLine(str);
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}
