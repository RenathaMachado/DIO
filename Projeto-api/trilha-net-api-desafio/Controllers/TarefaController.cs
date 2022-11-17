using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var buscaTarefa = _context.Tarefas.Find(id);
            if(buscaTarefa == null)
                return NotFound();
                return Ok(buscaTarefa);
        }

        [HttpGet("GetTarefas")]
        public IEnumerable<Tarefa> GetTarefas()
        {
           return  _context.Tarefas.ToList();
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var buscaTitulo = _context.Tarefas.Where(x => x.Titulo == titulo);
            return Ok(buscaTitulo);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var buscaData = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(buscaData);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var bucaStatus = _context.Tarefas.Where(x => x.Status == status);
            return Ok(bucaStatus);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            _context.Add(tarefa);
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);
            if (id == null)
                return NotFound();
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Status = tarefa.Status;
            tarefaBanco.Titulo = tarefa.Titulo;
            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return Ok(tarefaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);
            if (id == null)
                return NotFound();
            _context.Remove(tarefaBanco);  
            _context.SaveChanges();
            return NoContent();
        }
    }
}
