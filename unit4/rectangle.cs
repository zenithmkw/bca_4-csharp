using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit4
{
    internal class rectangle
    {
        int l, w, area;
        public void getdata()
        {
            Console.WriteLine("enter the length of rectangle");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the width of rectangle");
            w = Convert.ToInt32(Console.ReadLine());
        }
        public void calculate()
        {
            area = l * w;
        }
        public void Display()
        {
            Console.WriteLine("area is :" + area);
        }


    }
}
