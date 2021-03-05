using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


// ArrayList is one of the moxt flexible data structures of C sharp
//ArrayList contains a simple list of values
//Add: add ab uten ub ab arrayList
//Remove:Remove an ittem from arraylist
//Inset: insert an item or element in a specified position in an ArrayList
namespace ArrayListCollection
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

            for (i=0;i<=colors.Count; i++)
            {
                Console.WriteLine(colors[i].ToString());
            }


        }
    }
}
