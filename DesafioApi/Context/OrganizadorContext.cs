using Microsoft.EntityFrameworkCore;
using DesafioApi.Models;


namespace DesafioApi.Context
{
    public class OrganizadorContext:DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}