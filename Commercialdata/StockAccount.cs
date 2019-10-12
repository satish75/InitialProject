﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Commercialdata
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
   
    /// <summary>
    /// This is Stack Account Interface which declared all methods which is implemented in child class.
    /// </summary>
    public interface IStockAccountInterface
    {
        /// <summary>
        /// declaration of Account create method.
        /// </summary>
        void StockAcountCreate();

        /// <summary>
        /// declaration of Account create method.
        /// </summary>
        /// <returns>it return total share of user</returns>
        double ValueOf();

        /// <summary>
        /// declaration of buy share method.
        /// </summary>
        void Buy();

        /// <summary>
        /// declaration of buy share method.
        /// </summary>
        void Sell();

        /// <summary>
        /// declaration of Sell Method
        /// </summary>
        void Save();

        /// <summary>
        /// declaration of report method.
        /// </summary>
        void PrintReport();
    }

    /// <summary>
    /// This is Stock class which implements Stock Account Interface.
    /// </summary>
    public class StockAccount : IStockAccountInterface
    {
        /// <summary>
        /// This method create the account of multiple users.
        /// </summary>
        public void StockAcountCreate()
        {
           ////this line take the path of user details file.
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json";

           ////here create number of users.
            Console.WriteLine("How Many User Want To Create Account ");
            int numberOfUser = Convert.ToInt32(Console.ReadLine());

            ////this is user array which stored multiple user object.
            UserDetails[] user = new UserDetails[numberOfUser];

            ////this for loop create the memory to multiple users.
            for (int i = 0; i < numberOfUser; i++)
            {
                user[i] = new UserDetails();
                user[i].UseGetInput();
            }

            ////this line create list of user details type.
            List<UserDetails> writeUser = new List<UserDetails>();

            ////this for loop used to add multiple user into list of user details.
            for (int i = 0; i < numberOfUser; i++)
            {
                writeUser.Add(user[i]);
            }

            ////this line convert the object into string.
            string jsonStock = JsonConvert.SerializeObject(user, Formatting.Indented);
            
            ////Stream Writer is used for to write into file. 
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();
        }

        /// <summary>
        /// this method return all number of share buy by user.
        /// </summary>
        /// <returns>it return total share</returns>
       public double ValueOf()
        {
            return 0;
        }

        /// <summary>
        /// This method show the account of particular user.
        /// </summary>
        public void ShowMyAccount()
        {
            ////this line take the path of user details file.
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json";

            ////here read all text from file and stored into json string.
            string json = File.ReadAllText(path);

            ////stream reader read the file which path we provided.
            StreamReader streamReader = new StreamReader(path);

            ////this line read start to end text from file.
            string readString = streamReader.ReadToEnd();
            streamReader.Close();

            ////it create list of user object from given string.
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

            ////here user must provide the user name to check account.
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();

            ////this loop take the one by one object from list of user object.
            foreach (UserDetails objStock in userList)
            {
                ////this string retrive the name of user.
                string newUserUpdate = objStock.accountHolderName;

                ////if condition check the user is available or not.
                if (newUserUpdate.Equals(accountHolderName))
                {
                    ////This line print report details.
                    Console.WriteLine("**************************************************************************************");
                    Console.WriteLine("UserName     : " + newUserUpdate);
                    Console.WriteLine("Total Share Buy  : " + objStock.noOfShareBuyUser);
                    Console.WriteLine("Total Amount : " + objStock.totalAmountAccountHolder);
                    Console.WriteLine("**************************************************************************************");
                }
            }
        }

        /// <summary>
        /// this is buy method used by user to buy shares of company.
        /// </summary>
        public void Buy()
        {
            ////this variable use to check available share of campany.
            int availableShareOfStock = 0;

            ////this variable use to check Current share of campany.
            int previousShare = 0;

           ////this variable use to take share price of campany.
            double sharePrice = 0.0;

            ////this variable use to check user is valide or not to buy share .
            double ValideToBuy = 0.0;

            ////this variable use to check total amount of user.
            double totalAmountOfUser = 0;

            ////this variable use to take name of campany.
            string name = string.Empty;

            ////this variable use to take name share .
            string userName = string.Empty;
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();

            ////this method display Stock Report.
              GetDetails();

            ////here user enter whichever stock he want to buy.
            Console.WriteLine("Enter Stock Name To Buy Share");
            string stockName = Console.ReadLine();

            ////here user enter how many share he want to buy
            Console.WriteLine("How Many Share You Wnat To Buy ");
            int numberOfShareBuy = Convert.ToInt32(Console.ReadLine());

         ////This code get the stock details to update stock file records.
            string readPath = "C:\\Users\\bridgeit\\Desktop\\Satya\\stockDetails.json";         
            var json = File.ReadAllText(readPath);
            var jObject = JObject.Parse(json);

            ////read the file here.
            string jsonPath = File.ReadAllText(readPath);

            ////it dynamically create object.
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonPath);

            ////this loop use to take share price of particular stock.
            int i;
            for (i = 0; i < 5; i++)
            {
                string retriveName = jsonObj["stockReport"][i]["stockName"];

                ////this if condition check stock name is available in file or not.
                if (retriveName.Equals(stockName))
                {
                    sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                    availableShareOfStock = jsonObj["stockReport"][i]["noOfShare"];
                    name = jsonObj["stockReport"][i]["stockName"];
                    break;
                }
            }

            ////this code use to update where user want to buy the share with specified file path.
            StreamReader streamReaderUser = new StreamReader("C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json");
            string readUserFile = streamReaderUser.ReadToEnd();
            streamReaderUser.Close();

            ////this line create list of object.
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readUserFile);

            ////this use to check the particular user for update.
            foreach (UserDetails objUser in userList)
            {    
                ////userName stored the current user name.
                userName = objUser.accountHolderName;   
                
                ////it check user Name is Valide Or not.
                if (userName.Equals(accountHolderName))
                {
                    totalAmountOfUser = objUser.totalAmountAccountHolder;
                    previousShare = objUser.noOfShareBuyUser + numberOfShareBuy;
                    ValideToBuy = numberOfShareBuy * sharePrice;

                   ////if available balance of user is greater than buying share then true this condition.
                    if (totalAmountOfUser >= ValideToBuy)
                    {                     
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Dont Have Sufficient Dollers");
                    }
                }                         
            }

            ////After Eligible to buy share 
            ////update the available share of company.
            availableShareOfStock = availableShareOfStock - numberOfShareBuy;
            totalAmountOfUser = totalAmountOfUser - ValideToBuy;

            ////this method Update the Campany Shares 
            this.Save(name, availableShareOfStock, totalAmountOfUser);

            ////this method update user Account
            this.Save(userName, totalAmountOfUser, previousShare);
        }

        /// <summary>
        /// this method sell the share by user.
        /// </summary>
        public void Sell()
         {
             throw new NotImplementedException();
         }

        /// <summary>
        /// this print method show all reports of stock report.
        /// </summary>
         public void PrintReport()
         {
            ////this method print stock report.
            GetDetails();
         }

        /// <summary>
        /// This is empty method.
        /// </summary>
         public void Save()
         {           
         }

        /// <summary>
        /// this method get all details of stock file or report data.
        /// </summary>
         public static void GetDetails()
         {
            ////this file path used to read the file.
             string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\stockDetails.json";
              
            ////read all text start to end of file.
            var json = File.ReadAllText(path);
             var jObject = JObject.Parse(json);

            ////it create json array of object.
                JArray stockArrary = (JArray)jObject["stockReport"];

            ////if stock array not null then its true condition
            if (stockArrary != null)
            {
                ////this for loop print all record of stock details.
                foreach (var objStock in stockArrary)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.Write("\t Stock Name: " + objStock["stockName"].ToString());
                    Console.Write("\t Total Share: " + objStock["noOfShare"]);
                    Console.Write("\t Share Price: " + objStock["sharePrice"] + "\n\n");
                }
            }          
        }

        /// <summary>
        /// it update stock file.
        /// </summary>
        /// <param name="nameOfStock">nameOfStock</param>
        /// <param name="availableShareOfStock">availableShareOfStock</param>
        /// <param name="totalAmountOfUser">totalAmountOfUser</param>
        public void Save(string nameOfStock, int availableShareOfStock, double totalAmountOfUser)
        {
            ////this file path used to read the file.
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\stockDetails.json";
            string json = File.ReadAllText(path);

            ////it dynamically create object.
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            int i;

            ////this loop use to take share price of particular stock.
            for (i = 0; i < 5; i++)
            {
               string retriveName = jsonObj["stockReport"][i]["stockName"];
              
                ////it check stock name is valide or not.
                if (retriveName.Equals(nameOfStock))
                {
                    jsonObj["stockReport"][i]["noOfShare"] = availableShareOfStock;
                    break;
                }
            } 
            
            ////it write the record into file .
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);          
        }

        /// <summary>
        /// this method used to update user account data.
        /// </summary>
        /// <param name="userName">it take user name</param>
        /// <param name="userTotalAmount">it take total amount</param>
        /// <param name="currentShare">it take current share</param>
        public void Save(string userName, double userTotalAmount, int currentShare)
        {
            ////return path of json file.
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json";
            string json = File.ReadAllText(path);

            ////read the file 
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            streamReader.Close();

            ////create list of object of user details type.
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

            ////this loop is use for to check where should update.
            foreach (UserDetails objStock in userList)
            {
                string newUserUpdate = objStock.accountHolderName;

                ////it check user is match or not.
               if (newUserUpdate.Equals(userName))
                {
                    double totalAmount = userTotalAmount;
                    userList.Remove(objStock);
                    userList.Add(new UserDetails { accountHolderName = objStock.accountHolderName, totalAmountAccountHolder = totalAmount, noOfShareBuyUser = currentShare });
                    string updateUserData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                    ////this write or update the user account details.
                    StreamWriter streamWriter = new StreamWriter("C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json");
                    streamWriter.WriteLine(updateUserData);
                    streamWriter.Close();
                    break;
                }              
            }
        }
    }
}