using Microsoft.AspNetCore.Mvc;

namespace StoreBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHello")]
        public string Get()
        {
            HelloWorld helloWorld = new HelloWorld();
            return helloWorld.testString;
        }
    }
}