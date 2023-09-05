namespace FSG.HCM.BasicManagement.Tenants.Dtos
{
    public class UpdateConnectionStringInput : IValidatableObject
    {
        public Guid Id { get; set; }
        public string ConnectionString { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var localization = validationContext.GetRequiredService<IStringLocalizer<HCMLocalizationResource>>();
            if (ConnectionString.IsNullOrWhiteSpace())
            {
                yield return new ValidationResult(
                    localization[HCMLocalizationErrorCodes.ErrorCode100003, nameof(ConnectionString)],
                    new[] { nameof(ConnectionString) }
                );
            }
        }
    }
}