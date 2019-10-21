// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    /// <summary>
    /// This is Main Class 
    /// </summary>
   public class Program
    {
        /// <summary>
        /// This is main method it is entry point of application
        /// </summary>
        /// <param name="args">it take string type argument</param>
        public static void Main(string[] args)
        {
            //// This do While loop use to take user choice to execute particular operation
            try
            {
                char again;
                do
                {
                    //// This Print List Of Operation on Console 
                    Console.WriteLine("**********************************");
                    Console.WriteLine("1. SingleTon \n" + "2. Factory Pattern\n" + "3. Decorator Pattern\n"
                        + "4. Injection\n" + "5. Facade\n" + "6. Data Annotation\n" + "7. Prototype\n"
                        + "8. Reflection\n" + "9. Proxy Pattern\n" + "10. Adapter \n");
                    Console.WriteLine("*********************************** ");
                    Console.WriteLine("Enter Your Choice To Run Operation ");

                    ////Take Choice from User
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ////UtilitySingleton class called static method
                            UtilitySingleton.SingletonType();
                            break;
                        case 2:
                            FactoryClient.ClientRequirement();
                            break;
                        case 3:
                            DecoratorUpdator.DecoratorUpdatorOperation();
                            break;
                        case 4:
                            InjectionClient.InjectionOperation();
                            break;
                        case 5:
                            FacadeCar.CompleteCarMade();
                            break;
                        case 6:
                            Validation.DataAnnotation();
                            break;
                        case 7:
                            Cloning.CloningOperation();
                            break;
                        case 8:
                            Reflection.ReflectionOperation();
                            break;
                        case 9:
                            AtmUserProxy.AtmWithdrawal();
                            break;
                        case 10:
                            VenderAdapter venderAdapter = new VenderAdapter();
                            List<string> product = venderAdapter.getProducts();
                            Console.WriteLine("Adapter Class Object Called Here : ");
                            foreach (string item in product)
                                Console.Write("    " + item);
                            break;
                        case 11:
                            EmployeeDetails emp = new EmployeeDetails();
                            emp.CurrentEmp();
                            EmployeeDetails emp2 = new EmployeeDetails();
                            emp2.employeeName = "sat";
                          
                            emp.LeftEmployee(emp2);
                            break;
                        default:
                            Console.WriteLine("Please Enter Valide Number");
                            break;
                    }

                    //// here Ask for Continue to perform operation
                    Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                    again = Console.ReadLine()[0];
                }
                while (again == 'Y' || again == 'y');
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please Enter Valide Input "+e);
            }
           
           
        }
    }
}
