using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCat.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public bool RemoteOption { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
