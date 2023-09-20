using Aspose.Cells;
using FSG.HCM.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Caching;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace FSG.HCM.Onboarding
{
   
    public class EmpAppService : BaseService<Emp, OnboardingDbcontext, EmpInput>
    {
        private readonly IEntityCache<Emp, Guid> _empCache;
        private readonly ICurrentUser _currentUser;
        public EmpAppService(IRepository<Emp, Guid> repository, IEntityCache<Emp, Guid> empCache, ISqlExecuter<OnboardingDbcontext> db, ICurrentUser currentUser) : base(repository, db)
        {
            _empCache = empCache;
            _currentUser = currentUser;
        }


        public async Task<string>  Test1111()
        {
            //var templateData = new MsgTemplateQueue()
            //{
            //    first = new TemplateDataItem($"{first}", "#CC0033"),
            //    keyword1 = new TemplateDataItem(name, "#99CC00"),
            //    keyword2 = new TemplateDataItem(cardnum, "#99CC00"),
            //    keyword3 = new TemplateDataItem(money, "#99CC00"),
            //    keyword4 = new TemplateDataItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "#99CC00"),
            //    remark = new TemplateDataItem("充值金额成功", "#0099CC")
            //};

            await CustomApi.SendTextAsync("wx58c8a3f9e8bd0abb", "oF7rtwrZQ51FOVJfTkVVdBN3CITc", "hello");
            await TemplateApi.SendTemplateMessageAsync("wx58c8a3f9e8bd0abb", "oF7rtwrZQ51FOVJfTkVVdBN3CITc", "UbZqcD8CG4krEHnZAcEx4jTJsMeECdqe3HsjiZks1aQ", "","",null,1000);
            return "aaa";
        }

        public string GetTenant()
        {
            return _currentUser.Id.ToString();
        }
        //[AllowAnonymous]
        //public override Task<List<Emp>> GetListAsync()
        //{
        //    return base.GetListAsync();
        //}
        //public override Task<Emp> InsertAsync(EmpInput e)
        //{
        //    return base.InsertAsync(e);
        //}

        //public override Task<Emp> GetAsync(Guid id)
        //{
        //    return _empCache.GetAsync(id);
        //    //return base.GetAsync(id);
        //}


    }
}
