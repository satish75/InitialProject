// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObserverDesign.cs" company="Bridgelabz">
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
    /// this is observe design class
    /// </summary>
    public class ObserverDesign
    {
    }

    public interface CompanyDetails
    {
        public double monthlyPf { get; set; }

        //// public string employeePosition { get; set; }
        ////  public string workingHours { get; set; }
        public abstract void CurrentEmp();
     //   public void LeftEmployee(Company employee);
       // public void Notify(); 
    }
    public class EmployeeDetails : CompanyDetails
    {
       public List<EmployeeDetails> listOfEmployee = new List<EmployeeDetails>();
        public string employeeName { get; set; }
        public double monthlyPf
        {
            get
            {
                return 200;
            }
            set
            {
                monthlyPf = value;
            }
        }
        public string GetName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public void CurrentEmp()
        {
            Console.WriteLine("EMP..........");
          for(int i=0;i<5;i++)
            {
                listOfEmployee.Add(new EmployeeDetails());
                Console.WriteLine("Enter Emp Name ");
                string name = Console.ReadLine();
                listOfEmployee[i].employeeName=name;
            }
            foreach(EmployeeDetails item in listOfEmployee )
            {
                Console.WriteLine("Emp " + item.employeeName);
            }
        }

     
        public void LeftEmployee(EmployeeDetails employee2)
        {
            foreach (EmployeeDetails item in listOfEmployee)
            {
                if(item.employeeName==employee2.employeeName)
                {
                    listOfEmployee.Remove(employee2);
                    Console.WriteLine("Deleted " + employee2.employeeName);
                }
            }
            foreach (EmployeeDetails item2 in listOfEmployee)
            {
                Console.WriteLine("Emp " + item2.employeeName);
            }

        }

        public void Notify()
        {

        }
    }
    
}
