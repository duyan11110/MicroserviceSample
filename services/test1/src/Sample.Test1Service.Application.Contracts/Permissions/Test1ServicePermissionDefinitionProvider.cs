using Sample.Test1Service.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Sample.Test1Service.Permissions;

public class JFSAPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Test1ServicePermissions.GroupName, L("Permission:Test1"));

        var utiMaintenanceByCtPartyPermission = myGroup.AddPermission(Test1ServicePermissions.UTIMaintenanceByCtParties.Default, L("Permission:UTIMaintenanceByCtParty"));
        utiMaintenanceByCtPartyPermission.AddChild(Test1ServicePermissions.UTIMaintenanceByCtParties.Create, L("Permission:Create"));
        utiMaintenanceByCtPartyPermission.AddChild(Test1ServicePermissions.UTIMaintenanceByCtParties.Edit, L("Permission:Edit"));
        utiMaintenanceByCtPartyPermission.AddChild(Test1ServicePermissions.UTIMaintenanceByCtParties.Delete, L("Permission:Delete"));
        utiMaintenanceByCtPartyPermission.AddChild(Test1ServicePermissions.UTIMaintenanceByCtParties.Approve, L("Permission:Approve"));
        utiMaintenanceByCtPartyPermission.AddChild(Test1ServicePermissions.UTIMaintenanceByCtParties.CancelApproval, L("Permission:CancelApproval"));

        var utiControlByTrans = myGroup.AddPermission(Test1ServicePermissions.UTIControlByTrans.Default, L("Permission:UTIControlByTrans"));
        utiControlByTrans.AddChild(Test1ServicePermissions.UTIControlByTrans.Create, L("Permission:Create"));
        utiControlByTrans.AddChild(Test1ServicePermissions.UTIControlByTrans.Edit, L("Permission:Edit"));
        utiControlByTrans.AddChild(Test1ServicePermissions.UTIControlByTrans.Delete, L("Permission:Delete"));
        utiControlByTrans.AddChild(Test1ServicePermissions.UTIControlByTrans.Approve, L("Permission:Approve"));
        utiControlByTrans.AddChild(Test1ServicePermissions.UTIControlByTrans.CancelApproval, L("Permission:CancelApproval"));

        var generalParametersPermission = myGroup.AddPermission(Test1ServicePermissions.GeneralParameters.Default, L("Permission:GeneralParameters"));
        generalParametersPermission.AddChild(Test1ServicePermissions.GeneralParameters.Edit, L("Permission:Edit"));
        generalParametersPermission.AddChild(Test1ServicePermissions.GeneralParameters.Approve, L("Permission:Approve"));
        generalParametersPermission.AddChild(Test1ServicePermissions.GeneralParameters.CancelApproval, L("Permission:CancelApproval"));

        var systemParametersPermission = myGroup.AddPermission(Test1ServicePermissions.SystemParameters.Default, L("Permission:SystemParameters"));
        systemParametersPermission.AddChild(Test1ServicePermissions.SystemParameters.Edit, L("Permission:Edit"));
        systemParametersPermission.AddChild(Test1ServicePermissions.SystemParameters.Create, L("Permission:Create"));

        var businessKindsPermission = myGroup.AddPermission(Test1ServicePermissions.BusinessKinds.Default, L("Permission:BusinessKinds"));
        businessKindsPermission.AddChild(Test1ServicePermissions.BusinessKinds.Create, L("Permission:Create"));
        businessKindsPermission.AddChild(Test1ServicePermissions.BusinessKinds.Edit, L("Permission:Edit"));
        businessKindsPermission.AddChild(Test1ServicePermissions.BusinessKinds.Delete, L("Permission:Delete"));
        businessKindsPermission.AddChild(Test1ServicePermissions.BusinessKinds.Approve, L("Permission:Approve"));

        var statuesPermission = myGroup.AddPermission(Test1ServicePermissions.Statuses.Default, L("Permission:Statuses"));
        statuesPermission.AddChild(Test1ServicePermissions.Statuses.Create, L("Permission:Create"));
        statuesPermission.AddChild(Test1ServicePermissions.Statuses.Edit, L("Permission:Edit"));
        statuesPermission.AddChild(Test1ServicePermissions.Statuses.Delete, L("Permission:Delete"));
        statuesPermission.AddChild(Test1ServicePermissions.Statuses.Approve, L("Permission:Approve"));

        var statusFlowsPermission = myGroup.AddPermission(Test1ServicePermissions.StatusFlows.Default, L("Permission:StatusFlows"));
        statusFlowsPermission.AddChild(Test1ServicePermissions.StatusFlows.Create, L("Permission:Create"));
        statusFlowsPermission.AddChild(Test1ServicePermissions.StatusFlows.Edit, L("Permission:Edit"));
        statusFlowsPermission.AddChild(Test1ServicePermissions.StatusFlows.Delete, L("Permission:Delete"));
        statusFlowsPermission.AddChild(Test1ServicePermissions.StatusFlows.Approve, L("Permission:Approve"));

        var userActionsPermission = myGroup.AddPermission(Test1ServicePermissions.UserActions.Default, L("Permission:UserActions"));
        userActionsPermission.AddChild(Test1ServicePermissions.UserActions.Create, L("Permission:Create"));
        userActionsPermission.AddChild(Test1ServicePermissions.UserActions.Edit, L("Permission:Edit"));
        userActionsPermission.AddChild(Test1ServicePermissions.UserActions.Delete, L("Permission:Delete"));
        userActionsPermission.AddChild(Test1ServicePermissions.UserActions.Approve, L("Permission:Approve"));

        var manualUploadFilesPermission = myGroup.AddPermission(Test1ServicePermissions.ManualUploadFiles.Default, L("Permission:ManualUploadFiles"));
        manualUploadFilesPermission.AddChild(Test1ServicePermissions.ManualUploadFiles.Upload, L("Permission:Upload"));
        manualUploadFilesPermission.AddChild(Test1ServicePermissions.ManualUploadFiles.Send, L("Permission:Send"));
        manualUploadFilesPermission.AddChild(Test1ServicePermissions.ManualUploadFiles.Delete, L("Permission:Delete"));
        manualUploadFilesPermission.AddChild(Test1ServicePermissions.ManualUploadFiles.Download, L("Permission:Download"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Test1ServiceResource>(name);
    }
}
