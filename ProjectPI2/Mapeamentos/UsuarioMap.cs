using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectPI2.Models;



namespace Mapeamentos
{

    public class UsuarioMap : IEntityTypeConfiguration<usuario>
    {

        public void Configure(EntityTypeBuilder<usuario> Builder )
        {
            Builder.HasKey( p => p.id );
            Builder.Property( p => p.username).HasMaxLength(20).IsRequired();
            Builder.Property( p => p.senha).HasMaxLength(20).IsRequired();
            Builder.Property( p => p.email).HasMaxLength(30).IsRequired();
            Builder.Property( p => p.nome).HasMaxLength(50).IsRequired();
            Builder.Property( p => p.endereco).HasMaxLength(50).IsRequired();
            Builder.Property( p => p.cep).HasMaxLength(8).IsRequired();
            Builder.Property( p => p.cidade).HasMaxLength(30).IsRequired();
            Builder.Property( p => p.estado).HasMaxLength(20).IsRequired();
            Builder.Property( p => p.pjuridica).HasColumnType("Boolean  DEFAULT FALSE").IsRequired();
            Builder.Property( p => p.cnpj).HasMaxLength(14);
            Builder.Property( p => p.cpf).HasMaxLength(11);

            Builder.HasMany( p => p.Anuncios).WithOne( p => p.Usuarios).IsRequired();

            Builder.ToTable("usuario");
        }

    }

    

}