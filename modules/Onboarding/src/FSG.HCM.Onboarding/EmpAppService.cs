using Aspose.Cells;
using FDD.OpenAPI;
using FDD.OpenAPI.SDKModels.Accounts;
using FSG.HCM.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Senparc.NeuChar.Entities;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.AdvancedAPIs.GroupMessage;
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
            List<Article> articleList= new List<Article>();
            articleList.Add(new Article()
            {
                Title = "测试更多标题12",
                Description = "测试更多描述",
                Url = "https://www.baidu.com",
                PicUrl = "https://sdk.weixin.senparc.com/Images/qrcode.jpg"
            });

            var news = articleList.Select(z => new NewsModel()
            {
                title = z.Title,
                content = "点击【阅读原文】访问",//内容暂时无法获取到
                digest = z.Description,
                content_source_url = z.Url,
                thumb_url = z.PicUrl,
                //thumb_media_id=Guid.NewGuid().ToString(),
            }).ToArray();
            //上传临时素材
            //var newsResult = MediaApi.UploadTemporaryNews("wx58c8a3f9e8bd0abb", news: news);
            //await CustomApi.SendMpNewsAsync("wx58c8a3f9e8bd0abb", "oF7rtwrZQ51FOVJfTkVVdBN3CITc", newsResult.media_id, 10000, "");
            await CustomApi.SendTextAsync("wx58c8a3f9e8bd0abb", "oF7rtwrZQ51FOVJfTkVVdBN3CITc", "hello");
            await TemplateApi.SendTemplateMessageAsync("wx58c8a3f9e8bd0abb", "oF7rtwrZQ51FOVJfTkVVdBN3CITc", "UbZqcD8CG4krEHnZAcEx4jTJsMeECdqe3HsjiZks1aQ", "","",null,1000);
            return "aaa1112";
        }

        public string TestFadada() {
            var ServerUrl = "https://sandboxapi.fadada.com/api/v3";
            var AppId = "FA67694018";
            var AppKey = "UNPRNJ8M35RUBJCTVOTJSL2AXQRLGMZS";
            //var client = new OpenClient(ServerUrl, AppId, AppKey);
            var client = new EcologicalClient(ServerUrl, AppId, AppKey);

            var result3 = client.Execute(new GetCompanyUnionIdUrlRequest()
            {
                clientId = "6666666666666",
                company = new GetCompanyUnionIdUrlRequest.Company()
                {
                    companyName = "abccompany"
                },
                redirectUrl = "http://www.shouhu.com",
                applicant = new GetCompanyUnionIdUrlRequest.Applicant()
                {
                    applicantType = "1",
                    unionId = "28374"
                }
            });

            return JsonConvert.SerializeObject(result3);
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
