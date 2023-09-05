namespace FSG.HCM
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<HCMHttpApiHostModule>();
        }

        public void Configure(IApplicationBuilder app,IHostApplicationLifetime lifetime)
        {
            app.InitializeApplication();
            lifetime.ApplicationStopped.Register(ConfigurePreheat);
        }
        
        
        /// <summary>
        /// 程序首次访问接口速度慢，事先预热
        /// </summary>
        [Obsolete("请使用FSG.HCM.Starter模块,实现IHCMStarterContributor")]
        private void ConfigurePreheat()
        {
            var url = _configuration.GetValue<string>("App:SelfUrl");
            if (url.IsNullOrWhiteSpace()) return;
            var requestUrl = $"{url}/api/abp/application-configuration";
            new HttpClient().GetAsync(requestUrl).Wait();
        }
    }
}
