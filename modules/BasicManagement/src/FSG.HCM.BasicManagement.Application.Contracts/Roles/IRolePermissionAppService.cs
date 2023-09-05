using FSG.HCM.BasicManagement.Roles.Dtos;

namespace FSG.HCM.BasicManagement.Roles
{
    public interface IRolePermissionAppService : IApplicationService
    {
        
        Task<PermissionOutput> GetPermissionAsync(GetPermissionInput input);

        Task UpdatePermissionAsync(UpdateRolePermissionsInput input);
    }
}