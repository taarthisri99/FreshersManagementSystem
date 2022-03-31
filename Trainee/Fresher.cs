using System;
using System.ComponentModel.DataAnnotations;

namespace Trainee
{
    public class Fresher
    {
        public Fresher() { }
        public Fresher(int id, string name, long mobileNumber, DateTime dateOfBirth
            , string qualification, string address)
        {
            Id = id;
            Name = name;
            MobileNumber = mobileNumber;
            DateOfBirth = dateOfBirth;
            Qualification = qualification;
            Address = address;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "*Name is required")]
        [Display(Name = "Name")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "*Mobile number is required")]
        [Display(Name = "Mobile Number")]
        [Phone]
        public long MobileNumber { get; set; }

        [Required(ErrorMessage = "*Date of birth is required")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "*Qualification is required")]
        [Display(Name = "Qualification")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "*Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}