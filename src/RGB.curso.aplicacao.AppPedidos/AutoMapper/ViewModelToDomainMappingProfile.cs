using AutoMapper;
using RGB.curso.aplicacao.AppPedidos.ViewModels;
using RGB.curso.dominio.BCpedido.Entidades;
using RGB.curso.dominio.shared.ValueObjects;
using RGB.Curso.Infra.CrossCutting.Customs.Extensions;
using System.Globalization;

namespace RGB.curso.aplicacao.AppPedidos.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Estado, EstadoViewModel>();
            Mapper.CreateMap<CpfCnpjVO, CpfCnpjViewModel>();
            Mapper.CreateMap<UFVO, UFViewModel>();
            Mapper.CreateMap<CepVO, CepViewModel>();
            Mapper.CreateMap<EmailVO, EmailViewModel>();
            Mapper.CreateMap<EnderecoVO, EnderecoViewModel>();
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();
            Mapper.CreateMap<Cliente, ClienteViewModel>();

            Mapper.CreateMap<Produto, ProdutoViewModel>()
                            .ForMember(to => to.Valor, opt => opt.MapFrom(from => string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,##0.00}", from.Valor)));
        }

    }
}
