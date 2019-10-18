using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   public class ReflectionCompany
    {
        public string companyName { get; set; }
        public int companyEstablishYear { get; set; }
        public int numberOfEmployee { get; set; }
        public double turnOver { get; set; }

       
       public void ComapanyDetails()
        {
            Console.WriteLine("Company Name : {0}\tCompany Establish Year : {1}\tTotal Employee : {2}\tYearly TurnOver : {3}", companyName,
               companyEstablishYear , numberOfEmployee , turnOver);
        }
    }

}
