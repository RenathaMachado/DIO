using Microsoft.EntityFrameworkCore;
using Modulo_API.Entities;

namespace Modulo_API.Context
{
    public class AgendaContext: DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){

        }

        public DbSet<Contato> Contatos {get; set;}
    }
}