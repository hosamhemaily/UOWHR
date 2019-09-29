using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AdditionalTransactionController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICommonProcess<AddionalPaymentHDModel> _commonProcess;
        IAdditionalPaymentTransactionService _accountService;
        public AdditionalTransactionController(IAdditionalPaymentTransactionService accountService
            , UserManager<ApplicationUser> userManager,
            ICommonProcess<AddionalPaymentHDModel> commonProcess
            )
        {
            _accountService = accountService;
            _userManager = userManager;
            _commonProcess = commonProcess;
        }

        // GET api/values
        [HttpGet]
        public async Task<List<AddionalPaymentHeModel>> Get()
        {
            return await _accountService.GetData(0, 0, 0);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<AddionalPaymentHDModel> Get(int id)
        {
            return await _accountService.GetById(id);
        }

        // POST api/values
        [HttpPost("[action]")]
        [AutherizationAttribute]
        public async Task<AddionalPaymentHDModel> Add(AddionalPaymentHDModel accountModel)
        {
            await _commonProcess.SetCommonProperty(accountModel, HttpContext.Request.Headers["user"], "InsertUserId");
            return  await _accountService.Insert(accountModel);
        }

        // POST api/values
        [HttpPost("[action]")]
        [AutherizationAttribute]
        public async Task<AddionalPaymentHDModel> Update(AddionalPaymentHDModel accountModel)
        {           
            await _commonProcess.SetCommonProperty(accountModel, HttpContext.Request.Headers["user"],"UpdateUserId");
            return await _accountService.Update(accountModel);
        }

        // POST api/values
        [HttpDelete("{id}")]
        [AutherizationAttribute()]
        public async Task<bool> Delete(long id)
        {
           return  await _accountService.Delete(id);
        }
    }
}