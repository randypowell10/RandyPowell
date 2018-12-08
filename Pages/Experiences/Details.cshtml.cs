using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RandyPowell.Models;
using Microsoft.AspNetCore.Authorization;

namespace RandyPowell.Pages.Experiences
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;

        public DetailsModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }

        public Experience Experience { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Experience = await _context.Experience.FirstOrDefaultAsync(m => m.ID == id);

            if (Experience == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
