using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int i, m;
            for (i = 2; i <= n-1; i++)
            {
                m = n % i;
                if (m == 0)
                {
                    Console.WriteLine("not a prime number");
                    break;
                }
                
            }
            if (i == n)
            {
                Console.WriteLine("not prime");
            }
            
        }
        
    }
}
