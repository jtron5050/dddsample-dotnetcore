using System;
using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class CarrierMovement : ValueObject
    {
        private int _departureLocationId;
        private int _arrivalLocationId;
        private DateTime _departureTime;
        private DateTime _arrivalTime;

        public CarrierMovement(int departureLocationId, int arrivalLocationId, DateTime departureTime, DateTime arrivalTime)
        {
            _departureLocationId = departureLocationId;
            _arrivalLocationId = arrivalLocationId;
            _departureTime = departureTime;
            _arrivalTime = arrivalTime;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}