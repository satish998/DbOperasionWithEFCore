using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        //fetch all the record of table
        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            var result = await _appDbContext.Currencies.ToListAsync();
            return Ok(result);
        }

        // fetch single record of table throw id
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAllCurrenciesByIDAsync([FromRoute] int id)
        {
            var result = await _appDbContext.Currencies.FindAsync(id);  
            return Ok(result);
        }

        // fetch single record of table throw name
        [HttpGet("{name}")]
        public async Task<IActionResult> GetAllCurrenciesByIDAsync([FromRoute] string name)
        {
            var result = await _appDbContext.Currencies.Where(x=> x.Title==name).FirstOrDefaultAsync();
            return Ok(result);
        }
    }
}
