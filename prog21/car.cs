using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog21
{
    internal class car : vehicle
    {
        string model_type,company_name;
        public void get_car()
        {
            Console.WriteLine("enter the model type");
            model_type = Console.ReadLine();
            Console.WriteLine("enter the company name");
            company_name = Console.ReadLine();
        }
        public void show_car()
        {
            Console.WriteLine("the model type is: " + model_type);
            Console.WriteLine("the company name is: " + company_name);
        }

    }
}
