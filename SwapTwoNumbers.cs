using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public static void SwappingTwoNumbers()
        {
            Console.WriteLine("Enter The First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3;

            num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("After Swapping First Number : " + num1);
            Console.WriteLine("After Swapping Second Number : " + num2);
        }
    }
}
