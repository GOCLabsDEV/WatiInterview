using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WatiInterview.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpPost]
        [Route("add")]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
