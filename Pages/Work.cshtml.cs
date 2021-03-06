﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RandyPowell.Models;
using Microsoft.EntityFrameworkCore;

namespace RandyPowell.Pages
{
    public class WorkModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;
        
        public WorkModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }
        public IList<Experience> Experience { get; set; }
        public IList<Skill> Skills { get; set; }
        public async Task OnGetAsync()
        {
            Experience = await _context.Experience
                .Where(s => s.Type == 0)
                .Include(i=>i.ExperienceSkills)
                //.orderby
                .ToListAsync();
            Skills = await _context.Skill
                .ToListAsync();
        }
    }
}