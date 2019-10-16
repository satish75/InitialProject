using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
  
    public class CompanyAdaptee
    {
        public List<string> getList()
        {
            List<string> productList = new List<string>();
            Console.WriteLine("How Many Product Available in Your Company ");
            int noOfProducts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Comapny Product List ");
            for (int i=0;i<noOfProducts;i++)
            {
                string product = Console.ReadLine();
                productList.Add(product);
            }

            return productList;
        }          
    }
    public interface ITarget
    {
      public  List<string> getProducts();
    }
    public class VenderAdapter : ITarget
    {
       public List<string> getProducts()
        {
            CompanyAdaptee adaptee = new CompanyAdaptee();
            return adaptee.getList();
        }
    }
}
