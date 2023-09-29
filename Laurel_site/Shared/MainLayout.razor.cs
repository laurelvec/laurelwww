
using Laurel_site.Services;
using Microsoft.AspNetCore.Components;

namespace Laurel_site.Shared;

public partial class MainLayout
{

    private static bool first = true;
    [Inject] LaurelIdentityService? LaurelIdentityService { get; set; }
    protected async override Task OnInitializedAsync()
    {

        await base.OnInitializedAsync();
        if (first == true)
            await CheckRoles();
        first = false;
        return;
    }

    private async Task CheckRoles()
    {
        await LaurelIdentityService!.AddAdminRolesIfNeededAsync();
    }
}
