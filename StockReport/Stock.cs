using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOriented.StockReport
{
    public class Stock
    {
        public string nameOfShare;
       public int numberOfShare;
       public double sharePrice;
        public void StockGetInput()
        {
            Console.WriteLine("Enter Name of Share/Stock ");
             nameOfShare = Console.ReadLine();
            Console.WriteLine("Enter Number of Share ");
             numberOfShare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Per Share ");
            sharePrice = Convert.ToInt32(Console.ReadLine()); 
        }
    }
}
