// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.StockReport
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this class implement logic of stock portfolio
    /// </summary>
    public class StockPortfolio
    {
        /// <summary>
        /// this method get stock report
        /// </summary>
        public static void StockReport()
        {
            ////here enter number of stock .
            Console.WriteLine("Enter Number of stock ");
            int numberOfStock = Convert.ToInt32(Console.ReadLine());

            ////here create stock object
            Stock[] stock = new Stock[numberOfStock];

            ////here get memory to each stock object
            for (int i = 0; i < numberOfStock; i++)
            {
                ////get dynamically memory
                stock[i] = new Stock();

                ////take data input and call to stock get method.
                stock[i].StockGetInput();
            }

            ////create list of stock object
            List<Stock> writeStock = new List<Stock>();

            ////add stock object one by one into list
            for (int i = 0; i < numberOfStock; i++)
            {
                writeStock.Add(stock[i]);
            }

            ////convert into byte of stream
            string jsonStock = JsonConvert.SerializeObject(stock, Formatting.Indented);

            ////file path to write data
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\stock.json";

            ////write string into a specific file 
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);

            ////closed file here
            streamWriter.Close();

            //// Reading A file here create object        
            StreamReader streamReader = new StreamReader(path);

            ////read file start to end and stored into string
            string readString = streamReader.ReadToEnd();

            ////read object and stored into list of stock object
            List<Stock> stockList = JsonConvert.DeserializeObject<List<Stock>>(readString);

            ////total share value of stock
            double totalSharePrice = 0;

            ////this loop print report of stock
            foreach (Stock objStock in stockList)
            {
                totalSharePrice = objStock.sharePrice * objStock.numberOfShare;
                Console.WriteLine("Name Of Stock : " + objStock.nameOfShare);
                Console.WriteLine("Total Share : " + objStock.numberOfShare);
                Console.WriteLine("Each Share Price " + objStock.sharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalSharePrice);
            }

            ////in which company you want to invest share 
            Console.WriteLine("Where You Want to Invest Your Share");
            string userStockName = Console.ReadLine();

            ////to check stock is valide or not
            foreach (Stock objStock in stockList)
            {
                try
                {
                    ////if stock is available then true
                    if (userStockName.Equals(objStock.nameOfShare))
                    {
                        ////How Many Share You Want To Buy by user
                        Console.WriteLine("How Many Share You Want To Buy");
                        int userNumberOfShare = Convert.ToInt32(Console.ReadLine());

                        ////it hold total share price of user buy
                        double totalUserSharePrice = userNumberOfShare * objStock.sharePrice;

                        ////it hold available share of company
                        int availableShare = objStock.numberOfShare - userNumberOfShare;

                        ////here print  available share and its name
                        Console.WriteLine("Your Total Share Price : " + totalUserSharePrice);
                        Console.WriteLine("Available Share Of {0} is {1}", objStock.nameOfShare, availableShare);
                    }
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Invalide Formate Entered" + f);
                }
            }
        }
    }
}