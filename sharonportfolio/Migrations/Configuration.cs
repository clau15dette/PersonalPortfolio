using sharonportfolio.Models;

namespace sharonportfolio.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<sharonportfolio.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(sharonportfolio.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }


            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                roleManager.Create(new IdentityRole { Name = "Moderator" });
            }

            var userManager = new UserManager<ApplicationUser>(
           new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "sharonclaudettesmith@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "sharonclaudettesmith@gmail.com",
                    Email = "sharonclaudettesmith@gmail.com",
                    FirstName = "Sharon",
                    LastName = "Smith",
                    DisplayName = "Sharon"
                }, "Cl15dette#");
            }

            if (!context.Users.Any(u => u.Email == "jtwichell@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "jtwichell@coderfoundry.com",
                    Email = "jtwichell@coderfoundry.com",
                    FirstName = "Jason",
                    LastName = "Twichell",
                    DisplayName = "J-Twich"
                }, "Abc&123!");
            }

            var userId = userManager.FindByEmail("sharonclaudettesmith@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");

            var juserId = userManager.FindByEmail("jtwichell@coderfoundry.com").Id;
            userManager.AddToRole(juserId, "Moderator");
        }
    }
}
