using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayColectionConVer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] weekday = new string[7];
                weekday[0] = "Sunday";
                weekday[1] = "Monday";
                weekday[2] = "Tuesday";
                weekday[3] = "Wednesday";
                weekday[4] = "Thursday";
                weekday[5] = "Friday";
                weekday[6] = "Saturday";

                // string[] months = new string[] { "jan", "feb", "mar", "apr", "may", "jun", "jul", "Aug", "sep" };

                string[] months = new string[9] { "jan", "feb", "mar", "apr", "may", "jun", "jul", "Aug", "sep" };

                //display day: using for each loop
                foreach (string day in weekday)
                {
                    Console.WriteLine(day);

                }
                foreach (string month in months)
                {
                    Console.WriteLine(month);

                }
            }
        }
    }
}
