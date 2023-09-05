namespace FSG.HCM.Settings
{
    public class HCMSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            ConfigEmail(context);
        }

       private static void ConfigEmail(ISettingDefinitionContext context)
        {
            context.GetOrNull(EmailSettingNames.Smtp.Host)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeText);

            context.GetOrNull(EmailSettingNames.Smtp.Port)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.Number);

            context.GetOrNull(EmailSettingNames.Smtp.UserName)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeText);

            context.GetOrNull(EmailSettingNames.Smtp.Password)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeText);
            

            context.GetOrNull(EmailSettingNames.Smtp.EnableSsl)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeCheckBox);

            context.GetOrNull(EmailSettingNames.Smtp.UseDefaultCredentials)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeCheckBox);

            context.GetOrNull(EmailSettingNames.DefaultFromAddress)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeText);
            
            context.GetOrNull(EmailSettingNames.DefaultFromDisplayName)
                .WithProperty(HCMSettings.Group.Default,
                    HCMSettings.Group.EmailManagement)
                .WithProperty(HCMSettings.ControlType.Default,
                    HCMSettings.ControlType.TypeText);
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HCMResource>(name);
        }
    }
}