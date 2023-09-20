using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Senparc.Weixin.RegisterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Dapper;
using Volo.Abp.Domain;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Json;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Validation;

namespace FSG.HCM.Core
{
    [DependsOn(typeof(AbpAutofacModule))]
    [DependsOn(typeof(AbpJsonModule))]
    [DependsOn(typeof(AbpValidationModule))]
    [DependsOn(typeof(AbpDddDomainModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    [DependsOn(typeof(AbpObjectMappingModule))]
    [DependsOn(typeof(AbpDapperModule))]
    public class BaseModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also CompanyNameProjectNameMigrationsDbContextFactory for EF Core tooling. */
                options.UseMySQL();
                //options.UseSqlServer();
            });
        }

       


    }
}
