using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace prog3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("compound intrest");
            Console.Write("enter amount :");
            double p = int.Parse(Console.ReadLine());
            Console.Write("enter rate :");
            double r = int.Parse(Console.ReadLine());
            Console.Write("enter number of year :");
            double n = int.Parse(Console.ReadLine());
            double a = p * Math.Pow(1 + (r / 100), n);
            double ci = a - p;
            Console.WriteLine("Compound intrest is" + ci);
        }
    }
}
