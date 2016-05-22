using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class BankAccount
    {
        private double accountbalance = 0;
        public void Deposit()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 9 && hour <= 13)
            {
                Console.Write("Enter amount to be deposited : ");
                double amount = Convert.ToInt32(Console.ReadLine());
                accountbalance = amount++;
            }
            else
                Console.WriteLine("Deposits are allowed only in working hours");
        }
        public void showbalance()
        {
            Console.WriteLine("Account balance is : {0}", accountbalance);
        }
    }
}