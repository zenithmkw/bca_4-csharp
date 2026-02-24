using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace prog15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            string revname = "";
            int i;
            for (i = name.Length - 1; i >= 0; i--)
            {
                revname = revname + name[i];
            }
            if (name == revname)
            {
                Console.WriteLine("entered string is palindrom");
            }
            else
            {
                Console.WriteLine("entered string is  not palindrom");
            }
        }
    }
}
