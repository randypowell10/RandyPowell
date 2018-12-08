using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RandyPowell.Models;
using Microsoft.AspNetCore.Authorization;

namespace RandyPowell.Pages.Experiences
{
    [Authorize]
    public class CreateModel : PageModel
    {
        public List<ExperienceSkill> ExperienceSkillList;

        public void PopulateAssignedCourseData(RandyPowellContext context,
                                               Experience experience)
        {
            var allSkills = context.Skill;
            var experienceSkills = new HashSet<int>(
                experience.ExperienceSkills.Select(c => c.SkillId));
            ExperienceSkillList = new List<ExperienceSkill>();
            foreach (var skill in allSkills)
            {
                ExperienceSkillList.Add(new ExperienceSkill
                {
                    SkillId = skill.ID,
                    Skill = skill,
                    Experience = experience,
                    ExperienceId = experience.ID
                });
            }
        }

        private readonly RandyPowell.Models.RandyPowellContext _context;
        public string[] types;

        public CreateModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            types = getTypes();
            var experience = new Experience();
            experience.ExperienceSkills = new List<ExperienceSkill>();
            PopulateAssignedCourseData(_context, experience);
            return Page();
        }
        public string[] getTypes() {
            string[] types = { "Work Experience", "Project" };
            return types;
        }

        [BindProperty]
        public Experience Experience { get; set; }

        public async Task<IActionResult> OnPostAsync(string[] selectedSkills)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var newExperience = new Experience();
            if (selectedSkills != null) {
                newExperience.ExperienceSkills = new List<ExperienceSkill>();
                foreach(var skill in selectedSkills)
                {
                    var skillToAdd = new ExperienceSkill
                    {
                        SkillId = int.Parse(skill)
                    };
                    newExperience.ExperienceSkills.Add(skillToAdd);
                }

            }
            if (await TryUpdateModelAsync<Experience>(
                newExperience,
                "Experience"))
            {
                _context.Experience.Add(newExperience);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            PopulateAssignedCourseData(_context, newExperience);

            //_context.Experience.Add(Experience);
            //await _context.SaveChangesAsync();

            return Page();
        }
    }
}