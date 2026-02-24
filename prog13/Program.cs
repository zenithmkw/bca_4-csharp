using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1 + " is smallest");
            }
            else if (n2 < n3)
            {
                Console.WriteLine(n2 + " is smallest");
            }
            else if (n3 < n2)
            {
                Console.WriteLine(n3 + " is smallest");
            }
            else 
            { 
                Console.WriteLine("equal numbers");
            }
        }
    }
}
