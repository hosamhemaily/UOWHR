using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace API.Controllers
{
    internal class AutherizationAttribute : Attribute, IAuthorizationFilter
    {
        
       
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var controllerInfo = context.ActionDescriptor as ControllerActionDescriptor;
            if (context != null)
            {
                string controllerName = controllerInfo.ControllerName;  

                if (controllerName == "Valuess")
                {
                    context.Result = new JsonResult("")
                    {
                        StatusCode = 401,
                        Value="unauthorized for do this actio"
                    };
                }
                else
                {                    
                    context.HttpContext.Request.Headers.Add("user", context.HttpContext.User.Identity.Name);
                }

            }
        }
    }
}