using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientRemainder
    {
        public static void CalculateQutientRemainder()
        {
            Console.WriteLine("Enter a number1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int quotient = number1 / number2;
            int remainder = number1 % number2;

            Console.WriteLine("Quoient : " + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
    }
}
