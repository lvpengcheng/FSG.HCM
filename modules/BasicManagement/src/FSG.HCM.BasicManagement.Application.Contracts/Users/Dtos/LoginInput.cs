using Volo.Abp.Auditing;

namespace FSG.HCM.BasicManagement.Users.Dtos
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginInput : IValidatableObject
    {
        /// <summary>
        /// 用户名或者邮箱
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 密码
        /// </summary>
        [DisableAuditing]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var localization = validationContext.GetRequiredService<IStringLocalizer<HCMLocalizationResource>>();
            if (Name.IsNullOrWhiteSpace())
            {
                yield return new ValidationResult(
                    localization[HCMLocalizationErrorCodes.ErrorCode100003, nameof(Name)],
                    new[] { "Name" }
                );
            }

            if (Password.IsNullOrWhiteSpace())
            {
                yield return new ValidationResult(
                    localization[HCMLocalizationErrorCodes.ErrorCode100003, nameof(Password)],
                    new[] { "Password" }
                );
            }
        }
    }
}