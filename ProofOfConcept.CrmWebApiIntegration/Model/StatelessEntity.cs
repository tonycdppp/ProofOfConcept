using System;

namespace ProofOfConcept.CrmWebApiIntegration.Model
{
    public abstract class StatelessEntity
    {
        public virtual Guid Id { get; set; }
    }
}