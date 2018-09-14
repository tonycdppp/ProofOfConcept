using Autofac;
using ProofOfConcept.CrmWebApiIntegration.Ioc;

namespace ProofOfConcept.Ioc
{
    public class RootIocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        { 
            //Cascade
            builder.RegisterModule(new CrmWebApiIntegrationIocModule());
        }
    }
}