// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonInventoryManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this class create to do curd operation on file
    /// </summary>
    public class JsonInventoryManagement
    {
        /// <summary>
        /// this is global path of file
        /// </summary>
        string jsonFile = "C:\\Users\\bridgeit\\Desktop\\Satya\\Rice.json";

        /// <summary>
        /// This Method Getting All Details Of Report.
        /// </summary>
        public void GetDetails()
        {
            ////json is variable read all text from jsonFile.
            var json = File.ReadAllText(this.jsonFile);

            //// throw exception if file doesnt consist data.
            try
            {
                ////its convert string to json object. 
                var jObject = JObject.Parse(json);

                ////if object null then it is fasle
                if (jObject != null)
                {
                    ////this array stored the object of rice type of array
                    JArray riceArrary = (JArray)jObject["Rice"];

                    ////if riceArray not null then its condition is true and come inside to print properties of Rice
                    if (riceArrary != null)
                    {
                        ////this loop print all rice details
                        foreach (var item in riceArrary)
                        {                        
                          Console.WriteLine("Rice Name :" + item["name"].ToString());
                            Console.WriteLine("Rice Price :" + item["price"]);
                            Console.WriteLine("Rice Weight :" + item["weight"]);                         
                        }
                    }

                   ////Wheats array stored the wheats type of object                   
                    JArray wheatsArrary = (JArray)jObject["Wheats"];

                    ////if rice array not null then come inside if
                    if (riceArrary != null)
                    {
                        ////it print wheats details
                        foreach (var item in wheatsArrary)
                        {
                            Console.WriteLine("*******************************************************");
                            Console.WriteLine("Wheats Name :" + item["name"].ToString());
                            Console.WriteLine("Wheats Price :" + item["price"]);
                            Console.WriteLine("Wheats Weight :" + item["weight"]);
                        }
                    }

                    ////Pulses array stored the wheats type of object 
                    JArray pulsesArrary = (JArray)jObject["Pulses"];
                    if (riceArrary != null)
                    {
                        ////it print Pulses details
                        foreach (var item in pulsesArrary)
                        {
                            Console.WriteLine("*******************************************************");
                            Console.WriteLine("Pulses Name :" + item["name"].ToString());
                            Console.WriteLine("Pulses Price :" + item["price"]);
                            Console.WriteLine("Pulses Weight :" + item["weight"]);                      
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This Method Add The Item into the List.
        /// </summary>
        public void AddItem()
        {
            ////user enter item here to stored
            Console.WriteLine("Enter Item Name : ");
            var itemName = Console.ReadLine();

            ////user enter item type here to stored
            Console.WriteLine("Enter Type Of Item Name : ");
            string itemTypeName = Console.ReadLine();

            ////user enter item price to stored
            Console.WriteLine("\nEnter Item Price : ");
            var itemPrice = Console.ReadLine();

            ////user enter item weight to stored
            Console.WriteLine("\nEnter Item Weight : ");
            var itemWeight = Console.ReadLine();

            ////here new item or object is created to stored into file.
            var newItem = "{ 'name': " + itemTypeName + ",  'price': '" + itemPrice + "'}";

            ////here read all text of file 
            var json = File.ReadAllText(this.jsonFile);
  
            ////it convert string to json object
            var jsonObj = JObject.Parse(json);

            ////Convert object to c# array.
            var itemArrary = jsonObj.GetValue("Rice") as JArray;

            ////convert into json object
            var newItemObj = JObject.Parse(newItem);
            Console.WriteLine("newitem " + newItemObj);

            ////here add new item into array to stored
            itemArrary.Add(newItemObj);
            Console.WriteLine("Name " + itemArrary);

            ////stored new item into rice array.
            jsonObj["Rice"] = itemArrary;

            ////convert json object to string
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);

            ////write json object into file as string
            File.WriteAllText(this.jsonFile, newJsonResult);
        }

        /// <summary>
        /// this method update the file details
        /// </summary>
        public void UpdateFile()
        {
            ////read file and stored as string.
            string json = File.ReadAllText(this.jsonFile);

            ////it throw exception when invalide input enter.
            try
            {
                ////parse the json object into c# object
                var jObject = JObject.Parse(json);

                ////user enter item name to update
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();

                ////it create array of json object
                JArray riceArrary = (JArray)jObject[itemNameToUpdate];

                ////here enter type of item to update
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();

                ////user enter new item which is to stored
                Console.Write("Enter new Item name : ");
                var newItemName = Convert.ToString(Console.ReadLine());

                ////this loop check enter item is present or not.
                foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(itemName)))
                {
                    item["name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : string.Empty;
                }

                ////here stored new item into file
                jObject["name"] = riceArrary;

                ////convert the object into string
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                
                ////write string data into file
                File.WriteAllText(this.jsonFile, output);
            }
            catch (Exception ex)
            {
                ////it show exception message on console.
                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }

/// <summary>
/// this method use to delete particular record
/// </summary>
        public void DeleteFileItem()
        {
            ////read all text from file
            var jsonFileRead = File.ReadAllText(this.jsonFile);

            ////exception throw when invalide character read from file.
            try
            {
                ////parsing the json object to c# object.
                var jsonObjectConvert = JObject.Parse(jsonFileRead);

                ////user enter item name to delete
                Console.WriteLine("Enter Item Name ");
                string itemNameToDelete = Console.ReadLine();

                ////convert into json object 
                JArray itemsArrary = (JArray)jsonObjectConvert[itemNameToDelete];

                ////enter name of item to delete
                Console.Write("Enter Name to Delete Item : ");
                var itemName = Console.ReadLine();

                ////this is item name to delete
                var itemToDeleted = itemsArrary.FirstOrDefault(obj => obj["name"].Value<string>().Equals(itemName));

                ////here delete the item
                itemsArrary.Remove(itemToDeleted);

                ////here write new item into file
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObjectConvert, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
            }
            catch (Exception e)
            {
                ////show exception on console
                Console.WriteLine("Exception Occurs : " + e);
            }
        }
    }
}