using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectPI2.Models;



namespace Mapeamentos
{

    public class AnuncioMap : IEntityTypeConfiguration<anuncio>
    {

        public void Configure(EntityTypeBuilder<anuncio > Builder )
        {
            Builder.HasKey( p => p.id );
            Builder.Property( p => p.titulo).HasMaxLength(30).IsRequired();
            Builder.Property( p => p.categorianome).HasMaxLength(30);
            Builder.Property( p => p.categorianome).HasMaxLength(30).IsRequired();
            Builder.Property( p => p.categnome).HasMaxLength(30);
            Builder.Property( p => p.descricao).HasMaxLength(100).IsRequired();
            Builder.Property( p => p.telefone).HasMaxLength(15).IsRequired();
            Builder.Property( p => p.whatsapp).HasMaxLength(15);
            Builder.Property( p => p.custo).HasMaxLength(10);

            Builder.HasOne( p => p.Usuarios).WithMany( p => p.Anuncios).HasForeignKey( p => p.usuarioId);

            Builder.ToTable("anuncio");
        }

    }

    

}