

namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DecoratorUpdator
    {
        public static void DecoratorUpdatorOperation()
        {
            HP hP = new HP();
            Console.WriteLine("Enter Name Or Model Of HP Pc ");
            string name = Console.ReadLine();
            hP.name = name;
            Console.WriteLine("Enter Price Of Your Product ");
            double price = Convert.ToDouble(Console.ReadLine());
            hP.price = price;
            Console.WriteLine("Enter Manufaturing Year Of Your Product ");
            int year = Convert.ToInt32(Console.ReadLine());
            hP.manufacturingYear = year;
            hP.GetDetails();
            ConcreateDecoratorHp concreateDecorator = new ConcreateDecoratorHp(hP);
            concreateDecorator.GetDetails();
        }
    }
}
