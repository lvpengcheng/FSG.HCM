namespace FSG.HCM.Permissions
{
    public class HCMPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HCMResource>(name);
        }
    }
}