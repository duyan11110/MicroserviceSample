using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Test1Service.Localization;
using Sample.Test1Service.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;

namespace Sample.Test1Service.Web.Menus;

public class Test1ServiceMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name != StandardMenus.Main)
        {
            return;
        }

        var moduleMenu = AddModuleMenuItem(context);
        AddMenuItemJFSAs(context, moduleMenu);
    }

    private static ApplicationMenuItem AddModuleMenuItem(MenuConfigurationContext context)
    {
        var moduleMenu = new ApplicationMenuItem(
            Test1ServiceMenus.Prefix,
            context.GetLocalizer<Test1ServiceResource>()["Menu:Test1"],
            icon: "fa fa-folder"
        );

        context.Menu.Items.AddIfNotContains(moduleMenu);
        return moduleMenu;
    }
        
    private static void AddMenuItemJFSAs(MenuConfigurationContext context, ApplicationMenuItem parentMenu)
    {
        var utiMenu = new ApplicationMenuItem(Test1ServiceMenus.UTIMenu, displayName: "UTI", "~/Test1", icon: "fa fa-university"/*, requiredPermissionName: Test1ServicePermissions.UTIMaintenanceByCtParties.Default*/);
        parentMenu.AddItem(utiMenu);

        utiMenu.AddItem(new ApplicationMenuItem(Test1ServiceMenus.UTIMaintenanceByCtPartyPage, displayName: "UTI Maintenance By Ct Party", "~/Test1/UTIMaintenanceByCtParties", icon: "fa fa-hand-peace-o", requiredPermissionName: Test1ServicePermissions.UTIMaintenanceByCtParties.Default));

        context.Menu.Items.AddIfNotContains(parentMenu);
    }
}