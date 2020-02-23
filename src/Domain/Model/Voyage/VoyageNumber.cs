using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class VoyageNumber : ValueObject
    {
        public string Number { get; private set; }

        public VoyageNumber(string number)
        {
            Number = number;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Number;
        }
    }
}