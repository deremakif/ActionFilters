using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace actionFilter.Filters
{

    public class PermissionFilter : ActionFilterAttribute
    {
        public PermissionFilter()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var RemoteIpAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
            // Consider your server environment requirements!
            // http://nginx.org/en/docs/http/ngx_http_realip_module.html
            // https://docs.cloud.oracle.com/en-us/iaas/Content/Balance/Reference/httpheaders.htm
            // var ip = context.HttpContext.Request.Headers["X-Real-IP"].FirstOrDefault();
            // RemoteIpAddress = "::1" when running on local

            // Permitted IP Address: 78.183.118.159
            if (RemoteIpAddress != "78.183.118.159")
                throw new Exception("No Auth!");

        }


    }
}
