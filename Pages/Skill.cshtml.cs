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
    public class SkillsModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;

        public SkillsModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }
        public IList<Experience> Experience { get; set; }
        public IList<Skill> Skills { get; set; }
        public async Task OnGetAsync()
        {
            Experience = await _context.Experience
                .ToListAsync();
            Skills = await _context.Skill
                .Include(i => i.ExperienceSkills)
                .ToListAsync();
        }
    }
}