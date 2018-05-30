using RGB.curso.dominio.BCpedido.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Rgb.Curso.Infra.Data.Repository.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        // mostrar a turma
        // https://github.com/aspnet/EntityFramework6/issues/35

        public FornecedorConfiguration()
        {

            HasKey(f => f.Id);

            Property(p => p.Id)
              .HasColumnOrder(0);

            Property(p => p.Apelido)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .HasColumnName("Apelido")
                .HasColumnOrder(1)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(p => p.Nome)
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .HasColumnName("Nome")
                .HasColumnOrder(2);


            Property(p => p.CpfCnpj.CpfCnpj)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnType("varchar")
                .HasColumnName("CPFCNPJ")
                .HasColumnOrder(3)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(p => p.Email.EnderecoEmail)
                .HasMaxLength(255)
                .HasColumnType("varchar")
                .HasColumnName("Email")
                .HasColumnOrder(4);


            Property(p => p.Endereco.Endereco)
                .HasMaxLength(150)
                .HasColumnType("varchar")
                .HasColumnName("Endereco")
                .HasColumnOrder(5);


            Property(p => p.Endereco.Bairro)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .HasColumnName("Bairro")
                .HasColumnOrder(6);


            Property(p => p.Endereco.Cidade)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .HasColumnName("Cidade")
                .HasColumnOrder(7);


            Property(p => p.Endereco.UF.UF)
                .HasMaxLength(2)
                .HasColumnType("varchar")
                .HasColumnName("UF")
                .HasColumnOrder(8);


            Property(p => p.Endereco.CEP.CEP)
                .HasMaxLength(8)
                .HasColumnType("varchar")
                .HasColumnName("CEP")
                .HasColumnOrder(9);

            ToTable("Fornecedores");
        }
    }
}