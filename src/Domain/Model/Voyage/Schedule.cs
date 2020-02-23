using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class Schedule : ValueObject
    {        
        public IEnumerable<CarrierMovement> CarrierMovements { get; private set;}

        public Schedule(IEnumerable<CarrierMovement> carrierMovements)
        {
            CarrierMovements = carrierMovements;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return CarrierMovements;
        }
    }
}