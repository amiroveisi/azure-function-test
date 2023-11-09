using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using azure_function_test.Services;

namespace FinitX.TestAzureFunctions
{
    public class HttpTrigger1
    {
        private IDummyService _dummyService;
        private ILogger _logger;
        public HttpTrigger1(IDummyService dummyService, ILogger logger)
        {
            _dummyService = dummyService;
            _logger = logger;
        }

        [FunctionName("HttpTrigger1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var result = _dummyService.DummyMethod();

            return new OkObjectResult(result);
        }
    }
}
