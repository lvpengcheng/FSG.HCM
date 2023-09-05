namespace FSG.HCM
{
    /* Inherit your application services from this class.
     */
    public abstract class HCMAppService : ApplicationService
    {
        protected HCMAppService()
        {
            LocalizationResource = typeof(HCMResource);
        }
    }
}
