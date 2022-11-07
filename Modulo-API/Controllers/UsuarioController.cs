using Microsoft.AspNetCore.Mvc;
using System;

namespace Modulo_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController: ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")] // nome no qual vai buscar via GET
        public IActionResult ObterDataHora(){
            var obj = new{
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome){
            var mensagem = $"Olá {nome}, seja bem vindo";
            return Ok(new{mensagem});
        }
    }
}