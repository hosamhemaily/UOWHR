using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class CommonProcess<T> : ICommonProcess<T> where T : class
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public CommonProcess(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task SetCommonProperty(T model,string value,string propertyName)
        {
            var property = model.GetType().GetProperty(propertyName);
            var result = await _userManager.FindByEmailAsync(value);
            property.SetValue(model, result.Id.ToString());
        }
    }
}
