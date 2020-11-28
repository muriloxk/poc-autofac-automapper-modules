using System.Collections.Generic;

namespace Poc.Modules.Core
{
    public interface IPedidoRepository
    {
        public List<Pedido> BuscarPedidos();
    }
}
