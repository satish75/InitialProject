using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Decorator
    {
    }
    public abstract class ILaptop
    {
        public string name { get; set; }
        public double price { get; set; }
        public int manufacturingYear { get; set; }
       public abstract void GetDetails();
    }
    public class HP : ILaptop
    {
      
       
        public override void GetDetails()
        {
            Console.WriteLine("Name : {0}\tPrice : {1}\tManufacture Year : {2}",name,price,manufacturingYear);
         
        }
    }
    public abstract class DecoratorLaptop : ILaptop
    {
        ILaptop laptop;

        public DecoratorLaptop(ILaptop lapi)
        {
            laptop = lapi;
        }

        public override void GetDetails()
        {

            laptop.GetDetails();
        }
    }
    public class ConcreateDecoratorHp : DecoratorLaptop
    {
       private double PriceIncrease { get; }
        public double PriceIncreaseVariable
        {
            get
            {
                return 3300;
            }
        }
        public ConcreateDecoratorHp(ILaptop valueObject):base(valueObject)
        {
            valueObject.price = valueObject.price + PriceIncreaseVariable;
        }
        
        public override void GetDetails()
        {    
            base.GetDetails();
        }
    }
}
