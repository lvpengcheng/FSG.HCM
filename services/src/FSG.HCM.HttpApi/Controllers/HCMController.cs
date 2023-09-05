namespace FSG.HCM.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class HCMController : AbpController
    {
        protected HCMController()
        {
            LocalizationResource = typeof(HCMResource);
        }
    }
}