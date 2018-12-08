using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RandyPowell.Models;
using Microsoft.AspNetCore.Authorization;

namespace RandyPowell.Pages.Skills
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;
        public string[] types;

        public EditModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }
        
        [BindProperty]
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
            types = GetTypes();
            return Page();
        }
public string[] GetTypes()
        {
            string[] types = { "Front End", "Back End", "Embedded Systems", "Other Languages", "Operating Systems", "Development Tools","Other" };
            return types;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Skill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillExists(Skill.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SkillExists(int id)
        {
            return _context.Skill.Any(e => e.ID == id);
        }
    }
}
