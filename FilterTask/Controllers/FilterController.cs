using FilterTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilterTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class FilterController : Controller
    {
        // GET: api/<FilterController>

        [HttpGet]
        [ServiceFilter(typeof(CustomFilterAttribute))]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

       
    }
}
