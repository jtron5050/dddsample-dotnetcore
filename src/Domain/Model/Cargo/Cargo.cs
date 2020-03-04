using DDDSample.Domain.Model.Handling;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class Cargo : Entity, IAggregateRoot
    {
        public string TrackingId { get; private set; }
        public int LocationId { get; private set; }
        public RouteSpecification RouteSpecification { get; private set; }
        public Itinerary Itinerary { get; private set; }
        public Delivery Delivery { get; private set; }

        public Cargo(string trackingId, int locationId, RouteSpecification routeSpecification, Itinerary itinerary)
        {
            TrackingId = trackingId;
            LocationId = routeSpecification.OriginLocationId;
            RouteSpecification = routeSpecification;
            Itinerary = itinerary;
            Delivery = Delivery.DerivedFrom(routeSpecification, itinerary, HandlingHistory.Empty);
        }

        public void SpecifyNewRoute(in RouteSpecification routeSpecification)
        {
            RouteSpecification = routeSpecification;
            Delivery = Delivery.UpdateOnRouting(RouteSpecification, Itinerary);
        }

        public void AssignToRoute(in Itinerary itinerary)
        {
            Itinerary = itinerary;
            Delivery = Delivery.UpdateOnRouting(RouteSpecification, Itinerary);
        }

        public void DeriveDeliveryProgress(in HandlingHistory handlingHistory)
        {
            Delivery = Delivery.DerivedFrom(RouteSpecification, Itinerary, handlingHistory);
        }
    }
}