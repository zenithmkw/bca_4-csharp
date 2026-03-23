using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
            r1.calculate();
            r1.display();

            rectangle r2 = new rectangle(30, 40);
            r2.calculate();
            r2.display();
        }
    }
}
