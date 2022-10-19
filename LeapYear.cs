using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public static void CheckLeapYear()
        {
            int year;
            Console.WriteLine("Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());
            if((year % 4 ==0) && (year % 100 != 0)||(year % 400 ==0))
            {
                Console.WriteLine("Given year is Leap Year");
            }
            else
            {
                Console.WriteLine("Given year is Not a Leap Year");
            }
        }
    }
}
