using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RandyPowell.Models;
using Microsoft.AspNetCore.Authorization;

namespace RandyPowell.Pages.Skills
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;
        public string[] types;
        public CreateModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            types = GetTypes();
            return Page();
        }
        public string[] GetTypes()
        {
            string[] types = { "Front End", "Back End","Embedded Systems","Other Languages","Operating Systems","Development Tools","Other" };
            return types;
        }

        [BindProperty]
        public Skill Skill { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Skill.Add(Skill);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}