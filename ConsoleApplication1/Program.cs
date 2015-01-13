using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello world!");

            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("hey " + name);

            //cheer the user on
            //gimme a...
            //BOB is GRAND!
            for (int i = 0; i < name.Length; i++)
            {
                name = name.ToLower();
                if (name[i].ToString() == "a" || name[i].ToString() == "e" || name[i].ToString() == "i" ||
                    name[i].ToString() == "o" || name[i].ToString() == "u")
                    System.Console.WriteLine("Give me a..." + naame[i]);
            }
            System.Console.WriteLine(name.ToUpper() + " is GRAND!");
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
