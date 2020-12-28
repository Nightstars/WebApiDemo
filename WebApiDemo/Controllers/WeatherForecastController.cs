using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private List<User> users;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            users = new List<User>
            {
                new User{name="张三",phone="19987654321"},
                new User{name="李四",phone="19987654321"},
                new User{name="赵六",phone="19987654321"}
            };
        }

        [HttpGet]
        public Object Get()
        {
            return new { status = "Success", data = users }; ;
        }

        [HttpPost]
        public Object Add(User user)
        {
            users.Add(user);
            return new  {status="Success",data=users };
        }
    }
}
