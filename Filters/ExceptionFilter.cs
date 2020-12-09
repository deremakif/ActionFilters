using actionFilter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace actionFilter.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public ExceptionFilter()
        {

        }

        public override void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(new ErrorModel()
            {
                Message = context.Exception.Message
            });
        }
    }
}
