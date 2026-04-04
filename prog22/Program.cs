using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            savings s1 = new savings(); 
            s1.get_account();
            s1.get_data();
            s1.display();
            s1.show();


        }
    }
}
