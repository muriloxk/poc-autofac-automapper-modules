using System;
namespace Poc.Modules.Core
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Decimal Valor { get; set; }
        public Cliente Cliente { get; set; }
    }
}
