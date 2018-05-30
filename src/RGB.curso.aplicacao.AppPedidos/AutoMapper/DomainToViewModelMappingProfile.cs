using AutoMapper;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.shared.ValueObjects;
using RGB.Curso.Infra.CrossCutting.Customs.Extensions;
using System.Globalization;

namespace RGB.curso.aplicacao.AppPedidos.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        protected override void Configure()
        {
            Mapper.CreateMap<EstadoViewModel,Estado>();
            Mapper.CreateMap<CpfCnpjViewModel,CpfCnpjVO>();
            Mapper.CreateMap<UFViewModel, UFVO>();
            Mapper.CreateMap<CepViewModel, CepVO>();
            Mapper.CreateMap<EmailViewModel, EmailVO>();
            Mapper.CreateMap<EnderecoViewModel, EnderecoVO>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<ClienteViewModel, Cliente>();

            Mapper.CreateMap<ProdutoViewModel, Produto>()
                .ForMember(to => to.Valor, opt => opt.MapFrom(from => decimal.Parse(from.Valor.PadraoDecimal(), CultureInfo.InvariantCulture)));
        }
    }
}
