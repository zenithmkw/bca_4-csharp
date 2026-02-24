using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    internal class p3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simple intrest");
            Console.Write("enter amount :");
            double p = int.Parse(Console.ReadLine());
            Console.Write("enter rate :");
            double r = int.Parse(Console.ReadLine());
            Console.Write("enter number of year :");
            double n = int.Parse(Console.ReadLine());
            double si = (p * r * n) / 100;
            Console.WriteLine("simple intrest is :" + si);

            



        }

    }
}
