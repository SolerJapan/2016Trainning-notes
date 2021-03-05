using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        int x, y;
        static void Main(string[] args)
        {
         
            int z;
            Console.WriteLine("Welcome to Join .NET Package Class!");            Console.ReadLine();            Console.WriteLine("Please enter the value for x=");            int x = Convert.ToInt32(Console.ReadLine());            Console.WriteLine();            Console.WriteLine("Please enter the value for y=");
            int y = Convert.ToInt32(Console.ReadLine());

            z = x + y;

            Console.WriteLine();            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
