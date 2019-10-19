// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is abstract class factory
    /// </summary>
   public abstract class FactoryPattern
    {
        /// <summary>
        /// this is abstract method only declaration done.
        /// </summary>
        /// <param name="product">take a product name</param>
        /// <returns>it return object of Computer</returns>
       public abstract IComputer getUserDecidedConfiguration(string product);    
    }

    /// <summary>
    /// it is con create factory inheritance from factory
    /// </summary>
    public class ConcreateFactory : FactoryPattern
    {
        /// <summary>
        /// override the get configuration method
        /// </summary>
        /// <param name="newProduct">takes the product name</param>
        /// <returns>return the object of computer</returns>
        public override IComputer getUserDecidedConfiguration(string newProduct)
        {
            //// this switch case use to decide which object should created at runtime
          switch (newProduct)
            {
                case "PC":
                    ////return PC object
                    return new PC();
                    break;
                case "Laptop":
                    ////return Laptop object
                    return new Laptop();
                    break;
                case "Server":
                    ////return Server object
                    return new Server();
                    break;
                default:
                    return null;                             
            }
        }
    }

    /// <summary>
    /// this is interface computer which as get configuration abstract method
    /// </summary>
    public interface IComputer
    {
        /// <summary>
        /// this is abstract method declaration
        /// </summary>
        /// <param name="ram">take RAM</param>
        /// <param name="harddisk">take HardDisk</param>
        /// <param name="processor">take Processor</param>
        abstract void getConfiguration();
    }

    /// <summary>
    /// this class implemented from Computer class
    /// </summary>
    public class PC : IComputer
    {
        /// <summary>
        /// it hold Ram Of computer
        /// </summary>
        public string ram = "4gb";


        /// <summary>
        /// it hold hardDisk Of computer
        /// </summary>
        public string hardDisk = "1Tb";

        /// <summary>
        /// it hold processor Of computer
        /// </summary>
        public string processor = "I3";

        /// <summary>
        /// this is abstract method declaration
        /// </summary>
        /// <param name="ram">take ram</param>
        /// <param name="harddisk">take hardDisk</param>
        /// <param name="processor">take processor</param>
        public void getConfiguration()
        {        
            //// print all configuration of PC
            Console.WriteLine("PC Congiguration \nRam : {0}\tHardDisk : {1}\tProcessor : {2}", ram, hardDisk, processor);     
        }
    }

    /// <summary>
    /// this is Laptop class
    /// </summary>
    public class Laptop : IComputer
    {
        public string ram = "8Gb";
        public string hardDisk = "1Tb";
        public string processor = "I5";

        /// <summary>
        /// this is abstract method declaration
        /// </summary>
        /// <param name="ram">take RAM</param>
        /// <param name="harddisk">take HardDisk</param>
        /// <param name="processor">take Processor</param>
        public void getConfiguration()
        {
           
            //// print all configuration of Laptop
            Console.WriteLine("Laptop Congiguration \nRam : {0}\tHardDisk : {1}\tProcessor : {2}", ram, hardDisk, processor);
        }
    }

    /// <summary>
    /// this is server class it has properties like Processor , Memory and NIC.
    /// </summary>
    public class Server : IComputer
    {
        /// <summary>
        /// it hold processor value of Server
        /// </summary>
        public string processor = "Intel@ Xeon";

        /// <summary>
        /// it hold memory of processor
        /// </summary>
        public string memory = "120Tb";

        /// <summary>
        /// It hold NIC card of Server
        /// </summary>
        public string nic = "Dual";

        /// <summary>
        /// this method get the configuration of server
        /// </summary>
        /// <param name="processor">take processor value</param>
        /// <param name="memory">take memory</param>
        /// <param name="nic">take NIC</param>
        public void getConfiguration()
        {
            //// print server  configuration
            Console.WriteLine("Server Congiguration \nProcessor : {0}\tMemory : {1}\tNic : {2}", processor, memory, nic);
        }
    }
}