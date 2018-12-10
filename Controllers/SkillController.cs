using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandyPowell.Models;
using Microsoft.EntityFrameworkCore;

namespace RandyPowell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly RandyPowellContext _context;
        public SkillController(RandyPowellContext context)
        {
            _context = context;
        }

        [HttpGet("{id}", Name = "GetExpSkills")]
        public ActionResult<List<string>> GetByExpId(int id)
        {
            List<int> list = new List<int>();
            List<string> skStr= new List<string>();
            var ski = _context.Experience.Include(i=>i.ExperienceSkills).FirstOrDefault(i=>i.ID==id).ExperienceSkills;
            if (ski == null)
            {
                return NotFound();
            }
            var allsk = _context.Skill.ToList();
            foreach(var skill in ski)
                        {
                            string thisstring = allsk.FirstOrDefault(i => i.ID == skill.SkillId).Title.ToString();
                            skStr.Add(thisstring);
                        }

            
            return skStr;
        }
        [HttpGet]
        public ActionResult<List<Skill>> GetAll() {
            return _context.Skill.ToList();
        }
    }
}