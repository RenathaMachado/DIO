using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class ContatoController:Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context){ //injeção de dependência
            _context = context;
        }


        public IActionResult Index(){
            var contatos = _context.Contatos.ToList();
            return View(contatos); // Retorna uma lista do banco Contatos
        }

        public IActionResult Criar(){ // método Get(implicito) no qual retorna a página Criar
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato){
            if(ModelState.IsValid){
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); // redireciona para página Index
            }
            return View(contato);
        }

        public IActionResult Editar(int id){
            var contato = _context.Contatos.Find(id);
            if(contato == null)
            return NotFound();
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato){
            var contatoBanco = _context.Contatos.Find(contato.Id);
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhar(int id){
            var contato = _context.Contatos.Find(id);
            if(contato == null)
            return RedirectToAction(nameof(Index));
            return View(contato);
        }

        public IActionResult Deletar(int id){
           var contato = _context.Contatos.Find(id);
            if(contato == null)
            return RedirectToAction(nameof(Index));
            return View(contato); 
        }
        [HttpPost]
        public IActionResult Deletar(Contato contato){
            var contatoBanco = _context.Contatos.Find(contato.Id);
            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}