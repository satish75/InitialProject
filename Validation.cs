

namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    public class Validation
    {
        public static void DataAnnotation()
        {
            EmployeeValidationNotation employeeValidationNotation = new EmployeeValidationNotation();
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            employeeValidationNotation.age = age;
            employeeValidationNotation.employeeName = name;
            ValidationContext context = new ValidationContext(employeeValidationNotation, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employeeValidationNotation, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult vr in results)
                {
                    Console.Write("Member Name :{0}", vr.MemberNames.First());
                    Console.Write("   ::  {0}{1}", vr.ErrorMessage, Environment.NewLine);
                }
            }

            employeeValidationNotation.GetDetails();
        }
    }
}
