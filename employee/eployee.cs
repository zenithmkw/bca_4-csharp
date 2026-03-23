using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class employee
    {
        int empid;
        string name;
        int no_of_hours;
        double wage;
        double totalwage;

        public void GetData()
        {
            Console.WriteLine("Enter the employee id:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Hours");
            no_of_hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the employee salary:");
            wage = Convert.ToDouble(Console.ReadLine());
        }

        public void Calculate()
        {
            totalwage = wage * no_of_hours;
        }

        public void Display()
        {
            Console.WriteLine("Employee id: " + empid);
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Total wage: " + totalwage);
        }
    }
}
