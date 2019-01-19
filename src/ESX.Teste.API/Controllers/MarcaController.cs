using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESX.Teste.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class MarcaController : ApiController
    {
        private readonly IMarcaAppService _marcaAppService;

        public MarcaController(IMarcaAppService marcaAppService)
        {
            _marcaAppService = marcaAppService;
        }

        [HttpGet]
        [Route("marcas")]
        public IActionResult Get()
        {
            return Ok(_marcaAppService.GetAll());
        }

        [HttpGet]
        [Route("marcas/{id}")]
        public IActionResult GetById(Guid id)
        {
            var marca = _marcaAppService.GetById(id);

            if (marca == null)
                return NotFound();

            return Ok(marca);
        }

        [HttpGet]
        [Route("marcas/{id}/patrimonios")]
        public IActionResult GetPatrimonios(Guid id)
        {
            //RETORNAR OS PATRIMÔNIOS
            var marca = _marcaAppService.GetById(id);

            if (marca == null)
                return NotFound();

            return Ok(marca);
        }

        [HttpPost]
        [Route("marcas")]
        public IActionResult Insert([FromBody] MarcaViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(viewmodel);
            }

            _marcaAppService.Add(viewmodel);
            return Ok(viewmodel);
        }

        [HttpPut]
        [Route("marca/{id}")]
        public IActionResult Update(MarcaViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(viewmodel);
            }

            _marcaAppService.Update(viewmodel);
            return Ok(viewmodel);
        }

        [HttpDelete]
        [Route("marca/{id}")]
        public IActionResult Delete(Guid id)
        {
            _marcaAppService.Remove(id);
            return Ok();
        }
    }
}