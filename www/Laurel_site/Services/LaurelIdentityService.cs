namespace Laurel_site.Services;

public class LaurelIdentityService
{
    public static string[] Roles = new[] { "admin", "ve", "rc","chairman", "teamleader", "deputy", "user" };
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly UserManager<AmateurUser> userManager;
    public LaurelIdentityService(RoleManager<IdentityRole> rm, UserManager<AmateurUser> um)
    {
        roleManager = rm;
        userManager = um;
    }
    public async Task AddAdminRolesIfNeededAsync()
    {
        foreach (var role in Roles)
        {
            var roleExist = await CheckRoleExists(role);
            if (roleExist == false)
            {
                var newRole = new IdentityRole(role);
                var results = await roleManager.CreateAsync(newRole);
                if (results.Succeeded == false) 
                {
                    Debug.WriteLine("Failed to create role");
                }
            }
        }

        //var role = new IdentityRole(roleName);
        //var results = await roleManager.CreateAsync(role);
        //await AddRoleToUser("admin", "darryl@wagoner.me");

    }
    public async Task<bool> CheckRoleExists(string roleName)
    {
        var roleExists = await roleManager.RoleExistsAsync(roleName);

        if (roleExists)
            return true;
        else
            return false;
    }
    public async Task<bool> AddRoleToUser(string role, string userId)
    {
        var user = await userManager.FindByEmailAsync(userId);
        if (user == null)
            return false;

        if (!await roleManager.RoleExistsAsync(role))
            return false;

        var rc = await userManager.IsInRoleAsync(user, role);
        if (rc == false)
            return false;

        var result = await userManager.AddToRoleAsync(user, role);
        return result.Succeeded;
    }
}
