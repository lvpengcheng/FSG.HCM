namespace FSG.HCM.BasicManagement.Systems
{
    public class AccountController : BasicManagementController, IAccountAppService
    {
        private readonly IAccountAppService _accountAppService;

        public AccountController(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }


        [SwaggerOperation(summary: "登录", Tags = new[] { "Account" })]
        public Task<LoginOutput> LoginAsync(LoginInput input)
        {
            return _accountAppService.LoginAsync(input);
        }


        [SwaggerOperation(summary: "登录", Tags = new[] { "Account" })]
        public string Test()
        {
            return "这是一个测试";
        }
    }
}