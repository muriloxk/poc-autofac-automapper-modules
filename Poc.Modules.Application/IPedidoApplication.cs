using System;
using System.Collections.Generic;

namespace Poc.Modules.Application
{
    public interface IPedidoApplication
    {
        public List<PedidoDTO> BuscarPedidos();
    }
}
