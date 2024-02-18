using Microsoft.AspNetCore.Mvc;
using ProjetoWebApiAtualizado.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ProjetoWebApiAtualizado.Controllers
{
    
        [ApiController]
        [Route("api/v1/[controller]")]
        public class Controller : ControllerBase
        {
            public readonly IParametros _parametros;

            public Controller(IParametros parametros)
            {
                _parametros = parametros;
            }
            [HttpGet("/buscar/todos")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public async Task<IActionResult> BuscarTodosBancos()
            {
                var response = await _parametros.BuscarTodosBancos();
                if (response.codigoHttp == HttpStatusCode.OK)
                {
                    return Ok(response.Dadosretorno);
                }
                else
                {
                    return StatusCode((int)response.codigoHttp, response.erro);
                }
            }

            [HttpGet("/busca/{codigoBanco}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public async Task<IActionResult> BuscarBancos([RegularExpression("^[0-9]*$")] string codigoBanco)
            {
            var response = await _parametros.BuscarBancos(codigoBanco);
            if (response.codigoHttp == HttpStatusCode.OK)
                {
                    return Ok(response.Dadosretorno);
                }
                else
                {
                    return StatusCode((int)response.codigoHttp, response.erro);
                }
            }
        }
    
}
