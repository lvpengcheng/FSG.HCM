using FSG.HCM.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
