using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Dapper;
using Volo.Abp.Domain;
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
            var configuration = context.Services.GetConfiguration();

            var connectionString = configuration.GetConnectionString("Default");
            var freeSql = new FreeSql.FreeSqlBuilder()
                .UseConnectionString(FreeSql.DataType.MySql, connectionString)
                .Build();

            context.Services.AddSingleton<IFreeSql>(freeSql);
        }

       
    }
}
