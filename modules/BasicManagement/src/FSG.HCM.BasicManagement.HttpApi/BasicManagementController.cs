using FSG.HCM.BasicManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FSG.HCM.BasicManagement;

public abstract class BasicManagementController : AbpControllerBase
{
    protected BasicManagementController()
    {
        LocalizationResource = typeof(BasicManagementResource);
    }
}
