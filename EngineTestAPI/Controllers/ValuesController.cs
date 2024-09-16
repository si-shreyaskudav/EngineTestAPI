using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EngineTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("Ping")]
        public string Ping()
        {
            return "Pong!";
        }
    }
}
