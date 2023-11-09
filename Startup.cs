using azure_function_test.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

[assembly: FunctionsStartup(typeof(azure_function_test.Startup))]
namespace azure_function_test
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            
            builder.Services.AddSingleton<IDummyService>(service => new DummyService());
            builder.Services.AddSingleton<ILogger>(logger =>  new LoggerFactory().CreateLogger("test"));
        }
    }
}
