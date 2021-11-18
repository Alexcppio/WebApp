using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace WebApp.Filters
{
    public class ChangePageArgs : Attribute, IPageFilter
    {
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            // Ничего не делать
        }
        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if(context.HandlerArguments.ContainsKey("message1"))
            {
                context.HandlerArguments["message1"] = "New message";
            }
        }
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            // Ничего не делать
        }
    }
}
