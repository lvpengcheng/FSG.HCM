namespace FSG.HCM.CAP;

public class HCMCapPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var abpIdentityGroup = context.GetGroup(HCMCapPermissions.CapManagement.Default);

        abpIdentityGroup.AddPermission(HCMCapPermissions.CapManagement.Cap, L("Permission:Cap"), multiTenancySide: MultiTenancySides.Both);
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HCMLocalizationResource>(name);
    }
}