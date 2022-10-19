using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public static void PowerOfTheTwo()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number >= 0 && number <= 31)
            {
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Enter the Number between 2 to 31 only");
            }
        }
    }
}
