using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// queue works like the FIFO system: first in first out
// Enqueue add an item or element in queue
// Dequeue: remove the oldest item from queue
namespace queueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue weekday = new Queue();

            weekday.Enqueue("Sunday");
            weekday.Enqueue("Monday");
            weekday.Enqueue("Tuesday");
            weekday.Enqueue("Wednesday");
            weekday.Enqueue("Thursday");
            weekday.Enqueue("Friday");
            weekday.Enqueue("Saturday");

            if (weekday.Contains("Tuesday"))
            {
                Console.WriteLine("this queue contains tuesday");
            }
            else
            {
                Console.WriteLine("this queue doesnt contain anything");
            }

            Console.WriteLine(weekday.Dequeue().ToString());

        }
    }
}
