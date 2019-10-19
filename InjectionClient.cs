// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InjectionClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is injection class client
    /// </summary>
    public class InjectionClient
    {
        /// <summary>
        /// this is client method performing operation
        /// </summary>
        public static void InjectionOperation()
        {
            Permanent permanent = new Permanent();
            ConstructorInjection constructorInjection = new ConstructorInjection(permanent);
            Console.WriteLine("Constructor Injection : ");
            constructorInjection.employeeDetailsByConstructor();
            Console.WriteLine("\n**********Property Injection************** ");
            PropertyClient propertyClient = new PropertyClient();
            propertyClient.NewEmployee = permanent;
            propertyClient.PropertyInjection();
            Console.WriteLine("\n**********Method Injection************** ");
            MethodClient methodClient = new MethodClient();
            methodClient.MethodClientInjection(permanent);
        }
    }
}
