using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace RandyPowell.Areas.Identity.Pages.Account
{
    [Authorize]
    public class AccessDeniedModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}

