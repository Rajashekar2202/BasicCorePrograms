using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Factors
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            Console.WriteLine("Factors of " + number + " is ");
            for(i = 2; i < number; i++)
            {
                while(number % i == 0)
                {
                    Console.WriteLine(i + "  ");
                    number = number / i;

                }
            }
        }
    }
}
