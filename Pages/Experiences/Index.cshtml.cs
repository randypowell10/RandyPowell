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
    public class IndexModel : PageModel
    {
        private readonly RandyPowell.Models.RandyPowellContext _context;

        public IndexModel(RandyPowell.Models.RandyPowellContext context)
        {
            _context = context;
        }

        public IList<Experience> Experience { get;set; }

        public async Task OnGetAsync()
        {
            Experience = await _context.Experience.ToListAsync();
        }
    }
}
