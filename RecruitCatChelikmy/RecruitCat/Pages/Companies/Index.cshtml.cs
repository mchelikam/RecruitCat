using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCat.Data;
using RecruitCat.Models;

namespace RecruitCat.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCat.Data.RecruitCatContext _context;

        public IndexModel(RecruitCat.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
