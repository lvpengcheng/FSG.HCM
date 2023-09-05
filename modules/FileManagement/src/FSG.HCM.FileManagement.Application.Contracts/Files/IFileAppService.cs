using System.Collections.Generic;
using System.Threading.Tasks;
using FSG.HCM.FileManagement.Files.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FSG.HCM.FileManagement.Files;

public interface IFileAppService : IApplicationService
{
    Task<FileTokenOutput> GetFileTokenAsync();
    Task CreateAsync(CreateFileInput input);

    Task<PagedResultDto<PagingFileOutput>> PagingAsync(PagingFileInput input);
}