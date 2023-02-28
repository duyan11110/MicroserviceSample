using Volo.Abp.Reflection;

namespace Sample.CustomerService.Permissions;

public class CustomerServicePermissions
{
    public const string GroupName = "CustomerService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CustomerServicePermissions));
    }
}
