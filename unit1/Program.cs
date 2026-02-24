using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("hello");
            Console.Write("enter value for a:");
            double a = int.Parse(Console.ReadLine());
            Console.Write("enter value for b:");
            double b = Convert.ToInt32(Console.ReadLine());
            double add = a + b;
            double sub = a - b;
            double mul = a * b;
            double div = a / b;
            double mod = a % b;
            Console.WriteLine("addition :" + add);
            Console.WriteLine("subtraction :" + sub);
            Console.WriteLine("multiplication :" + mul);
            Console.WriteLine("division :" + div);
            Console.WriteLine("modulus :" + mod);
            Console.Write("bye");

        }
    }
}
