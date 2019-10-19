
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    public class Reflection
    {
        public static void ReflectionOperation()
        {
            ReflectionCompany reflectionCompany = new ReflectionCompany();
            Type typeOfCompany = typeof(ReflectionCompany);
            Console.WriteLine("Type : " + typeOfCompany.Name);
            Console.WriteLine("NameSpace : " + typeOfCompany.Namespace);

            PropertyInfo[] propertyInfo = typeOfCompany.GetProperties();

            Console.WriteLine("The list of properties of the class are : ");

            foreach (PropertyInfo pInfo in propertyInfo)
            {
                Console.WriteLine(pInfo.Name);
            }
            MethodInfo[] methodInfo = typeOfCompany.GetMethods();
            Console.WriteLine("Method List : ");
            foreach (MethodInfo pInfo in methodInfo)
            {
                Console.WriteLine(pInfo.Name);
            }
        }
    }
}
