using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.InventoryManagement
{
    public class JsonInventoryManagement
    {
        string jsonFile = "C:\\Users\\bridgeit\\Desktop\\Satya\\Rice.json";

        /// <summary>
        /// This Method Getting All Details Of Report.
        /// </summary>
        public void GetDetails()
        {

            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray riceArrary = (JArray)jObject["Rice"];
                    if (riceArrary != null)
                    {
                        foreach (var item in riceArrary)
                        {
                            Console.WriteLine("Rice Name :" + item["name"].ToString());
                            Console.WriteLine("Rice Price :" + item["price"]);
                            Console.WriteLine("Rice Weight :" + item["weight"]);
                        }

                    }
                    ///This Method print the Wheats Details.
                    ///
                    JArray wheatsArrary = (JArray)jObject["Wheats"];
                    if (riceArrary != null)
                    {
                        foreach (var item in wheatsArrary)
                        {
                            Console.WriteLine("Wheats Name :" + item["name"].ToString());
                            Console.WriteLine("Wheats Price :" + item["price"]);
                            Console.WriteLine("Wheats Weight :" + item["weight"]);
                        }

                    }
                    ///This Method print the Pulses Details.
                    ///
                    JArray pulsesArrary = (JArray)jObject["Wheats"];
                    if (riceArrary != null)
                    {
                        foreach (var item in pulsesArrary)
                        {
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
            Console.WriteLine("Enter Item Name : ");
            var itemName = Console.ReadLine();
            Console.WriteLine("Enter Type Of Item Name : ");
            string itemTypeName = Console.ReadLine();
            Console.WriteLine("\nEnter Item Price : ");
            var itemPrice = Console.ReadLine();
            Console.WriteLine("\nEnter Item Weight : ");
            var itemWeight = Console.ReadLine();
            var newItem = "{ 'name': " + itemTypeName + ",  'price': '" + itemPrice + "'}";

            var json = File.ReadAllText(jsonFile);
            Console.WriteLine(json);
            var jsonObj = JObject.Parse(json);
            var itemArrary = jsonObj.GetValue("Rice") as JArray;
            var newItemObj = JObject.Parse(newItem);
            Console.WriteLine("newitem " + newItemObj);
            itemArrary.Add(newItemObj);
            Console.WriteLine("Name " + itemArrary);
            jsonObj["Rice"] = itemArrary;

            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                   Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFile, newJsonResult);

        }


        public void UpdateFile()
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();
                JArray riceArrary = (JArray)jObject[itemNameToUpdate];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();

                Console.Write("Enter new Item name : ");
                var newItemName = Convert.ToString(Console.ReadLine());

                foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(itemName)))
                {
                    item["name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : "";
                }

                jObject["name"] = riceArrary;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, output);


            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }


        public void DeleteFileItem()
        {
            var jsonFileRead = File.ReadAllText(jsonFile);
            try
            {
                var jsonObjectConvert = JObject.Parse(jsonFileRead);
                Console.WriteLine("Enter Item Name ");
                string itemNameToDelete = Console.ReadLine();
                JArray itemsArrary = (JArray)jsonObjectConvert[itemNameToDelete];
                Console.Write("Enter Name to Delete Item : ");
                var itemName = Console.ReadLine();


                var itemToDeleted = itemsArrary.FirstOrDefault(obj => obj["name"].Value<string>().Equals(itemName));

                itemsArrary.Remove(itemToDeleted);

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObjectConvert, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonFile, output);


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs");
            }
        }
    }
}
