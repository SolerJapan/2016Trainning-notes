using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CsConsHello
{
    enum TeTitles
    {
        Shacho, Fukushacho, kacho, Salaryman, Programmer, Housekeeping , none
    }


    class kaishain
    {
        //fields value
        private int iKaishaID = 0;
        private DateTime dtTanjoubi = default(DateTime);

        private string oMyoji    = null;
        private string onamae    = null;       
        private string ojobTitle = null;
        private TeTitles eTitle = TeTitles.none;
        //fields reference

        public kaishain ( int iKaishaID, DateTime dtTanjoubi , string onamae , string oMyoji , string jobTitle)
        {
            this.iKaishaID = iKaishaID;
            this.dtTanjoubi = dtTanjoubi;
            this.oMyoji = oMyoji;
            this.onamae = onamae;
            this.ojobTitle = jobTitle;
        }

        public kaishain()
        {
            this.iKaishaID = 0;
            this.dtTanjoubi = new DateTime( year:2000, month:1, day:1 );
            this.oMyoji = "Tanaka";
            this.onamae = "Ryoji";
            this.ojobTitle = "SalaryMan";
        }


        public kaishain (int aKaishaID, DateTime adtTanjoubi, string aonamae, string aoMyoji, string ajobTitle , TeTitles atitle )    
        {
            this.iKaishaID = aKaishaID;
            this.dtTanjoubi = adtTanjoubi;
            this.oMyoji = aoMyoji;
            this.onamae = aonamae;
            this.ojobTitle = ajobTitle;
        }

        //properties

        public int p_iKaishaID
        {
            get
            {
                return this.iKaishaID;
            }
            set
            {
                if (value > -1)
                {
                    this.iKaishaID = value;
                }
                else
                {
                    Console.WriteLine("IDに間違がおります");
                }
            }
        }


        //methods
          public String oStrGetFullName()
        {
            return this.oMyoji + " " + this.onamae;   
        }
        
          public String ostrGetEverything()
        {

            string ostr = string.Format("Employee ID:\t {0}\nFirst Name:\t {1}\nLast Name\t {2}\nBirthDate\t {3}\nTitle\t {4}",
                this.iKaishaID, this.onamae, this.oMyoji,
                this.dtTanjoubi, this.ojobTitle);
            return ostr;
        }
    
    }//class

}
//ns
