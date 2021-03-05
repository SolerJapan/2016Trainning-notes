using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    enum titles
    {
        associate, developer, manager, director, ceo, none 
    }

    class emp
    {
        private int empID;
        private DateTime birthDate = default(DateTime);

        private string fName = null;
        private string lName = null;
        private string jobTitle = null;
        private titles title = titles.none;

        public emp (int empID, DateTime birthDate, string fName, string lName, string jobTitle)
        {
            this.empID = empID;
            this.birthDate = birthDate;
            this.fName = fName;
            this.lName = lName;
            this.jobTitle = jobTitle;
        }

        public emp()
        {
            this.empID = 0;
            this.birthDate = new DateTime(year:2000, month:1, day:1);
            this.fName = "Alex";
            this.lName = "Soler";
            this.jobTitle = "Programmer";
        }

        public emp(int empID, DateTime birthDate, string fName, string lName, string jobTitle, titles title)
        {
            this.empID = empID;
            this.birthDate = birthDate;
            this.fName = fName;
            this.lName = lName;
            this.jobTitle = jobTitle;
        }

        public int p_empID
        {
            get
            {
                return this.empID;
            }
            set
            {
                if(value > -1)
                {
                    this.empID = value;
                }
                else
                {
                    Console.WriteLine("dddd");
                }

            }
        }


        public string oStringGetFullName()
        {
            return this.fName + " " + this.lName;
        }

        public String ostrGetEverything()
        {

            string ostr = string.Format("Employee ID:\t {0}\nFirst Name:\t {1}\nLast Name\t {2}\nBirthDate\t {3}\nTitle\t {4}",
                this.empID, this.fName, this.lName,
                this.birthDate, this.jobTitle);
            return ostr;
        }
    }
}
