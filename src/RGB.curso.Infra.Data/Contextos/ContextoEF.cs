using Rgb.Curso.Infra.Data.Repository.EntityConfig;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.shared.ValueObjects;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RGB.curso.Infra.Data.Contextos
{
    public class ContextoEF : DbContext
    {
        public ContextoEF()
            : base("ConPedidos")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasColumnType("varchar").HasMaxLength(100));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.ComplexType<CepVO>()
                .Ignore(x => x.Bairro)
                .Ignore(x => x.Cidade)
                .Ignore(x => x.Endereco)
                .Ignore(x => x.TipoLogradouro)
                .Ignore(x => x.UF);

            modelBuilder.ComplexType<UFVO>()
                .Ignore(x => x.ListaEstados);

            //modelBuilder.ComplexType<CpfCnpjVO>()
            //    .Property(vo => vo.CpfCnpj)
            //    .HasColumnName("CpfCnpj")
            //    .HasMaxLength(14)
            //    .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            //modelBuilder.ComplexType<EnderecoVO>()
            //   .Property(vo => vo.Endereco)
            //   .HasColumnName("Endereco")
            //   .HasMaxLength(100);

            //modelBuilder.ComplexType<EnderecoVO>()
            //   .Property(vo => vo.Bairro)
            //   .HasColumnName("Bairro")
            //   .HasMaxLength(20);

            //modelBuilder.ComplexType<EnderecoVO>()
            //   .Property(vo => vo.Cidade)
            //   .HasColumnName("Cidade")
            //   .HasMaxLength(20);

            //modelBuilder.ComplexType<EnderecoVO>()
            //   .Property(vo => vo.UF)
            //   .HasColumnName("UF")
            //   .HasMaxLength(2);

            //modelBuilder.ComplexType<EnderecoVO>()
            //   .Property(vo => vo.CEP)
            //   .HasColumnName("CEP")
            //   .HasMaxLength(8);

            //modelBuilder.ComplexType<EmailVO>()
            //   .Property(vo => vo.EnderecoEmail)
            //   .HasColumnName("Email")
            //   .HasMaxLength(100);

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
