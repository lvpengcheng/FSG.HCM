namespace FSG.HCM.NotificationManagement
{
    public abstract class NotificationManagementAppService : ApplicationService
    {
        protected NotificationManagementAppService()
        {
            LocalizationResource = typeof(NotificationManagementResource);
            ObjectMapperContext = typeof(NotificationManagementApplicationModule);
        }
    }
}
