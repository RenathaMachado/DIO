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
            return View(tarefas); 
        }

        public IActionResult Criar(){ 
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

        public IActionResult ObterTodos()
        {
         var tarefa = _context.Tarefas.ToList();
         if(tarefa == null)  
         return RedirectToAction(nameof(Index));
         return View(tarefa);
        }

        public IActionResult ObterPorId(){
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }
        
        public IActionResult ObterPorId(int id){
            var tarefa = _context.Tarefas.Find(id);
            if(tarefa == null)
            return NotFound();
            return View(tarefa);
        }
        public IActionResult ObterPotTitulo(int titulo){
            var tarefa = _context.Tarefas.Find(titulo);
            if(tarefa == null)
            return NotFound();
            return View(tarefa);
        }
        public IActionResult ObterPorDescricao(int descricao){
            var tarefa = _context.Tarefas.Find(descricao);
            if(tarefa == null)
            return NotFound();
            return View(tarefa);
        }
        public IActionResult ObterPorData(int data){
            var tarefa = _context.Tarefas.Find(data);
            if(tarefa == null)
            return NotFound();
            return View(tarefa);
        }

        public IActionResult ObterPorStatus(int status){
            var tarefa = _context.Tarefas.Find(status);
            if(tarefa == null)
            return NotFound();
            return View(tarefa);
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
        }
    }
}