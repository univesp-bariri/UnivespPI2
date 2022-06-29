using Microsoft.EntityFrameworkCore;
using ProjectPI2.Models;

namespace WebPostgreSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        {

        }

        public DbSet<usuario> Usuarios {get; set;}
        public DbSet<anuncio> Anuncio {get; set;}
        // public DbSet<profissao> Profissao {get; set;}
        public DbSet<categoria> Categorias {get; set;}

        // inserir dados no BD
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<usuario>().HasData(
        //         new usuario
        //         {
        //             id = 1,
        //             username = "maximus",
        //             senha = "123456",
        //             email = "maximus@mail.com",
        //             nome = "Maximus Merindius",
        //             endereco = "Rua Joaquina DAgua, 6666",
        //             cep = "0226-066",
        //             cidade = "São Paulo",
        //             estado = "SP",
        //             pais = "Brasil",
        //             pjuridica = false,
        //             cpf = "666.666.666.66",
        //             candidatoId = 1
        //         });
        // }
    }
}