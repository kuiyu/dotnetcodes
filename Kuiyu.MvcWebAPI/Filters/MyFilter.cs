/*
 源码己托管:http://git.oschina.net/kuiyu/dotnetcodes
 * 作者：kuiyu
 * QQ 79599287
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Kuiyu.MvcWebAPI.Filters
{
    public class MyFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            #region 2.得到传给WEBAPI的参数值
            HttpContextWrapper content = (HttpContextWrapper)actionContext.Request.Properties["MS_HttpContext"];
            //假设POST过来两个参数值 Plain 和Signature
            string Plain = content.Request.Form["Plain"]; 
            string Signature = content.Request.Form["Signature"];
            #endregion

            base.OnActionExecuting(actionContext);
        }
    }
}