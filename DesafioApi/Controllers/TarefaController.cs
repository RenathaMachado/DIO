using Microsoft.AspNetCore.Mvc;
using DesafioApi.Context;
using DesafioApi.Models;

namespace DesafioApi.Controllers
{
    public class TarefaController:Controller
    {
       
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas); // Retorna uma lista do banco Contatos
        }

        public IActionResult Criar(){ // método Get(implicito) no qual retorna a página Criar
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if(ModelState.IsValid){
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
                return View(tarefa);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            // TODO: Buscar o Id no banco utilizando o EF
            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
            // caso contrário retornar OK com a tarefa encontrada
            return Ok();
        }

        
        public IActionResult ObterTodos()
        {
         var tarefa = _context.Tarefas.ToList();
         if(tarefa == null)  
         return RedirectToAction(nameof(Index));
         return View(tarefa);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            return Ok();
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
            return Ok(tarefa);
        }

        public IActionResult Atualizar(int id){
            var tarefa = _context.Tarefas.Find(id);
            if(tarefa == null)
            return NotFound();
            return View(tarefa);
        }

         

        [HttpPost]
        public IActionResult Atualizar(Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(tarefa.Id);
            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;
            
            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
            // TODO: Atualizar as informações da variável tarefaBanco com a tarefa recebida via parâmetro
            // TODO: Atualizar a variável tarefaBanco no EF e salvar as mudanças (save changes)
        }
         public IActionResult Deletar(int id){
           var tarefa = _context.Tarefas.Find(id);
            if(tarefa == null)
            return RedirectToAction(nameof(Index));
            return View(tarefa); 
        }

        [HttpPost]
        public IActionResult Deletar(Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(tarefa.Id);
            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

            // TODO: Remover a tarefa encontrada através do EF e salvar as mudanças (save changes)
        }
    }
}