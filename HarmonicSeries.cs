using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicSeries
    {
        public static void HarmonicNumberSeries()
        {
            int i;
            double s = 0.0;
            Console.WriteLine("Enter The Number of Terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("1/" + i);
                s += 1/(float)i;
            }
        }
    }
}
