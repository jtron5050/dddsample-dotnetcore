using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class Itinerary : ValueObject
    {
        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}