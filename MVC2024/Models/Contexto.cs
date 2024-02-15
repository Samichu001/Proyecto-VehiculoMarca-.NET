using Microsoft.EntityFrameworkCore;
using System.Collections;
namespace MVC2024.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<MarcaModelo> Marcas { get; set; }
        public IEnumerable Series { get; internal set; }
    }
}
