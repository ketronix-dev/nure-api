using Microsoft.AspNetCore.Identity;

namespace nure_api.Models;

public class AuthUser: IdentityUser
{
    public List<string>? Groups { get; set; }
}