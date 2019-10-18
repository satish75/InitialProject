using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Injection
    {
    }
    public interface Employee
    {
        public void employeeDetails();
    }
    /// <summary>
    /// This is Constructore Dependancy
    /// </summary>
    public class Permanent : Employee
    {
        public void employeeDetails()
        {
            Console.WriteLine("Enter Employee Name ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Position ");
            string employeePosition = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary ");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name : {0}\tPosition : {1}\tSalary : {2}", employeeName, employeePosition, employeeSalary);

        }      
    }
    public class ConstructorInjection
    {
        Permanent permanent;
        public ConstructorInjection(Permanent permanent)
        {
            this.permanent = permanent;
        }
        public void employeeDetailsByConstructor()
        {
            this.permanent.employeeDetails();
        }

    }
    
    /// <summary>
    /// Property Injection
    /// </summary>
    public class PropertyClient
    {
        Employee newEmpObject { get; set; }
       public Employee NewEmployee
        {
            get
            {
                return newEmpObject;
            }
            set
            {
                newEmpObject = value;
            }
        }
         public void PropertyInjection()
        {
            newEmpObject.employeeDetails();
        }
        
    }
    /// <summary>
    /// Method Injection
    /// </summary>
    public class MethodClient
    {
       
        public void MethodClientInjection(Employee newEmpObject)
        {
            newEmpObject.employeeDetails();
        }
    }
}
