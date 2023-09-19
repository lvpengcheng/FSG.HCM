namespace FSG.HCM.Jobs
{
    public class TestJob : IRecurringJob
    {
        public Task ExecuteAsync()
        {
            
            Console.WriteLine($"job 测试");
            return Task.CompletedTask;
        }
    }
}