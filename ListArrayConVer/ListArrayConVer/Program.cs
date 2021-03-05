using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListConVer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<string> colors = new List<string>();

                colors.Add("Red");
                colors.Add("Yellow");
                colors.Add("Blue");
                colors.Add("Green");
                colors.Add("Pink");

                //retrieve items or elements in a list collection by using a for each loop
                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }
            }
        }
    }
}
