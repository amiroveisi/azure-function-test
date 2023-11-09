using azure_function_test.Services;
using FinitX.TestAzureFunctions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace azure_function_test.Tests
{
    [TestFixture]
    public class SimpleTest
    {
        private IDummyService _dummyService;
        private ILogger _logger;
        [SetUp]
        public void Setup(IDummyService dummyService, ILogger logger)
        {
            _dummyService = dummyService;
            _logger = logger;
        }
        [Test]
        public async void TestHttpTrigger1()
        {
            var sut = new HttpTrigger1(_dummyService, _logger);
            await sut.Run(new DefaultHttpRequest(new DefaultHttpContext()), _logger);
        }
    }
}
