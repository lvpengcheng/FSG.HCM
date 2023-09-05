namespace FSG.HCM.NotificationManagement
{
    public abstract class NotificationManagementController : AbpController
    {
        protected NotificationManagementController()
        {
            LocalizationResource = typeof(NotificationManagementResource);
        }
    }
}
