using System;
using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class RouteSpecification : ValueObject
    {
        public int OriginLocationId { get; private set; }
        public int DestinationLocationId { get; private set; }
        public DateTime ArrivalDeadline { get; private set; }

        public RouteSpecification(int originLocationId, int destinationLocationId, DateTime arrivalDeadline)
        {
            if (originLocationId == destinationLocationId) 
            {    
                throw new ArgumentException($"Origin and destination can't be the same: {originLocationId}");
            }

            OriginLocationId = originLocationId;
            DestinationLocationId = destinationLocationId;
            ArrivalDeadline = arrivalDeadline;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}