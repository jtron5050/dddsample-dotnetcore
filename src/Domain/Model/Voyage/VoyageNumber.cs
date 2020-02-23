using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class VoyageNumber : ValueObject
    {
        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}