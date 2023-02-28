using Sample.CustomerService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Sample.CustomerService.Permissions;

public class CustomerServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerServicePermissions.GroupName, L("Permission:CustomerService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerServiceResource>(name);
    }
}
