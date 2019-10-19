using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class FactoryClient
    {
        public static void ClientRequirement()
        {
            PC pC = new PC();
            pC.getConfiguration("4Gb", "1Tb", "I3");
            Laptop laptop = new Laptop();
            laptop.getConfiguration("8Gb", "1Tb", "I5");
            Server server = new Server();
            server.getConfiguration("Pentiaum", "120Gb", "Dual");

            ConcreateFactory concreateFactory = new ConcreateFactory();
            Console.WriteLine("Available Product : PC\tLaptop\tServer ");
            Console.WriteLine("Which Product You Want ");
            string productName = Console.ReadLine();
            IComputer computer = concreateFactory.getUserDecidedConfiguration(productName);
            computer.getConfiguration("1Tb", "I3", "4gb"); ;
        }
    }
}
