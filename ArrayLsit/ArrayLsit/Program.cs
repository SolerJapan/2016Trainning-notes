using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayLsit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //define an object through arrayList Class
            ArrayList colors = new ArrayList();

            colors.Add("Red");
            colors.Add("green");
            colors.Add("blue");
            colors.Add("yellow");
            colors.Add("purple");
            colors.Add("Black");
            colors.Add("White");

            for (i=0; i <= colors.Count-1; i++)
            {
                Console.WriteLine(colors[i].ToString());
            }

        }
    }
}
