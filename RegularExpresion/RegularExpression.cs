// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------------------------
namespace ObjectOriented.RegularExpresion
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This is regular expression class.
    /// </summary>
    public class RegularExpression
    {
        /// <summary>
        /// this method check the user enter pattern is match or not.
        /// </summary>
        public static void RegularExpressionChecker()
        {
            ////this regex use to pattern match of name
            Regex regex = new Regex("[a - zA - Z][a-zA-Z]");

            ////this regex use to pattern match of mobile
            Regex regexForMobile = new Regex(("(0/91)?[7-9][0-9]{9}"));
            string userString = " Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you";
            Console.WriteLine(userString);
            Console.WriteLine();

            ////user enter full name here
            Console.WriteLine("User enter your full name");
            string userName = Console.ReadLine();
            bool result = true;

            ////it check name of user is match or not
            result = regex.IsMatch(userName);
            do
            {
            lable:
                if (result == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("User enter your full name");
                    userName = Console.ReadLine();
                    result = regex.IsMatch(userName);
                    goto lable;
                }
            } 
            while (result == true);

            char[] charArray = userName.ToCharArray();
            string firstName = string.Empty;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != ' ')
                {
                    firstName += charArray[i];
                }
                else
                {
                    break;
                }
            }
    
            ////this is formate of string
            string nameInstring = "<<name>>";
            string fullName = "<<full name>>";
            string userMobleNumber = "91-xxxxxxxxxx.";

            ////user enter mobile number here
            Console.WriteLine("Enter mobile number of user");
            string userNumber = Console.ReadLine();

            ////it hold boolean value for is valide user
            bool isValide = true;

            ////here check entered mobile is valide or not
            isValide = regexForMobile.IsMatch(userNumber);
            do
            {
            lable1:
                if (isValide == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("User enter your mobile number");
                    userNumber = Console.ReadLine();
                    result = regexForMobile.IsMatch(userNumber);
                    goto lable1;
                }
            } 
            while (isValide == true);
            regex = new Regex(nameInstring);
            string updatedUserResult = regex.Replace(userString, firstName);

            ////check full name is match or not.
            regex = new Regex(fullName);
            string newUpadatedResult = regex.Replace(updatedUserResult, userName);

            ////this regular check the mobile no is valide or not.
            regex = new Regex(userMobleNumber);
            string finalResult = regex.Replace(newUpadatedResult, userNumber);
            Console.WriteLine();

            ////dispaly final results
            Console.WriteLine(finalResult);
        }
    }
}