using System;
using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class CarrierMovement : ValueObject
    {
        public int DepartureLocationId { get; private set; }
        public int ArrivalLocationId { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime ArrivalTime { get; private set; }

        public CarrierMovement(int departureLocationId, int arrivalLocationId, DateTime departureTime, DateTime arrivalTime)
        {
            DepartureLocationId = departureLocationId;
            ArrivalLocationId = arrivalLocationId;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return DepartureLocationId;
            yield return ArrivalLocationId;
            yield return DepartureTime;
            yield return ArrivalTime;
        }
    }
}