using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;

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

        public class OKResultCustom<T> where T : class
        {
            public OKResultCustom(T data)
            {
                Success = true;
                Data = data;
            }

            public bool Success { get; set; }

            public T Data { get; set; }
        }

        public class BadRequestCustom
        {
            public BadRequestCustom(IEnumerable<string> errors)
            {
                Success = false;
                Errors = errors;
            }

            [DefaultValue(false)]
            public bool Success { get; set; }

            public IEnumerable<string> Errors { get; set; }
        }
    }
}