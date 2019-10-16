using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   public class Prototype
    {
    }
    public interface IEmployee
    {
        IEmployee Clone();
        void getDetails();
    }
    public class Developer : IEmployee
    {
       public int employeeId { set; get; }
        public string employeeName { set; get; }
        public int employeeSalary { get; set; }
        public  IEmployee Clone()
        {
            ////This Is Shallow Copy of Developer
             return (IEmployee)MemberwiseClone();
          ////  Developer developer = (Developer)this.MemberwiseClone();
          ////  developer.employeeName = (IEmployee)this.employeeName.Clone();
          ////  return developer;
        }
        public void getDetails()
        {
            Console.WriteLine("Developer :\nId : {0}, Name : {1}, Salary :{2}", employeeId, employeeName, employeeSalary);
        }
    }

    public class Tester : IEmployee
    {
        public int employeeId { set; get; }
        public string employeeName { set; get; }
        public int employeeSalary { get; set; }
        public IEmployee Clone()
        {
             return (IEmployee)MemberwiseClone();
            ///

          ////  return (IEmployee)this.Clone();
        }
        public void getDetails()
        {
            Console.WriteLine("Tester : \nId : {0} Name {1} :{1} Salary :{2}", employeeId, employeeName, employeeSalary);
        }
    }
}
