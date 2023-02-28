using Volo.Abp.Reflection;

namespace Sample.Test1Service.Permissions;

public class Test1ServicePermissions
{
    public const string GroupName = "Test1Service";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(Test1ServicePermissions));
    }

    public class UTIMaintenanceByCtParties
    {
        public const string Default = GroupName + ".UTIMaintenanceByCtParties";
        public const string Edit = Default + ".Edit";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
        public const string Approve = Default + ".Approve";
        public const string CancelApproval = Default + ".CancelApproval";
    }
    public class UTIControlByTrans
    {
        public const string Default = GroupName + ".UTIControlByTrans";
        public const string Edit = Default + ".Edit";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
        public const string Approve = Default + ".Approve";
        public const string CancelApproval = Default + ".CancelApproval";
    }

    public class BusinessKinds
    {
        public const string Default = GroupName + ".BusinessKinds";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Approve = Default + ".Approve";
    }
    public class Statuses
    {
        public const string Default = GroupName + ".Statuses";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Approve = Default + ".Approve";
    }
    public class StatusFlows
    {
        public const string Default = GroupName + ".StatusFlows";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Approve = Default + ".Approve";
    }
    public class UserActions
    {
        public const string Default = GroupName + ".UserActions";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Approve = Default + ".Approve";
    }

    public class GeneralParameters
    {
        public const string Default = GroupName + ".GeneralParameters";
        public const string Edit = Default + ".Edit";
        public const string Approve = Default + ".Approve";
        public const string CancelApproval = Default + ".CancelApproval";
    }

    public class SystemParameters
    {
        public const string Default = GroupName + ".SystemParameters";
        public const string Edit = Default + ".Edit";
        public const string Create = Default + ".Create";
    }

    public class ManualUploadFiles
    {
        public const string Default = GroupName + ".ManualUploadFiles";
        public const string Upload = Default + ".Upload";
        public const string Send = Default + ".Send";
        public const string Delete = Default + ".Delete";
        public const string Download = Default + ".Download";
    }
}
