using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.GetData();
            e.Calculate();
            e.Display();
        }
    }
}
