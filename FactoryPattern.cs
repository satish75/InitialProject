

namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public abstract  class FactoryPattern
    {
       public abstract IComputer getUserDecidedConfiguration(string product);
       
    }

    public class ConcreateFactory : FactoryPattern
    {
        public override IComputer getUserDecidedConfiguration(string newProduct)
        {
          switch (newProduct)
            {
                case "PC":
                    return new PC();
                    break;
                case "Laptop":
                    return new Laptop();
                    break;
                case "Server":
                    return new Server();
                    break;
                default:
                    throw new Exception("Your Product Not Made in this Factory");
            }
        }
    }
    public interface IComputer
    {
        abstract void getConfiguration(string ram,string harddisk,string processor);
    }
    public class PC : IComputer
    {
       public string ram;
        public string hardDisk;
        public string processor;

        public void getConfiguration(string ram, string hardDisk, string processor)
        {
            this.ram = ram;
            this.hardDisk = hardDisk;
            this.processor = processor;
            Console.WriteLine("PC Congiguration \nRam {0} ,HardDisk {1}, Processor {2}", ram, hardDisk, processor);     
        }

    }
    public class Laptop : IComputer
    {
        public string ram;
        public string hardDisk;
        public string processor;

        public void getConfiguration(string ram, string hardDisk, string processor)
        {
            this.ram = ram;
            this.hardDisk = hardDisk;
            this.processor = processor;
            Console.WriteLine("Laptop Congiguration \nRam : {0} ,HardDisk : {1}, Processor : {2}", ram, hardDisk, processor);

        }

    }
    public class Server : IComputer
    {
        public string processor;
        public string memory;
        public string nic;

        public void getConfiguration(string processor, string memory, string nic)
        {
            this.processor = processor;
            this.memory = memory;
            this.nic = nic;
            Console.WriteLine("Server Congiguration \nProcessor : {0} , Memory : {1}, Nic : {2}", processor, memory, nic);

        }

    }
}
