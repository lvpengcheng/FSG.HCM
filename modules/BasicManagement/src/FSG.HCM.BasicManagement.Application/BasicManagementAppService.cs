using FSG.HCM.BasicManagement.Localization;

namespace FSG.HCM.BasicManagement;

public abstract class BasicManagementAppService : ApplicationService
{
    protected BasicManagementAppService()
    {
        LocalizationResource = typeof(BasicManagementResource);
        ObjectMapperContext = typeof(BasicManagementApplicationModule);
    }
}
