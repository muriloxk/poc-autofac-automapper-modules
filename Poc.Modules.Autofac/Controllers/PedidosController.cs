using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Poc.Modules.Application;

namespace Poc.Modules.Autofac.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoApplication _pedidoApplication;
        private readonly IMapper _mapper;



        public PedidosController(IPedidoApplication pedidoApplication, IMapper mapper)
        {
            _pedidoApplication = pedidoApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<PedidoDTO>>> GetPedidos()
        {
            var lista = _pedidoApplication.BuscarPedidos();

            var teste = new List<Core.Pedido>();

            lista.ForEach(item =>
            {
                teste.Add(_mapper.Map<PedidoDTO, Core.Pedido>(item));
            });

            var x = teste.ToArray();

            return lista;
        }
    }
}
