using FSG.HCM.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace FSG.HCM.Onboarding.Permissions
{
    public class OnboardingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var abpIdentityGroup = context.GetGroup("AbpIdentity");

            var Onboarding = abpIdentityGroup.AddPermission(OnboardingPermissions.Onboarding.Default,
                L("Permission:Onboarding"), multiTenancySide: MultiTenancySides.Both);
            Onboarding.AddChild(OnboardingPermissions.Onboarding.Create, L("Onboarding:Create"), multiTenancySide: MultiTenancySides.Both);
            Onboarding.AddChild(OnboardingPermissions.Onboarding.Update, L("Onboarding:Update"), multiTenancySide: MultiTenancySides.Both);
            Onboarding.AddChild(OnboardingPermissions.Onboarding.Delete, L("Onboarding:Delete"), multiTenancySide: MultiTenancySides.Both);
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HCMLocalizationResource>(name);
        }
    }
}
