﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RandyPowell.Models;
using Microsoft.AspNetCore.Authorization;

namespace RandyPowell.Pages.Skills
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Skill = await _context.Skill.FindAsync(id);

            if (Skill != null)
            {
                _context.Skill.Remove(Skill);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
