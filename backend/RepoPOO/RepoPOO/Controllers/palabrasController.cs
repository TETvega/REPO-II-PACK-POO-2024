using Microsoft.AspNetCore.Mvc;
using RepoPOO.Dto;
using RepoPOO.Dto.common;
using RepoPOO.Services.Interface;

namespace RepoPOO.Controllers
{
    [ApiController]
    [Route("api/ahorcado")]
    public class palabrasController: ControllerBase
    {
        private readonly IAhorcado _ahorcadoService;
        public palabrasController(IAhorcado ahorcadoService)
        {
            _ahorcadoService = ahorcadoService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<palabraDTO>>> GetRandomWord()
        {
            var response = await _ahorcadoService.GetRandomWordAsync();
            return StatusCode(response.StatusCode, response);
        }

    }
}
