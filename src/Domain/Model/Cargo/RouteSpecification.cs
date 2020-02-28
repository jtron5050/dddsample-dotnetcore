using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class RouteSpecification : ValueObject
    {
        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}