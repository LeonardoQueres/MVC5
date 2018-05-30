using RGB.curso.dominio.BCpedido.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Rgb.Curso.Infra.Data.Repository.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.Id);
            // caso seja chave composta!
            // HasKey(p => new { p.Id, p.Nome });

            Property(p => p.Id)
              .HasColumnOrder(0);

            Property(p => p.Apelido)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .HasColumnName("Apelido")
                .HasColumnOrder(1)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .HasColumnName("Nome")
                .HasColumnOrder(2);

            Property(p => p.Valor)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .HasColumnOrder(3);

            HasRequired(p => p.Fornecedor)
               .WithMany(f => f.Produtos)
               .HasForeignKey(p => p.IdFornecedor);

            Ignore(p => p.ListaErros);
        }
    }
}