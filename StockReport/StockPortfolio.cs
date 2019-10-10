using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOriented.StockReport
{
    public class StockPortfolio
    {
        public static void StockReport()
        {
            Console.WriteLine("Enter Number of stock ");
            int numberOfStock = Convert.ToInt32(Console.ReadLine());
            Stock[] stock = new Stock[numberOfStock];

            for (int i = 0; i < numberOfStock; i++)
            {
                stock[i] = new Stock();
                stock[i].StockGetInput();
            }

            List<Stock> writeStock = new List<Stock>();
            for (int i = 0; i < numberOfStock; i++)
            {
                writeStock.Add(stock[i]);
            }

            string jsonStock = JsonConvert.SerializeObject(stock, Formatting.Indented);
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\stock.json";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();
            /// Reading A file
            /// 
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();

            List<Stock> stockList = JsonConvert.DeserializeObject<List<Stock>>(readString);


            double totalSharePrice = 0;

            foreach (Stock objStock in stockList)
            {
                totalSharePrice = objStock.sharePrice * objStock.numberOfShare;
                Console.WriteLine("Name Of Stock : " + objStock.nameOfShare);
                Console.WriteLine("Total Share : " + objStock.numberOfShare);
                Console.WriteLine("Each Share Price " + objStock.sharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalSharePrice);
            }
            Console.WriteLine("Where You Want to Invest Your Share");
            string userStockName = Console.ReadLine();
            foreach (Stock objStock in stockList)
            {
                if (userStockName.Equals(objStock.nameOfShare))
                {
                    Console.WriteLine("How Many Share You Want To Buy");
                    int userNumberOfShare = Convert.ToInt32(Console.ReadLine());
                    double totalUserSharePrice = userNumberOfShare * objStock.sharePrice;
                    int availableShare = objStock.numberOfShare - userNumberOfShare;
                    Console.WriteLine("Your Total Share Price : " + totalUserSharePrice);
                    Console.WriteLine("Available Share Of {0} is {1}", objStock.nameOfShare, availableShare);        
                }
            }
        }
    }
}
