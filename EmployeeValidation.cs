using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPattern
{
    public class EmployeeValidation
    {
       [Range (20,40,ErrorMessage ="Age Should Be Between 20 and 40")]
        public int age { get; set; }
        string employeeName { get; set; }
    
        [Required(ErrorMessage ="Name Must Be Required")]
        [StringLength(10)]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,10}$")]
        public string EmployeeName
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

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public void GetDetails()
        {
            Console.WriteLine("Name Of Emp " + employeeName);
        }
    }
}
