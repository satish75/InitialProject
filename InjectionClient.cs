
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InjectionClient
    {
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
