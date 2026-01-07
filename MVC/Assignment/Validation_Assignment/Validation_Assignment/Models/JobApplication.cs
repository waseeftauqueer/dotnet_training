using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Validation_Assignment.Custom_Validations;

namespace Validation_Assignment.Models
{
    public class JobApplication
    {
        [Required(ErrorMessage = "Applicant name is required")]
        [DisplayName("Applicant's Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [ValidPassword(ErrorMessage = "First character to be in uppercase followed by a number, followed by any 6 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Date of joining is required")]
        [DataType(DataType.Date)]
        [ValidDateOfJoin(ErrorMessage = "Date can't be in the past")]
        public DateTime DOJ { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [ValidAge(ErrorMessage = "age to be >21 and <25 from the current date")]
        public DateTime BirthDate { get; set; }
    }
}
