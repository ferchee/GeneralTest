using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {            
            WriteMe("Hello");
            Console.WriteLine("New feature");
            Console.ReadLine();
        }

        private static void WriteMe(string v)
        {
            Console.WriteLine(v);
        }
    }
}
