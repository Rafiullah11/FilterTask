using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace FilterTask.Models
{
    public class CustomFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var watch = new Stopwatch();
            watch.Start();
            
            context.HttpContext.Response.Headers.Add("action-namename", context.ActionDescriptor.DisplayName);
            context.HttpContext.Response.Headers.Add("http-method", context.HttpContext.Request.Method);
            context.HttpContext.Response.Headers.Add("http-scheme", context.HttpContext.Request.Scheme);
            context.HttpContext.Response.Headers.Add("host", context.HttpContext.Request.Host.ToString());
            context.HttpContext.Response.Headers.Add("port", context.HttpContext.Request.Host.Port.ToString());
            context.HttpContext.Response.Headers.Add("excute-time", watch.Elapsed.ToString());
            context.HttpContext.Response.Headers.Add("server-date", context.HttpContext.Response.Headers.Date.ToString());
            watch.Stop();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
