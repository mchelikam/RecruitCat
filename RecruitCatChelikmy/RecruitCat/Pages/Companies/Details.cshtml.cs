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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCat.Data.RecruitCatContext _context;

        public DetailsModel(RecruitCat.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(x=>x.Candidates)
                .Include(c => c.Industry).FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
