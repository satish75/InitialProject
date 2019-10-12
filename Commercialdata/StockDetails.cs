using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Commercialdata
{
    public class StockDetails
    {
        public string stockName;
        public int noOfShare;
        public double sharePrice;
        //public string stockReport;
        public void StockGetInput()
        {
            Console.WriteLine("Enter Name of Share/Stock ");
            stockName = Console.ReadLine();
            Console.WriteLine("Enter Number of Share ");
            noOfShare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Per Share ");
            sharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
