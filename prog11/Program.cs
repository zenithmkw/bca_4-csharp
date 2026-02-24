using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ending number:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers in the given range:");
            int i, m;
            for (int n = start; n <= end; n++)
            {
                for ( i = 2; i <= n - 1; i++)
                {
                    m = n % i;
                    if (m == 0)
                    {
                      
                        break;
                    }

                }
                if (i == n)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}