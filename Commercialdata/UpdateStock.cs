using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ObjectOriented.Commercialdata
{
    public class UpdateStock
    {
        private void UpdateCompany()
        {
            string json = File.ReadAllText("C:\\Users\\bridgeit\\Desktop\\Satya\\userDetail.json");

                var jObject = JObject.Parse(json);
                //  JArray experiencesArrary = (JArray)jObject["experiences"];
                Console.Write("Enter Company name to Update Company : ");
                var name = Console.ReadLine();
                Console.Write("Enter new share  : ");
                int share = Convert.ToInt32(Console.ReadLine());

                /*     foreach (var company in experiencesArrary.Where(.Value<string>() == name))
                     {
                         company["companyname"] = !string.IsNullOrEmpty(companyName) ? companyName : "";
                     }

                     jObject["experiences"] = experiencesArrary;
                     string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                     File.WriteAllText(json, output);

             }
             catch (Exception ex)
             {

                 Console.WriteLine("Update Error : " + ex.Message.ToString());
             }
             */
            
    }
    } }
