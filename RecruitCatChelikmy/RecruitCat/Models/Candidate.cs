using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RecruitCat.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage="First Name is required.")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="First Name should be minimum of 3 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name should be minimum of 3 characters")]
        public string LastName { get; set; }

        [Display(Name = "Target Salary")]
        [Range(0,double.MaxValue)]
        public decimal TargetSalary { get; set; }

        [Display(Name = "Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime? OptionalStartDate { get; set; }

        [Display(Name = "Work Authorization")]
        public bool WorkAuthorization { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Industry Industry { get; set; }

        [Display(Name = "Industry Id")]
        public int IndustryId { get; set; }

        public Company Company { get; set; }

        [Display(Name = "Company Id")]
        public int CompanyId { get; set; }

        [Display(Name = "Job Title")]
        public JobTitle JobTitle { get; set; }

        [Display(Name = "Job Title Id")]
        public int JobTitleId { get; set; }
    }
}
