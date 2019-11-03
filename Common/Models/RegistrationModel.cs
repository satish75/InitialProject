using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models
{
   public class RegistrationModel
    {
      //  [Key]
       // public int Id { get; set; }
        [Required]
      //  [RegularExpression("^[a-zA-Z ]*$")]
        public string FirstName { get; set; }
        [Required]
     //   [RegularExpression("^[a-zA-Z ]*$")]
        public string LastName { get; set; }
     //   [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }
        [Required]
       // [DataType(DataType.EmailAddress)]
       // [EmailAddress]
      //  [RegularExpression("^[a-zA-Z0-9]{5,20}(@gmail.com|@yahoo.com)$")]
        public string Email { get; set; }
        [Required]
      //  [StringLength(20, MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
      //  [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
