namespace FSG.HCM.BasicManagement.OrganizationUnits.Dto;

public class GetUnAddRoleInput : PagingBase
{
    public Guid OrganizationUnitId { get; set; }

    public string Filter { get; set; }
}