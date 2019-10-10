﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.InventoryManagement
{
    public class InventoryDataManagement
    {
        public IList<Rice> rice { get; set; }
        public IList<Wheats> wheats { get; set; }
        public IList<Pulses> pulses { get; set; }
    }
    public class Rice
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
    public class Wheats
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
    public class Pulses
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
}
