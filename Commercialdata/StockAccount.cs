using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ObjectOriented.Commercialdata
{
    public interface StockAccountInterface
    {
        void StockAcountCreate();
        double ValueOf();
        void Buy();
        void Sell();
        void Save();
        void PrintReport();
    }
    public class StockAccount:StockAccountInterface
    {
       
       
      //  public IList<StockAccount> listOfStock { get; set; }
        public void StockAcountCreate()
        {


            ///write user
            ///
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json";
            Console.WriteLine("How Many User Want To Create Account ");
            int numberOfUser = Convert.ToInt32(Console.ReadLine());
            UserDetails[] user = new UserDetails[numberOfUser];

            for (int i = 0; i < numberOfUser; i++)
            {
                user[i] = new UserDetails();
                user[i].UseGetInput();
            }

            List<UserDetails> writeUser = new List<UserDetails>();
            for (int i = 0; i < numberOfUser; i++)
            {
                writeUser.Add(user[i]);
            }

            string jsonStock = JsonConvert.SerializeObject(user, Formatting.Indented);

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();

        }

       public double ValueOf()
        {
            return 0;
        }
        public void ShowMyAccount()
        {

            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json";
            string json = File.ReadAllText(path);
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            streamReader.Close();
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();
            foreach (UserDetails objStock in userList)
            {
                string newUserUpdate = objStock.accountHolderName;
                if (newUserUpdate.Equals(accountHolderName))
                {
                    Console.WriteLine("**************************************************************************************");
                    Console.WriteLine("UserName     : " + newUserUpdate);
                    Console.WriteLine("Total Amount : " + objStock.totalAmountAccountHolder);
                    Console.WriteLine("**************************************************************************************");
                }
            }
        }
        public void Buy()
        {
          int availableShareOfStock=0 ;
            double sharePrice=0.0;
            bool isValideUser = false;
           /// string nameOfStock = "";
            ///
            double ValideToBuy=0.0;
            double totalAmountOfUser=0;
            string name = "";
            string userName = "";
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();
            ///display Stock Report.
            GetDetails();
            Console.WriteLine("Enter Stock Name To Buy Share");
            string stockName = Console.ReadLine();
            Console.WriteLine("How Many Share You Wnat To Buy ");
            int numberOfShareBuy = Convert.ToInt32(Console.ReadLine());

         ///This code get the stock details to update 

            string readPath="C:\\Users\\bridgeit\\Desktop\\Satya\\stockDetails.json";         
            var json = File.ReadAllText(readPath);
            var jObject = JObject.Parse(json);
            string jsonPath = File.ReadAllText(readPath);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonPath);
            int i;
            for (i = 0; i < 5; i++)
            {
                string retriveName = jsonObj["stockReport"][i]["stockName"];

                if (retriveName.Equals(stockName))
                {
                    sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                    availableShareOfStock = jsonObj["stockReport"][i]["noOfShare"];
                    name = jsonObj["stockReport"][i]["stockName"];
                    break;
                }
            }

            ///this code use to update where user want to buy the share
            StreamReader streamReaderUser = new StreamReader("C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json");
            string readUserFile = streamReaderUser.ReadToEnd();
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readUserFile);
            foreach (UserDetails objUser in userList)
            {
                 userName =objUser.accountHolderName;
           
                if (userName.Equals(accountHolderName))
                {
                    totalAmountOfUser = objUser.totalAmountAccountHolder;
                    ValideToBuy = numberOfShareBuy * sharePrice;

                    if (totalAmountOfUser >= ValideToBuy)
                    {
                       // Console.WriteLine("Eligible");
                        isValideUser = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Dont Have Sufficient Dollers");
                    }
                }           
               
            }

            ///After Eligible
            ///
            availableShareOfStock =availableShareOfStock - numberOfShareBuy;
            totalAmountOfUser = totalAmountOfUser - ValideToBuy;
            Save(name,availableShareOfStock, totalAmountOfUser);
            Save(userName, totalAmountOfUser);

        }
        public void Sell()
         {
             throw new NotImplementedException();
         }
         public void PrintReport()
         {
            GetDetails();
         }

         public void Save()
         {
            
         }

         public static void GetDetails()
         {
             string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\stockDetails.json";
            /*
             Console.WriteLine("Enter Number of stock ");
             int numberOfStock = Convert.ToInt32(Console.ReadLine());
             StockDetails[] stock = new StockDetails[numberOfStock];

             for (int i = 0; i < numberOfStock; i++)
             {
                 stock[i] = new StockDetails();
                 stock[i].StockGetInput();
             }

             List<StockDetails> writeStock = new List<StockDetails>();
             for (int i = 0; i < numberOfStock; i++)
             {
                 writeStock.Add(stock[i]);
             }

             string jsonStock = JsonConvert.SerializeObject(stock, Formatting.Indented);

             StreamWriter streamWriter = new StreamWriter(path);
             streamWriter.WriteLine(jsonStock);
             streamWriter.Close();
             */
            /// Reading A file
            /// 
            // StreamReader streamReader = new StreamReader(path);
            //  string readString = streamReader.ReadToEnd();
            var json = File.ReadAllText(path);
             var jObject = JObject.Parse(json);


                JArray experiencesArrary = (JArray)jObject["stockReport"];
            if (experiencesArrary != null)
            {
                foreach (var objStock in experiencesArrary)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.Write("\t Stock Name: " + objStock["stockName"].ToString());
                    Console.Write("\t Total Share: " + objStock["noOfShare"]);
                    Console.Write("\t Share Price: " + objStock["sharePrice"] + "\n\n");
                }

            }
            /*List<StockDetails> stockList = JsonConvert.DeserializeObject<List<StockDetails>>(readString);
            foreach (StockDetails objStock in stockList)
            {
              
              
            }
      */

        }

        /// <summary>
        /// Update File
        /// </summary>
      public void Save(string nameOfStock , int availableShareOfStock, double totalAmountOfUser)
        {

          
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\stockDetails.json";
            string json = File.ReadAllText(path);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            int i;
            for ( i= 0;i < 5 ;i++)
            {
               string retriveName= jsonObj["stockReport"][i]["stockName"];
              
                if (retriveName.Equals(nameOfStock))
                {
                    jsonObj["stockReport"][i]["noOfShare"] = availableShareOfStock;
                    break;
                }
            }             
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);
            // var myFile = File.Create(path);
            //  myFile.Close();
         //   StreamWriter streamWriter = new StreamWriter("C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json");
         //   streamWriter.WriteLine(output);
           // streamWriter.Close();
        }


        public void Save(string userName,double userTotalAmount)
        {

         
        
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\userDetailUpdate.json";
            string json = File.ReadAllText(path);
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            streamReader.Close();
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

            foreach (UserDetails objStock in userList)
            {
                string newUserUpdate = objStock.accountHolderName;
               if(newUserUpdate.Equals(userName))
                {
                    double totalAmount = userTotalAmount;
                    userList.Remove(objStock);
                    userList.Add(new UserDetails { accountHolderName = objStock.accountHolderName, totalAmountAccountHolder = totalAmount });
                    string updateUserData = JsonConvert.SerializeObject(userList, Formatting.Indented);


                    StreamWriter streamWriter = new StreamWriter("C:\\Users\\bridgeit\\Desktop\\Satya\\userDetailUpdate.json");
                    streamWriter.WriteLine(updateUserData);
                    streamWriter.Close();

                   // Console.WriteLine("user Update"+totalAmount);
                    break;
                }
              
            }
        }

    }
}


