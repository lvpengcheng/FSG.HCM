namespace FSG.HCM.FileManagement;

public class FileManagementApplicationAutoMapperProfile : Profile
{
    public FileManagementApplicationAutoMapperProfile()
    {
        CreateMap<FSG.HCM.FileManagement.Files.File, PagingFileOutput>();
    }
}