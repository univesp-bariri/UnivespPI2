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
        public DbSet<contratante> Contratantes {get; set;}
        public DbSet<candidato> Candidatos {get; set;}
        public DbSet<candidatura> Candidaturas {get; set;}
        public DbSet<trabalho> Trabalhos {get; set;}
        public DbSet<local> Locals {get; set;}
        public DbSet<categoria> Categorias {get; set;}


    }
}