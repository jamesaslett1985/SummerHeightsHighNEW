using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Website.Models
{

    public class CheatSheet
    {
        [Display(Name = "First name: (from Model)")]
        public string FirstName { get; set; }

        [Display(Name = "Last name: (from Model)")]
        public string LastName { get; set; } = "Aslett";

        [Display(Name = "Phone number:")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mail address:")]
        [EmailAddress]
        public string MailAddress { get; set; }

        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "DOB:")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Is active:")]
        public bool IsActive { get; set; }

        public string TextArea { get; set; }

        [MinLength(2)]
        [MaxLength(25)]
        public string TextAreaLength { get; set; }

    }
}

