using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class CarName
    {
        public string carName { get; set; }
        public string modelNumber { get; set; }
        public void CarNameWithModel()
        {
            Console.WriteLine("Car Name : {0} , Model : {1}", carName, modelNumber);
        }
    }
    public class CarColor
    {
        public string color { get; set; }
        public void getColor()
        {
            Console.WriteLine("Color : " + color);
        }
    }
    public class CarEngine
    {
        public string carEngine { get; set; }
        public void getEngine()
        {
            Console.WriteLine("Engine : " + carEngine);
        }
    }
}
