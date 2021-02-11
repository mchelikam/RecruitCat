using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace RecruitCat.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(27, MinimumLength = 2, ErrorMessage = "Title should be minimum of 2 characters")]
        public string Title { get; set; }

        [Display(Name = "Min Salary")]
        [Range(0, double.MaxValue)]
        public decimal MinSalary { get; set; }

        [Display(Name = "Max Salary")]
        [Range(0, double.MaxValue)]
        public decimal MaxSalary { get; set; }

        [Display(Name = "Remote Option")]
        public bool RemoteOption { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
