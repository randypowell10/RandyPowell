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

namespace RandyPowell.Pages.Experiences
{
    [Authorize]
    public class EditModel : PageModel
    {
        public List<ExperienceSkill> ExperienceSkillList;
        public List<int> checkedItems;

        public void PopulateAssignedCourseData(RandyPowellContext context,
                                               Experience experience)
        {
            var allSkills = context.Skill;
            var experienceSkills = new HashSet<int>(
                experience.ExperienceSkills.Select(c => c.SkillId));
            ExperienceSkillList = new List<ExperienceSkill>();
            checkedItems = new List<int>();
            foreach (var skill in allSkills)
            {
                ExperienceSkillList.Add(new ExperienceSkill
                {
                    SkillId = skill.ID,
                    Skill = skill,
                    Experience = experience,
                    ExperienceId = experience.ID
                });
                if (experienceSkills.Contains(skill.ID)) {
                    checkedItems.Add(skill.ID);
                }
            }
           
        }
        public void UpdateInstructorCourses(RandyPowellContext context,
            string[] selectedSkills, Experience experienceToUpdate)
        {
            if (selectedSkills == null)
            {
                experienceToUpdate.ExperienceSkills = new List<ExperienceSkill>();
                return;
            }

            var selectedSkillsHS = new HashSet<string>(selectedSkills);
            var experienceSkills = new HashSet<int>
                (experienceToUpdate.ExperienceSkills.Select(c => c.SkillId));
            foreach (var skill in context.Skill)
            {
                if (selectedSkillsHS.Contains(skill.ID.ToString()))
                {
                    if (!experienceSkills.Contains(skill.ID))
                    {
                        experienceToUpdate.ExperienceSkills.Add(
                            new ExperienceSkill
                            {
                                ExperienceId = experienceToUpdate.ID,
                                SkillId = skill.ID,
                                Skill = skill,
                                Experience = experienceToUpdate
                            });
                    }
                }
                else
                {
                    if (experienceSkills.Contains(skill.ID))
                    {
                        ExperienceSkill skillToRemove
                            = experienceToUpdate
                                .ExperienceSkills
                                .SingleOrDefault(i => i.SkillId == skill.ID);
                        context.Remove(skillToRemove);
                    }
                }
            }
        }
        private readonly RandyPowell.Models.RandyPowellContext _context;
        public string[] types;
        public EditModel(RandyPowell.Models.RandyPowellContext context)
        {
            types = getTypes();
            _context = context;
        }
        public string[] getTypes()
        {
            string[] types = { "Work Experience", "Project" };
            return types;
        }
        [BindProperty]
        public Experience Experience { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Experience = await _context.Experience
                .Include(i=>i.ExperienceSkills)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Experience == null)
            {
                return NotFound();
            }
            PopulateAssignedCourseData(_context, Experience);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id, string[] selectedSkills)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var experienceToUpdate = await _context.Experience
            .Include(i => i.ExperienceSkills)
            .FirstOrDefaultAsync(s => s.ID == id);

            if (await TryUpdateModelAsync<Experience>(
                experienceToUpdate,
                "Experience", 
                i => i.Title, i=>i.Organization,
                i => i.Location, i=>i.Dates,
                i => i.Type,i=>i._desc
                ))
            {
                
                UpdateInstructorCourses(_context, selectedSkills, experienceToUpdate);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            UpdateInstructorCourses(_context, selectedSkills, experienceToUpdate);
            PopulateAssignedCourseData(_context, experienceToUpdate);
            return Page();

        }

        private bool ExperienceExists(int id)
        {
            return _context.Experience.Any(e => e.ID == id);
        }
    }
}
