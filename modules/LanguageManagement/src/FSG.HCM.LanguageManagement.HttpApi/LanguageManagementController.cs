using FSG.HCM.LanguageManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FSG.HCM.LanguageManagement
{
    public abstract class LanguageManagementController : AbpController
    {
        protected LanguageManagementController()
        {
            LocalizationResource = typeof(LanguageManagementResource);
        }
    }
}
