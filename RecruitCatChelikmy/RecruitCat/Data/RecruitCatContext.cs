using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCat.Models;

namespace RecruitCat.Data
{
    public class RecruitCatContext : DbContext
    {
        public RecruitCatContext (DbContextOptions<RecruitCatContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCat.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCat.Models.Company> Company { get; set; }

        public DbSet<RecruitCat.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCat.Models.Industry> Industry { get; set; }
    }
}
