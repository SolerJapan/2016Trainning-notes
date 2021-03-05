using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice, choice2;
            Console.WriteLine("Would you like decimal (1) or not decimals");
            choice = Console.ReadLine();
            Console.WriteLine("Would you like to add,subtract, or multiply");
            choice2 = Console.ReadLine();
            Console.ReadLine();

            if (choice == "1")
            {
                switch (choice2)
                {
                    case "add":
                        Console.Write("Enter a interger ");
                        string s = Console.ReadLine();
                        int i = int.Parse(s);
                        Console.Write("Enter a another integer");
                        string s2 = Console.ReadLine();
                        int i2 = int.Parse(s2);
                        int isum = i + i2;
                        Console.Write("youre sum is {0}", isum);
                        break;
                    case "subtract":
                        Console.Write("Enter a interger ");
                        s = Console.ReadLine();
                        i = int.Parse(s);
                        Console.Write("Enter a another integer");
                        s2 = Console.ReadLine();
                        i2 = int.Parse(s2);
                        int isub = i - i2;
                        Console.Write("youre difference is {0}", isub);
                        break;
                    case "multiply":
                        Console.Write("Enter a interger ");
                        s = Console.ReadLine();
                        i = int.Parse(s);
                        Console.Write("Enter a another integer");
                        s2 = Console.ReadLine();
                        i2 = int.Parse(s2);
                        int imult = i * i2;
                        Console.Write("youre numbers multiplied is {0}", imult);
                        break;
                }

                Console.WriteLine("...The program has ended...");
                Console.ReadLine();
            }
            else
            {
                switch (choice2)
                {
                    case "add":
                        Console.Write("Enter a precision number ");
                        string s = Console.ReadLine();
                        double d = double.Parse(s);
                        Console.Write("Enter a another integer");
                        string s2 = Console.ReadLine();
                        double d2 = double.Parse(s2);
                        double dsum = d + d2;
                        Console.Write("youre sum is {0}", dsum);
                        break;
                    case "subtract":
                        Console.Write("Enter a precision number ");
                        s = Console.ReadLine();
                        d = double.Parse(s);
                        Console.Write("Enter a another number");
                        s2 = Console.ReadLine();
                        d2 = double.Parse(s2);
                        double dsub = d + d2;
                        Console.Write("youre sum is {0}", dsub);
                        break;
                    case "multiply":
                        Console.Write("Enter a precision number ");
                        s = Console.ReadLine();
                        d = double.Parse(s);
                        Console.Write("Enter a another number");
                        s2 = Console.ReadLine();
                        d2 = double.Parse(s2);
                        double dmult = d + d2;
                        Console.Write("youre sum is {0}", dmult);
                        break;
                }
            }
        }
    }
}
