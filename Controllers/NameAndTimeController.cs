using Microsoft.AspNetCore.Mvc;
using TwoToFour_Endpoints.Services;

namespace TwoToFour_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameAndTimeController : ControllerBase
    {
        private readonly NameAndTimeServices _nameAndTimeServices;

        public NameAndTimeController (NameAndTimeServices nameAndTimeServices)
        {
            _nameAndTimeServices = nameAndTimeServices;
        }

        [HttpGet]
        [Route("NameAndTime/{name}/{time}")]
        public string NameAndTime(string name, int time)
        {
            return _nameAndTimeServices.NameAndTime(name, time);
        }
    }
}