using JimmyConcepcion_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;

namespace JimmyConcepcion_P2_AP1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
         
        public DbSet<Registro> registro { get; set; }
    }
}
