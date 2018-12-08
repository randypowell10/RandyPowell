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
    public class DeleteModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;

        public DeleteModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Experience = await _context.Experience.FindAsync(id);

            if (Experience != null)
            {
                _context.Experience.Remove(Experience);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
