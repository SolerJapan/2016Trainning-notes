using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance.Model;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var produce = new List<object>();
            var f1 = new Fruit("apple", 2.5, 3);

            produce.Add(f1);

            var f2 = new Fruit("Banana", 4.5, 6);

            produce.Add(f2);

            var f3 = new Fruit("kiwi", 0.5, 3);

            produce.Add(f3);

            var f4 = new Fruit("Mango", 6.5, 6);

            produce.Add(f4);


            var f5 = new Vegetable("Carrot", 1.5, 2);

            produce.Add(f5);

            var f6 = new Vegetable("Potato", 1.5, 2);

            produce.Add(f6);

            var f7 = new Vegetable("Cabbage", 1.5, 2);

            produce.Add(f7);

            var f8 = new Vegetable("Avocado", 1.5, 2);

            produce.Add(f8);

            Console.WriteLine("There are" + produce.Count + "items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }
        }

    }
}
