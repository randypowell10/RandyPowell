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
    public class ExperienceController : ControllerBase
    {
        private readonly RandyPowellContext _context;
        public ExperienceController(RandyPowellContext context) {
            _context = context;
        }

        [HttpGet("{id}", Name = "GetExp")]
        public ActionResult<Experience> GetById(int id) {
            var item = _context.Experience
                .Include(i => i.ExperienceSkills).FirstOrDefault(m => m.ID == id);

            if (item == null) {
                return NotFound();
            }
            return item;
        }

        [HttpGet]
        public ActionResult<List<Experience>> GetAll()
        {
            return _context.Experience.ToList();
        }

    }
}