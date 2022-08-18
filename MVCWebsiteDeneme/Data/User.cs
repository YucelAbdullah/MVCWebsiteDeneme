using Microsoft.AspNetCore.Identity;

namespace MVCWebsiteDeneme.Data
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }

    }
}
