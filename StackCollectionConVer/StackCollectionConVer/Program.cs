using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //define an object called weekday
            Stack weekday = new Stack();
            weekday.Push("Sunday");
            weekday.Push("Monday");
            weekday.Push("Tuesday");
            weekday.Push("Wednesday");
            weekday.Push("Thursday");
            weekday.Push("Friday");
            weekday.Push("Saturday");


            if (weekday.Count == 7)
            {

                Console.WriteLine(weekday.Pop().ToString());
            }
            else
            {

                Console.WriteLine("Saturday does not exist ");
            }
        }
    }
}
