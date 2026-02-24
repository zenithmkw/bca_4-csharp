using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[10];
            Console.WriteLine("enter 10 numbers");
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = int.Parse(Console.ReadLine());

            }
            for (int i = myarray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myarray[i]);
            }

        }
    }
}
