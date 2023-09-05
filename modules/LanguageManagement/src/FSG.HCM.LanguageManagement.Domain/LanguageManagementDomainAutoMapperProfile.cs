using FSG.HCM.LanguageManagement.Languages;
using FSG.HCM.LanguageManagement.LanguageTexts;

namespace FSG.HCM.LanguageManagement
{
    public class LanguageManagementDomainAutoMapperProfile : Profile
    {
        public LanguageManagementDomainAutoMapperProfile()
        {
            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageText, LanguageTextDto>();
            CreateMap<Language, LanguageInfo>();
        }
    }
}