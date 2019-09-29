using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountNumberController : ControllerBase
    {
        IAccountService _accountService;
        public AccountNumberController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<AccountModel>>> Get()
        {
            return await _accountService.GetData(0, 0, 0);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountModel>> Get(int id)
        {
            return await _accountService.GetById(id);
        }

        // POST api/values
        [HttpPost("[action]")]
        [AutherizationAttribute()]
        public async Task AddAccount(AccountModel accountModel)
        {
            await _accountService.Insert(accountModel);
        }

        // POST api/values
        [HttpPost("[action]")]
        [AutherizationAttribute()]
        public async Task UpdateAccount(AccountModel accountModel)
        {
            await _accountService.Update(accountModel);
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