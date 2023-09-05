namespace FSG.HCM.BasicManagement.OrganizationUnits.Dto;

public class GetOrganizationUnitUserInput : PagingBase
{
    public Guid OrganizationUnitId { get; set; }

    public string Filter { get; set; }
}