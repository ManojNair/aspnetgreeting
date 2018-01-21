using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.Services
{
    public interface IGreeter
    {

        string GetMessage();
    }

    public class Greeter : IGreeter
    {
        private readonly IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessage()
        {
            return _configuration["Greeting"];
            
        }
    }
}
