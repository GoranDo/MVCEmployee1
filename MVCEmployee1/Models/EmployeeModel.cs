using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEmployee1.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "please add 5 digit ID")]
        [Range(10000, 99999, ErrorMessage = "you need to enter a valid employeid")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "e-mail")]
        [Required(ErrorMessage = "please add your e-mail adress")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm e-mail")]
        [Compare("EmailAddress", ErrorMessage = "give email")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "ReEnter Password")]
        [Required(ErrorMessage = "retype password")]
        [Compare("Password", ErrorMessage = "Ponovi unos password-a")]
        public string ConfirmPassword { get; set; }

    }
}