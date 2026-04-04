using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog22
{
    internal class account
    {
        int accountno,balance;
        public void get_account()
        {
            Console.WriteLine("enter the account number");
            accountno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the balance");
            balance = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("the account number is: " + accountno);
            Console.WriteLine("the balance is: " + balance);
        }
    }
}
