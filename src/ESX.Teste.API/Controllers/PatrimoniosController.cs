using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels.Patrimonio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESX.Teste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatrimoniosController : ApiController
    {
        private readonly IPatrimonioAppService _patrimonioAppService;

        public PatrimoniosController(IPatrimonioAppService patrimonioAppService)
        {
            _patrimonioAppService = patrimonioAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return ResponseOk(_patrimonioAppService.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(Guid id)
        {
            return ResponseOk(_patrimonioAppService.GetById(id));
        }

        [HttpPost]
        public IActionResult Insert([FromBody] PatrimonioRequestAddViewModel viewmodel)
        {
            return ResponseOk(_patrimonioAppService.Add(viewmodel));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(Guid id, PatrimonioRequestUpdateViewModel viewmodel)
        {
            return ResponseOk(_patrimonioAppService.Update(id, viewmodel));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            _patrimonioAppService.Remove(id); return ResponseOk();
        }
    }
}