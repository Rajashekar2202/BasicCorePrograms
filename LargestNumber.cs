using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public static void LargestInThreeNumbers()
        {
            Console.WriteLine("Enter The First Number ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Third Number ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1 + " is Largest Number");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2 + " is Largest Number");
            }
            else 
            {
                Console.WriteLine(number3 + " is Largest Number");
            }
        }
    }
}
