using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetGreeting();
    }

    public class Greeder : IGreeter
    {
        private string _greeting;

        public Greeder(IConfiguration configuration)
        {
            _greeting = configuration["greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
