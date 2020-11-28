using System.Collections.Generic;
using AutoMapper;
using Poc.Modules.Core;

namespace Poc.Modules.Application
{
    public class PedidoApplication : IPedidoApplication
    {
        private readonly IPedidoRepository _pedidoRepostiry;
        private readonly IMapper _objectMapper;

        public PedidoApplication(IPedidoRepository pedidoRepostiry,
                                 IMapper mapper)
        {
            _pedidoRepostiry = pedidoRepostiry;
            _objectMapper = mapper;
        }

        public List<PedidoDTO> BuscarPedidos()
        {
            var pedidosDto = new List<PedidoDTO>();

            _pedidoRepostiry.BuscarPedidos().ForEach(pedido =>
            {
                pedidosDto.Add(_objectMapper.Map<Pedido, PedidoDTO>(pedido));
            });

            return pedidosDto;
        }
    }
}
