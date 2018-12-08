using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandyPowell.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using RandyPowell.Areas.Identity;
using Microsoft.Extensions.DependencyInjection;
namespace RandyPowell.Models
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
            using (var context = new RandyPowellContext(
                serviceProvider.GetRequiredService<DbContextOptions<RandyPowellContext>>()))
            {
                var adminID = await EnsureUser(serviceProvider, "dummyPW", "randypowell10@yahoo.com");
            }
        }
        private static async Task<string> EnsureUser(IServiceProvider serviceProvider,
                                            string testUserPw, string UserName)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(UserName);
            if (user == null)
            {
                user = new IdentityUser { UserName = UserName };
                await userManager.CreateAsync(user, testUserPw);
            }

            return user.Id;
        }
    }
}
