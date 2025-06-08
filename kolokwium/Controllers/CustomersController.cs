using kolokwium.DTOs;
using kolokwium.Services;
using Microsoft.AspNetCore.Mvc;
namespace kolokwium
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        
        private readonly IDbService _dbService;

        public CustomersController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id}/purchases")]
        public async Task<IActionResult> GetPurchase(int id)
        {
            try
            {
                var order = await _dbService.GetCustomerById(id);
                return Ok(order);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
