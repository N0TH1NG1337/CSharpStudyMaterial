using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create 2 dates (however we save the address of the first one in the second one)
            Date d1 = new Date(16, 7, 1963);
            Date d2 = d1;

            d1.SetDay(20);
            d2.SetYear(1980);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            // note : it doest set the value for both since we copied the address for d2 from d1.

        }
    }
}
