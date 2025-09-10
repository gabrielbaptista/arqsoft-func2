using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ec9
{
    public class FunctionHello
    {
        private readonly ILogger<FunctionHello> _logger;

        public FunctionHello(ILogger<FunctionHello> logger)
        {
            _logger = logger;
        }

        [Function("FunctionHello")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
