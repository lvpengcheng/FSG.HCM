using FSG.HCM.LanguageManagement.Languages;
using FSG.HCM.LanguageManagement.LanguageTexts;

namespace FSG.HCM.LanguageManagement
{
    public class LanguageManagementApplicationAutoMapperProfile : Profile
    {
        public LanguageManagementApplicationAutoMapperProfile()
        {
            CreateMap<LanguageDto, PageLanguageOutput>();
            CreateMap<Language, PageLanguageOutput>();
            CreateMap<LanguageTextDto, PageLanguageTextOutput>();
        }
    }
}