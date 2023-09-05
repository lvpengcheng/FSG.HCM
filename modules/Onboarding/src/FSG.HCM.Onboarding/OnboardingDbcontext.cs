using Aspose.Pdf.Drawing;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Users;
using FSG.HCM.Core;

namespace FSG.HCM.Onboarding
{
    [ConnectionStringName("Default")]
    public class OnboardingDbcontext : BaseDbContext<OnboardingDbcontext>
    {
        public DbSet<Emp> Emps { get; set; }

        //public DbSet<Test> Tests { get; set; }

        //public DbSet<Survey> Surveys { get; set; }

        //public DbSet<SurveyDetail> SurveyDetails { get; set; }

        private readonly ICurrentUser _currentUser;
        public OnboardingDbcontext(DbContextOptions<OnboardingDbcontext> options, ICurrentUser currentUser) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override bool ShouldFilterEntity<TEntity>(IMutableEntityType entityType)
        {
            //if (typeof(IMayHaveOrganizationUnit).IsAssignableFrom(typeof(TEntity)))
            //{
            return false;
            //}

            return base.ShouldFilterEntity<TEntity>(entityType);
        }
        /// <summary>
        /// 使用数据库的函数来对取数时的逻辑进行全局性的过滤，可能有性能风险
        /// </summary>
        /// <param name="objString"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        //[DbFunction("DataPermission")]
        //public static bool DataPermission(string objString, string userId)
        //{
        //    throw new NotImplementedException();
        //}

        [DbFunction("DataPermission")]
        public static bool DataPermission(int objString)
        {
            throw new NotImplementedException();
        }

        //此处可以进行全局的数据过滤，准备在这里注入一个标准的存储过程，处理AUDL时
        protected override Expression<Func<TEntity, bool>> CreateFilterExpression<TEntity>()
        {
            var expression = base.CreateFilterExpression<TEntity>();
            //var x = JsonConvert.SerializeObject(TEntity);
            //Expression<Func<TEntity, bool>> isActiveFilter = e => (EF.Property<string>(e, "Name") == "Name200");
            Guid? userId = _currentUser.Id;
            Expression<Func<TEntity, bool>> isActiveFilter = e => (DataPermission(1));
            expression = expression == null
            ? isActiveFilter
            : CombineExpressions(expression, isActiveFilter);
            return expression;
        }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDbFunction(() => DataPermission(1));
        }
    }
}
