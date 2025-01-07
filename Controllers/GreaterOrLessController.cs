using Microsoft.AspNetCore.Mvc;
using TwoToFour_Endpoints.Services;

namespace TwoToFour_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterOrLessController : ControllerBase
    {
        private readonly GreaterOrLessServices _greaterOrLessServices;

        public GreaterOrLessController(GreaterOrLessServices greaterOrLessServices)
        {
            _greaterOrLessServices = greaterOrLessServices;
        }

        [HttpGet]
        [Route("GreaterOrLess/{num1}/{num2}")]
        public string GreaterOrLess(int num1, int num2)
        {
            return _greaterOrLessServices.GreaterOrLess(num1, num2);
        }
    }
}