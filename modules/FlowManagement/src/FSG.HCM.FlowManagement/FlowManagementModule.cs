using FSG.HCM.Core;
using Humanizer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain.Entities.Caching;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FSG.HCM.FlowManagement
{
    public class FlowManagementModule : BaseModule
    {
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnApplicationInitialization(context);
        }


        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAssemblyOf<FlowManagementModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                //Add all mappings defined in the assembly of the MyModule class
                options.AddMaps<FlowManagementModule>();
            });
            context.Services.AddAbpDbContext<FlowManagementDbcontext>(options =>
            {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            //context.Services.AddSingleton<ISqlExecuter<TestDbContext>>();
            context.Services.AddEntityCache<EmpTest, Guid>();
            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also CompanyNameProjectNameMigrationsDbContextFactory for EF Core tooling. */
                options.UseMySQL();
                //options.UseSqlServer();
            });

            context.Services.AddSingleton<SqlExecuter<FlowManagementDbcontext>>();

            ////Register a factory method that resolves from IServiceProvider
            context.Services.AddScoped<ISqlExecuter<FlowManagementDbcontext>>(
                sp => sp.GetRequiredService<SqlExecuter<FlowManagementDbcontext>>()
            );
            //Configure<AbpAutoMapperOptions>(options =>
            //{
            //    //Add all mappings defined in the assembly of the MyModule class
            //    options.AddMaps<TestModule>();
            //    options.AddProfile<CustomDtoMapper>(validate: true);
            //});
            //context.Services.AddAutoMapperObjectMapper<TestModule>();

            //Configure<AbpAutoMapperOptions>(options =>
            //{
            //    options.AddMaps<TestModule>(validate: true);
            //});
            //context.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
            context.Services.AddControllers().AddNewtonsoftJson();
            //context.Services.AddControllers().AddNewtonsoftJson().AddJsonOptions(options =>
            //{
            //    options.JsonSerializerOptions.IgnoreNullValues = true;
            //    options.JsonSerializerOptions.WriteIndented = true;
            //});

            ConfigureConventionalControllers();
        }

        private void ConfigureConventionalControllers()
        {
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(FlowManagementModule).Assembly, setting =>
                {
                    setting.UseV3UrlStyle = true;
                    //setting.UrlControllerNameNormalizer = context => context.ControllerName?.Pluralize().Kebaberize();
                    //setting.UrlActionNameNormalizer = context => context.ActionNameInUrl?.Dasherize();
                });
            });
        }
    }
}
