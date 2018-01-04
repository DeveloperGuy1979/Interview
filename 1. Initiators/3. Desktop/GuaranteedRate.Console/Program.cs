using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace GuaranteedRate.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Make sure the file actually exist.
            if(args.Count() > 0 && !File.Exists(args[0]))
            {
                //Let's notify the user that they did not pass a valid file.
                System.Console.Write("Sorry friend!....this is not a valid file. Please pass in a valid file.");
                System.Console.Read();
            }
        }
    }
}
