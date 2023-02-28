using Volo.Abp.Reflection;

namespace Sample.SaaSService.Permissions;

public class SaaSServicePermissions
{
    public const string GroupName = "SaaSService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SaaSServicePermissions));
    }
}
