using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels.Marca;
using ESX.Teste.Application.ViewModels.Patrimonio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ESX.Teste.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MarcasController : ApiController
    {
        private readonly IMarcaAppService _marcaAppService;
        private readonly IPatrimonioAppService _patrimonioAppService;

        public MarcasController(IMarcaAppService marcaAppService,
                               IPatrimonioAppService patrimonioAppService)
        {
            _marcaAppService = marcaAppService;
            _patrimonioAppService = patrimonioAppService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(OKResultCustom<List<MarcaResponseViewModel>>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return ResponseOk(_marcaAppService.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(OKResultCustom<MarcaResponseViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            var marca = _marcaAppService.GetById(id);

            if (marca == null)
                return NotFound("Marca not found");

            return ResponseOk(marca);
        }

        [HttpGet("{id}/patrimonios")]
        [ProducesResponseType(typeof(OKResultCustom<List<PatrimonioResponseViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPatrimonios(Guid id)
        {
            var marca = _marcaAppService.GetById(id);

            if (marca == null)
                return NotFound("Marca not found");

            return ResponseOk(_patrimonioAppService.GetByMarcaId(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        public IActionResult Insert([FromBody] MarcaRequestViewModel viewmodel)
        {
            return ResponseOk(_marcaAppService.Add(viewmodel));
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(Guid id, MarcaUpdateViewModel viewmodel)
        {
            return ResponseOk(_marcaAppService.Update(id, viewmodel));
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(Guid id)
        {
            if (_marcaAppService.GetById(id) == null)
                return NotFound("Marca not found");

            _marcaAppService.Remove(id);
            return ResponseOk();
        }
    }
}