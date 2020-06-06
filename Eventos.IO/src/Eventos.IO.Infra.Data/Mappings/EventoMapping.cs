using Eventos.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.Infra.Data.Mappings
{
    public class EventoMapping : EntityTypeConfiguration<Evento.IO.Domain.Eventos.Evento>
    {
        public override void Map(EntityTypeBuilder<Evento.IO.Domain.Eventos.Evento> builder)
        {
            builder
                .Property(e => e.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Property(e => e.DescricaoCurta)
                .HasColumnType("varchar(150)");

            builder
                .Property(e => e.DescricaoLonga)
                .HasColumnType("varchar(max)");

            builder
                .Property(e => e.NomeEmpresa)
                .HasColumnType("varchar(150)")
                .IsRequired();


            //ignora as colunas
            builder
                .Ignore(e => e.ValidationResult);

            builder
                .Ignore(e => e.Tags);

            builder
                .Ignore(e => e.CascadeMode);

            builder
                .ToTable("Eventos");

            //relacionamentos
            builder
                .HasOne(e => e.Organizador)
                .WithMany(o => o.Eventos)
                .HasForeignKey(a => a.OrganizadorId);

            builder
                .HasOne(e => e.Categoria)
                .WithMany(o => o.Eventos)
                .HasForeignKey(a => a.CategoriaId)
                .IsRequired(false);
        }
    }
}
