using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RecruitCat.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(27, MinimumLength = 2, ErrorMessage = "Name should be minimum of 2 characters")]
        public string Name { get; set; }

        [Display(Name = "Position Name")]
        [Required(ErrorMessage = "Position Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Position Name should be minimum of 3 characters")]
        public string PositionName { get; set; }

        [Display(Name = "Min Salary")]
        [Range(0, double.MaxValue)]
        public decimal MinSalary { get; set; }

        [Display(Name = "Max Salary")]
        [Range(0, double.MaxValue)]
        public decimal MaxSalary { get; set; }

        [Display(Name = "Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime? OptionalStartDate { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Location should be minimum of 3 characters")]
        public string Location { get; set; }

        [Display(Name = "Current Number of Employees")]
        [Range(0, int.MaxValue)]
        public int? CurrentNumberOfEmployees { get; set; }

        public Industry Industry { get; set; }

        [Display(Name = "Industry Id")]
        public int IndustryId { get; set; }


        public List<Candidate> Candidates { get; set; }

        [Display(Name = "Position Status Open")]
        public bool PositionStatusOpen { get; set; }
    }
}
