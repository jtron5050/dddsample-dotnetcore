using System;
using System.Collections.Generic;
using DDDSample.Domain.Model.Handling;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class Delivery : ValueObject
    {
        public TransportationStatus TransportationStatus { get; private set; }
        public int LastKnownLocationId { get; private set; }
        public int CurrentVoyageId { get; private set; }
        public bool Misdirected { get; private set; }
        public DateTime Eta { get; private set; }
        public bool IsUnloadedAtDestinations { get; private set; }
        public RoutingStatus RoutingStatus { get; private set; }
        public DateTime CalculatedAt { get; private set; }
        public int LastHandlingEventId { get; private set; }


        public static Delivery DerivedFrom(RouteSpecification routeSpecification, Itinerary itinerary, HandlingHistory handlingHistory)
        {

            return new Delivery(handlingHistory.MostRecentlyCompletedEvent().Id, itinerary, routeSpecification);
        }

        private Delivery(int lastEvent, Itinerary itinerary, RouteSpecification routeSpecification)
        {
            CalculatedAt = DateTime.Now;
            LastHandlingEventId = lastEvent;
        }

        internal Delivery UpdateOnRouting(RouteSpecification routeSpecification, Itinerary itinerary)
        {
            return new Delivery(LastHandlingEventId, itinerary, routeSpecification);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new System.NotImplementedException();
        }
    }
}