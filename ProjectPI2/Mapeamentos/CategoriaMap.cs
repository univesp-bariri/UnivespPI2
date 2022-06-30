using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectPI2.Models;



namespace Mapeamentos
{

    public class CategoriaMap : IEntityTypeConfiguration<categoria>
    {

        public void Configure(EntityTypeBuilder<categoria> Builder )
        {
            Builder.HasKey( p => p.id );
            Builder.Property( p => p.nome).HasMaxLength(50).IsRequired();

            Builder.ToTable("categoria");
        }

    }

    

}