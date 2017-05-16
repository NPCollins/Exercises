using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlyByNightBank.Web.Models
{
    public class User
    {
        [Required(ErrorMessage = "Sorry, first name is required, don't be anonymous")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 100 characters")]
        public string LastName { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
    }
}