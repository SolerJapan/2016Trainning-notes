using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            emp emps1 = new emp();
            string ostrName = emps1.oStringGetFullName();
            Console.WriteLine(ostrName);
            string getAll1 = emps1.ostrGetEverything();
            Console.WriteLine(getAll1);
            Console.WriteLine();

            DateTime dt = new DateTime(year: 2012, month: 2, day: 22);

            emp emps2 = new emp(empID: 11, birthDate: dt, fName: "jo", lName: "hayabusa", jobTitle: "ninja");
            string ostrname2 = emps2.oStringGetFullName();
            Console.WriteLine(ostrname2);
            string ostrGetEverything2 = emps2.ostrGetEverything();
            Console.WriteLine(ostrGetEverything2);
            Console.WriteLine();

            emps1.p_empID = -112;
            getAll1 = emps1.ostrGetEverything();
            Console.WriteLine(getAll1);
            Console.WriteLine();

            Console.WriteLine(emps1.p_empID);

            Console.ReadLine();
        }

        private static int MyMethod(int iInput)
        {
            //throw new NotImplementedException();

            int iTemp = iInput * iInput;
            return iTemp;

        } // mymethod

    }
}
