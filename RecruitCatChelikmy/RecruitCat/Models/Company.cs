using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCat.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? OptionalStartDate { get; set; }
        public string Location { get; set; }
        public int? CurrentNumberOfEmployees { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public List<Candidate> Candidates { get; set; }
        public bool PositionStatusOpen { get; set; }
    }
}
