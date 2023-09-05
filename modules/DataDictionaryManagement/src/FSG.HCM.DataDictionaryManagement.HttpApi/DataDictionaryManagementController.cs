using FSG.HCM.DataDictionaryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FSG.HCM.DataDictionaryManagement
{
    public abstract class DataDictionaryManagementController : AbpController
    {
        protected DataDictionaryManagementController()
        {
            LocalizationResource = typeof(DataDictionaryManagementResource);
        }
    }
}
