using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            tCHarry oCHarry = new tCHarry();
            string oStr = oCHarry.GetString();
            Console.WriteLine(oStr);

            tIFirst oIFirst = oCHarry;
            oStr = oIFirst.GetString();
            Console.WriteLine(oStr);

            tISecond oISecond = oCHarry;
            oStr = oISecond.GetString();
            Console.WriteLine(oStr);

            List<tCHarry> oListOfHarry = new List<tCHarry>();
            oListOfHarry.Add(new tCHarry() { m_iID = 1 });
            oListOfHarry.Add(new tCHarry() { m_iID = 2 });
            oListOfHarry.Add(new tCHarry() { m_iID = 3 });
            oListOfHarry.Add(new tCHarry() { m_iID = 4 });
            oListOfHarry.Add(new tCHarry() { m_iID = 5 });

            foreach( tCHarry oCHar in oListOfHarry)
            {
                oStr = oCHar.GetString();
                Console.WriteLine( oStr);
            }
            Console.WriteLine("====================================================");

            MyMethod1(oCHarry);

            MyMethod2(oCHarry);
            Console.WriteLine("====================================================");

            tCBob oCBob = new tCBob();
           // MyMethod1(oCBob);
            MyMethod2(oCBob);
            Console.WriteLine("====================================================");

            List<tIFirst> oListOfIFirst = new List<tIFirst>();
            oListOfIFirst.Add(new tCHarry() );
            oListOfIFirst.Add(new tCBob() );
            oListOfIFirst.Add(new tCHarry() );
            oListOfIFirst.Add(new tCBob() );
            oListOfIFirst.Add(new tCHarry() );
            oListOfIFirst.Add(new tCBob());

            foreach (tCHarry oCHar in oListOfHarry)
            {
                oStr = oCHar.GetString();
                Console.WriteLine(oStr);
            }
            Console.WriteLine("====================================================");

        }
        static public void MyMethod1( tCHarry oCHarry)
        {
            Console.WriteLine( "oCHarry.GetString returns: {0}", oCHarry.GetString());
        }

        static public void MyMethod2( tIFirst oIFirst)
        {
            Console.WriteLine("oCHarry.GetString returns: {0}", oIFirst.GetString());
        }

        


    }// class

    interface tIFirst
    {
        string GetString();

    }

    interface tISecond
    {
        string GetString();
    }

    class tCHarry : tIFirst, tISecond
    {
        public int m_iID = 0;

        public string GetString()
        {
            string oStr = "inside GetString()" + "  "  + this.m_iID.ToString();
            // throw new NotImplementedException();
            return oStr;
        }

        //explicit implementation
        string tIFirst.GetString()
        {
            string oStr = "inside first GetString()" + "  " + this.m_iID.ToString();
            // throw new NotImplementedException();
            return oStr;
        }

         //explicit implementation
        string tISecond.GetString()
        {
            string oStr = "inside second GetString()" + "  " + this.m_iID.ToString();
            // throw new NotImplementedException();
            return oStr;
        }


    }// Class

    class tCBob : tIFirst
    {
        public string GetString()
        {
            return "Hi i am in tCBOB GetString";
        }

        string tIFirst.GetString()
        {
            return "Hi i am in tCBOB First.GetString";
        }

    }

}// ns
