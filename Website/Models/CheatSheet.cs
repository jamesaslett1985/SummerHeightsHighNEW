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

        public string Gender { get; set; }

        public List<SelectListItem> Genders { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Male" },
            new SelectListItem { Value = "2", Text = "Female" },
        };

        public List<Country> Countries { get; set; }
        public string SelectedCountry { get; set; }

        public enum DayOfWeek
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }

        public string SelectedDay { get; set; }

        public List<Movie> Movies { get; set; }
    }

    public class Country 
    {
        public string Abbreviation { get; }

        public string Name { get; }

        public string NameAndAbbreviation => $"{Name} - {Abbreviation}";

        public Country(string abbreviation, string name)
        {
            Abbreviation = abbreviation;
            Name = name;
        } 
    }


    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

    }

    public class GetterAndSetterLearning
    {
        //field - fields tend to be private/protected (scoped to Class) - with fields you have no control over who can get and set the value
        public bool MyField;

        //property - has a getter/setter/both. Getter = whether property can be read, Setter = where property value can be changed. Properties allow you to have more control over getting/setting

        //can read and write
        public bool MyProperty1 { get; set; }

        //can only read

        public bool MyProperty2 { get; }

        private bool _myBackingField;

        //property where we have specified what the getters and setters do
        public bool MyProperty3 
        { 
            get 
            {
                return _myBackingField;
            }
            set
            {
                _myBackingField = value;
            }
        }
    }

}

