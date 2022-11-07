using Microsoft.AspNetCore.Mvc;
using Modulo_API.Entities;
using Modulo_API.Context;
using System.Linq;
namespace Modulo_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController: ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context){ // Construtor que irá receber os dados do context
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato){ // endpoint create. Cria os dados a serem inseridos no banco
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        // endpoint que irá buscar dados no banco por id
        public IActionResult ObterPorId(int id){ 
            if(id == null)
            return NotFound();

            var contato = _context.Contatos.Find(id);
            return Ok(contato);
        }

        // endpoint obter contato por nome na tabela ou qualquer outra coluna
        
        [HttpGet("{obterPorNome}")]
        public IActionResult ObterPorNome(string nome){ 
           
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")] // verbo para atualizar os dados no banco
        // endpoint que irá atualizar os dados no banco
        public IActionResult Atualizar(int id, Contato contato){ 
            var contatoBanco = _context.Contatos.Find(id);
            if(id == null)
                return NotFound();
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }   

        [HttpDelete("{id}")] // verbo para deletar os dados
        // endpoint que irá deletar os dados do banco
        public IActionResult Deletar(int id, Contato contato){ 
            var contatoBanco = _context.Contatos.Find(id);
            if(id == null)
                return NotFound(); 
            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();  
        }

    }
}