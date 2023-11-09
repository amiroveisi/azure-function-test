using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azure_function_test.Services
{
    public class DummyService : IDummyService
    {
        public string DummyMethod()
        {
            return "Dummy method called!";
        }
    }
}
