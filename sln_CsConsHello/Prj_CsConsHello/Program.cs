using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CsConsHello
{
    class Program
    {
        //int iage = 26;
        //string iname = "hitoshi konnshi";
        //bool boke = true;

        static void Main(string[] args)
        {
            //       Console.WriteLine("hello world");

            //    string ostrresponse = Console.ReadLine();

            //  Console.WriteLine(ostrresponse);

            //    ostrresponse = Console.ReadLine();

            //int iValue = -1;
            //while (iValue != 10)
            //{
            //    string oStrResponse = Console.ReadLine();
            //    bool bOk = int.TryParse(oStrResponse, out iValue);
            //    if (bOk)
            //    {
            //        int iRet = Program.MyMethod(iValue);
            //        Console.WriteLine(iRet);
            //    }
            //    else
            //    {
            //        Console.WriteLine("You goofed, it's not an integer...{0}", oStrResponse);
            //    }
            //}

            kaishain okaishain1 = new kaishain();
            string ostrname = okaishain1.oStrGetFullName();
            Console.WriteLine(ostrname);
            string ostrGetEverything1 = okaishain1.ostrGetEverything();
            Console.WriteLine(ostrGetEverything1);
            Console.WriteLine();

            DateTime dt = new DateTime(year: 2012, month: 2, day: 22);

            kaishain okaishain2 = new kaishain(iKaishaID: 11, dtTanjoubi:dt, onamae:"jo" , oMyoji:"hayabusa" , jobTitle: "ninja" );
            string ostrname2 = okaishain2.oStrGetFullName();
            Console.WriteLine(ostrname2);
            string ostrGetEverything2 = okaishain2.ostrGetEverything();
            Console.WriteLine(ostrGetEverything2);
            Console.WriteLine();

            okaishain1.p_iKaishaID = -112;
            ostrGetEverything1 = okaishain1.ostrGetEverything();
            Console.WriteLine(ostrGetEverything1);
            Console.WriteLine();

            Console.WriteLine(okaishain1.p_iKaishaID);

            Console.ReadLine();
        } // main
      

        private static int MyMethod(int iInput)
        {
            //throw new NotImplementedException();

            int iTemp = iInput * iInput;
            return iTemp;

        } // mymethod


    } // class

} // ns

