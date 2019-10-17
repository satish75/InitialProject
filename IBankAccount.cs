using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    interface IBankAccount
    {
        public double WithdrawCash();
    }
   public class Customer : IBankAccount
    {

        public static double AvailableBalance { get; set; }
        public double WithdrawCash()
        {        
            Console.WriteLine("Enter Cash To Withdraw ");
            double cashWithdraw = Convert.ToDouble(Console.ReadLine());
            AvailableBalance = AvailableBalance - cashWithdraw;
            return AvailableBalance;
        }
    }
    public class AtmProxy : IBankAccount
    {
        public double WithdrawCash()
        {
            Customer customer = new Customer();           
           return customer.WithdrawCash();
        }
    }
}
