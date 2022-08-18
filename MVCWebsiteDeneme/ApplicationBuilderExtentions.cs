using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCWebsiteDeneme.Data;

namespace MVCWebsiteDeneme
{
    public static class ApplicationBuilderExtentions
    {
        public  static  IApplicationBuilder UseMVCWebsiteDeneme (this IApplicationBuilder builder)
        {
            var scope   = builder.ApplicationServices.CreateScope ();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext> ();
            var config = scope.ServiceProvider.GetRequiredService<IConfiguration>();

            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

            var user = new User

            {
                Name = config.GetValue<string>("DefaultUser:Name"),
                UserName = config.GetValue<string>("DefaultUser:UserName"),
                Email = config.GetValue<string>("DefaultUser:Email"),
                EmailConfirmed = true

            };
            userManager.CreateAsync(user, config.GetValue<string>("DefaultUser:Password")).Wait();

            context.Database.Migrate();

            return builder; 
        }
    }
}
   