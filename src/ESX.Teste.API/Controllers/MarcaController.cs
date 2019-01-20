using ESX.Teste.Application.Configurations;
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
        private readonly IPatrimonioAppService _patrimonioAppService;

        public MarcaController(IMarcaAppService marcaAppService,
                               IPatrimonioAppService patrimonioAppService)
        {
            _marcaAppService = marcaAppService;
            _patrimonioAppService = patrimonioAppService;
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
            var patrimonio = _patrimonioAppService.GetById(id);

            if (patrimonio == null)
                return ResponseBadRequest("Marca not found");

            return ResponseOk(_marcaAppService.GetById(id));
        }

        [HttpGet]
        [Route("{id}/patrimonios")]
        public IActionResult GetPatrimonios(Guid id)
        {
            return ResponseOk(_patrimonioAppService.GetByMarcaId(id));
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
            if (_marcaAppService.GetById(id) == null)
                return ResponseBadRequest("Marca not found");

            _marcaAppService.Remove(id);
            return ResponseOk();
        }
    }
}