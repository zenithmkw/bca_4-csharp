using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius of your circle");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double a = pi * Math.Pow(r, 2);
            Console.WriteLine("area :" + a);
        }
    }
}
