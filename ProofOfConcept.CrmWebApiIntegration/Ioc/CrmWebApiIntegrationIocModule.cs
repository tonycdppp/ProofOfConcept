using System;
using System.Reflection;
using Autofac;
using ProofOfConcept.CrmWebApiIntegration.Service;
using Module = Autofac.Module;

namespace ProofOfConcept.CrmWebApiIntegration.Ioc
{
    public class CrmWebApiIntegrationIocModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            if (builder == null) { throw new ArgumentNullException($"builder"); }

            builder.RegisterAssemblyTypes(typeof(ConnectionEventService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .PropertiesAutowired()
                .InstancePerLifetimeScope();
        }
    }
}