using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is a prime: ");
            int num = int.Parse(Console.ReadLine());

            int i = 0;

            int digit = 0;

            while (i < num)
            {
                i++;
                for (int x = 2; (num % x) == 0; x++)
                {
                    digit++;
                }

            }

            if (digit>0)
            {
                Console.WriteLine("Your number is not prime");
                Console.ReadKey();
            }
            else { 
                Console.WriteLine("Your number is a prime");
                Console.ReadKey();
            }
        }
    }
}
