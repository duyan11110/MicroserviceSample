using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.CustomerService.Localization;
using Sample.CustomerService.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;

namespace Sample.CustomerService.Web.Menus;

public class CustomerServiceMenuContributor : IMenuContributor
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
            CustomerServiceMenus.Prefix,
            context.GetLocalizer<CustomerServiceResource>()["Menu:Customer"],
            icon: "fa fa-folder"
        );

        context.Menu.Items.AddIfNotContains(moduleMenu);
        return moduleMenu;
    }
        
    private static void AddMenuItemJFSAs(MenuConfigurationContext context, ApplicationMenuItem parentMenu)
    {
        //var utiMenu = new ApplicationMenuItem(CustomerServiceMenus.UTIMenu, displayName: "UTI", "~/Test1", icon: "fa fa-university"/*, requiredPermissionName: Test1ServicePermissions.UTIMaintenanceByCtParties.Default*/);
        //parentMenu.AddItem(utiMenu);

        //utiMenu.AddItem(new ApplicationMenuItem(CustomerServiceMenus.UTIControlByTransPage, displayName: "UTI Control By Transaction", "~/Test1/UTIControlByTrans", icon: "fa fa-cogs"));

        //context.Menu.Items.AddIfNotContains(parentMenu);
    }
}