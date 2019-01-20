using Microsoft.AspNetCore.Mvc;

namespace ESX.Teste.API.Controllers
{
    public class ApiController : ControllerBase
    {
        protected new IActionResult ResponseOk(object result = null)
        {
            return Ok(new
            {
                success = true,
                data = result
            });
        }

        protected new IActionResult ResponseBadRequest(object result = null)
        {
            return BadRequest(new
            {
                success = false,
                data = result
            });
        }
    }
}