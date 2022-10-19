using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelConsonent
    {
        public static void VowelAndConsonent()
        {
            Console.WriteLine("Enter a Letter : ");
            char c = Convert.ToChar(Console.Read());
            if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'||
                c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine(c + " is Vowel");
            }
            else
            {
                Console.WriteLine(c + " is Consonent");
            }
        }
    }
}
