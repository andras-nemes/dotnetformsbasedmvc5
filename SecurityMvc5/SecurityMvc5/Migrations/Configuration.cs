namespace SecurityMvc5.Migrations
{
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using SecurityMvc5.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecurityMvc5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SecurityMvc5.Models.ApplicationDbContext";
        }

        protected override void Seed(SecurityMvc5.Models.ApplicationDbContext context)
        {
		
			if (!context.Users.Any(user => user.UserName == "andras"))
			{
				UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
				UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);
				ApplicationUser applicationUser = new ApplicationUser() { UserName = "andras" };
				userManager.Create<ApplicationUser>(applicationUser, "password");

				string roleName = "IT";
				RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
				RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);
				roleManager.Create(new IdentityRole() { Name = roleName });
				userManager.AddToRole(applicationUser.Id, roleName);
			}
        }
    }
}
