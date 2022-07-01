using Microsoft.EntityFrameworkCore;
using ProjectPI2.Models;
using Mapeamentos;

namespace WebPostgreSQL.Models
{
    public class Contexto : DbContext
    {

        public DbSet<usuario> Usuarios {get; set;}
        public DbSet<anuncio> Anuncios {get; set;}
        public DbSet<categoria> Categorias {get; set;}

        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        {

        }

    }
}