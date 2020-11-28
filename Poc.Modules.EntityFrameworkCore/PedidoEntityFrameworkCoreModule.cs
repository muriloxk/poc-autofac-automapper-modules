using Autofac;
using Poc.Modules.Core;

namespace Poc.Modules.EntityFrameworkCore
{
    public class PedidoEntityFrameworkCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PedidoRepository>().As<IPedidoRepository>().InstancePerLifetimeScope();
        }
    }
}
