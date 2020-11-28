using System;
using System.Collections.Generic;
using Poc.Modules.Core;

namespace Poc.Modules.EntityFrameworkCore
{
    public class PedidoRepository : IPedidoRepository
    {
        public List<Pedido> BuscarPedidos()
        {
            return new List<Pedido>() {
                                        new Pedido()
                                        {
                                            Id = Guid.NewGuid(),
                                            Cliente = new Cliente()
                                            {
                                                Id = Guid.NewGuid(),
                                                Nome = "Cliente 1"
                                            },
                                            Valor = 30m
                                        },

                                        new Pedido()
                                        {
                                            Id = Guid.NewGuid(),
                                            Cliente = new Cliente()
                                            {
                                                Id = Guid.NewGuid(),
                                                Nome = "Cliente 2"
                                            },
                                            Valor = 30m
                                        },

                                        new Pedido()
                                        {
                                            Id = Guid.NewGuid(),
                                            Cliente = new Cliente()
                                            {
                                                Id = Guid.NewGuid(),
                                                Nome = "Cliente 3"
                                            },
                                            Valor = 30m
                                        },

                                        new Pedido()
                                        {
                                            Id = Guid.NewGuid(),
                                            Cliente = new Cliente()
                                            {
                                                Id = Guid.NewGuid(),
                                                Nome = "Cliente 4"
                                            },
                                            Valor = 30m
                                        }
                                      };
        }
    }
}
