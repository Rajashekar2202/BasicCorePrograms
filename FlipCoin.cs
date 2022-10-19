using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        public static void CalculatePercentage()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("Enter the value of Number of Flips");
            int flipcoin = Convert.ToInt32(Console.ReadLine());
            if(flipcoin > 0)
            {
                for(int i = 0; i < flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The Flip is " + number);

                    if(number == 1)
                    {
                        headcount++;
                    }
                    else
                    {
                        tailcount++;
                    }
                }

                headpercentage = headcount*100 / flipcoin; 
                tailpercentage = tailcount*100 / flipcoin;

                Console.WriteLine("The Head Percentage is " + headpercentage);
                Console.WriteLine("The Tail Percentage is " + tailpercentage);
            }
            else
            {
                Console.WriteLine("Please Enter Positive Number ");
            }
        }
    }
}
