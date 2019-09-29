using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ValuesController : ControllerBase
    {
        IAbsenseTransactionService _absenseTransactionService;
        public ValuesController(IAbsenseTransactionService absenseTransactionService)
        {
            _absenseTransactionService = absenseTransactionService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<AbsenceTransactionModel>>> Get()
        {
            return await _absenseTransactionService.GetData(0, 0, 0);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AbsenceTransactionModel>> Get(int id)
        {
            return await _absenseTransactionService.GetById(id);
        }

        // POST api/values
        [HttpPost("[action]")]
        [AutherizationAttribute()]
        public async Task AddAbsenceTransaction(AbsenceTransactionModel absenceTransaction)
        {
            await _absenseTransactionService.Insert(absenceTransaction);
        }

        [HttpPost("[action]")]
        [AutherizationAttribute()]
        public async Task UpdateAbsenceTransaction(AbsenceTransactionModel absenceTransaction)
        {
            await _absenseTransactionService.Update(absenceTransaction);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
           return await _absenseTransactionService.Delete(id);
        }
    }
}
