using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;

namespace Poc.Modules.Application
{
    public class PedidoApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PedidoApplication>()
                   .As<IPedidoApplication>()
                   .InstancePerLifetimeScope();

            builder.RegisterAutoMapper(typeof(PedidoApplicationModule).Assembly);
        }
    }
}
