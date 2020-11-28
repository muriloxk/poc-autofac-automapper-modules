using AutoMapper;

namespace Poc.Modules.Application.Mapping
{
    public class PedidoApplicationProfile : Profile
    {
        public PedidoApplicationProfile()
        {
            CreateMap<Core.Pedido, PedidoDTO>()
                .ForMember(d => d.NomeCliente,
                           opt => opt.MapFrom(src => src.Cliente.Nome))

                .ForMember(d => d.Id,
                           opt => opt.MapFrom(src => src.Id.ToString()))

                .ForMember(d => d.Valor,
                           opt => opt.MapFrom(src => src.Valor))

                .ReverseMap();
        }
    }
}
