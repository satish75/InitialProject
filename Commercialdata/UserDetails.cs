using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Commercialdata
{
   public class UserDetails
    {

        public string accountHolderName;
        public double totalAmountAccountHolder;
        public void UseGetInput()
        {
            Console.WriteLine("Enter Account Holder UserName");
             accountHolderName = Console.ReadLine();
            Console.WriteLine("How Many Doller Do You Have (Total Amount)");
             totalAmountAccountHolder = Convert.ToInt32(Console.ReadLine());

        }
    }
}
