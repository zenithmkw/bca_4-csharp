using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog22
{
    internal class savings: account
    {
        int interest_rate;
        public void get_data()
        {
            Console.WriteLine("enter the interest");
            interest_rate = int.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("the interest is: " + interest_rate);
        }
    }
}
