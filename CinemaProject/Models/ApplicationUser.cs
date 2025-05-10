using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public ICollection<UserFavorite> Favorites { get; set; }
}
