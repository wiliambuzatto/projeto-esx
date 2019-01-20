using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels.Marca;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESX.Teste.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MarcaController : ApiController
    {
        private readonly IMarcaAppService _marcaAppService;

        public MarcaController(IMarcaAppService marcaAppService)
        {
            _marcaAppService = marcaAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return ResponseOk(_marcaAppService.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(Guid id)
        {
            return ResponseOk(_marcaAppService.GetById(id));
        }

        [HttpGet]
        [Route("{id}/patrimonios")]
        public IActionResult GetPatrimonios(Guid id)
        {
            //RETORNAR OS PATRIMÔNIOS
            var marca = _marcaAppService.GetById(id);

            if (marca == null)
                return NotFound();

            return Ok(marca);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] MarcaRequestViewModel viewmodel)
        {
            return ResponseOk(_marcaAppService.Add(viewmodel));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(Guid id, MarcaUpdateViewModel viewmodel)
        {
            return ResponseOk(_marcaAppService.Update(id, viewmodel));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            _marcaAppService.Remove(id);
            return ResponseOk();
        }
    }
}