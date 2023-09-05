using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FSG.HCM.Core
{
    public class BaseFilter : IActionFilter, ITransientDependency
    {
        public BaseFilter()
        {
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        //此处可以注入权限表，实现用权限表来管理整个系统的权限
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var routedata = context.RouteData;
            var areaName = routedata.Values["area"];
            var controllerName = routedata.Values["controller"].ToString();
            var actionName = routedata.Values["action"].ToString();
            //var x = 1;
            //var authoried = false;
            //if (authoried == false)
            //{
            //    context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            //    return;
            //}
        }
    }
}
