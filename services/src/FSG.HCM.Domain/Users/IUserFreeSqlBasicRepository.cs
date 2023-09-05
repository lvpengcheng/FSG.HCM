namespace FSG.HCM.Users
{
    public interface IUserFreeSqlBasicRepository
    {
        Task<List<UserOutput>> GetListAsync();
    }
}
