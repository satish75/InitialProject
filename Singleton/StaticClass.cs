using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    static class StaticClass
    {
        static double pi = 3.14;
        public static double AreaOfCircle(double radius)
        {
            return pi * radius * radius;
        }
        public static double AreaOfRectangle(double length,double width)
        {
            return length*width;
        }
    }
}
