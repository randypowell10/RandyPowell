using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RandyPowell.Models;

namespace RandyPowell.Pages.Skills
{
    public class DetailsModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;

        public DetailsModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }

        public Skill Skill { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Skill = await _context.Skill.FirstOrDefaultAsync(m => m.ID == id);

            if (Skill == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
