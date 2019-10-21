using UNDonationApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNDonationApp.Startup))]
namespace UNDonationApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            /// Create System Roles on startup
            createRolesandUsers();

        }


        // Method called to create roles on startup 

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // In Startup create first Admin Role and creating a default Admin User     
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin role    
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //// Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.UserName = "SystemAdmin";
                user.Email = "admin@gmail.com";
                string userPWD = "Twennywan@21";

                var chkUser = UserManager.Create(user, userPWD);

                //// Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            //// creating Creating Donar role     
            if (!roleManager.RoleExists("Donor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Donor";
                roleManager.Create(role);

            }

        }


    }
}
