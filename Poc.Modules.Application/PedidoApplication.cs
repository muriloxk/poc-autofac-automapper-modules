using System;
using System.Collections.Generic;
using AutoMapper;
using Poc.Modules.Core;

namespace Poc.Modules.Application
{
    public class PedidoApplication : IPedidoApplication
    {
        private readonly IPedidoRepository _pedidoRepostiry;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMapper _objectMapper;

        public PedidoApplication(IPedidoRepository pedidoRepostiry,
                                 IServiceProvider serviceProvider,
                                 IMapper mapper)
        {
            _pedidoRepostiry = pedidoRepostiry;
            _objectMapper = mapper;
            _serviceProvider = serviceProvider;
        }

        public List<PedidoDTO> BuscarPedidos()
        {
            var pedidosDto = new List<PedidoDTO>();

            #region Apenas para teste do IServiceProvider trabalhando junto com AutoFac.
            IPedidoRepository testeGetService = (IPedidoRepository)_serviceProvider.GetService(typeof(IPedidoRepository));
            var pedidos = testeGetService.BuscarPedidos();
            #endregion

            _pedidoRepostiry.BuscarPedidos().ForEach(pedido =>
            {
                pedidosDto.Add(_objectMapper.Map<Pedido, PedidoDTO>(pedido));
            });

            return pedidosDto;
        }
    }
}
