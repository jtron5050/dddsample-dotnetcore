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

        public Cargo(string trackingId, int locationId, RouteSpecification routeSpecification, Itinerary itinerary, Delivery delivery)
        {
            TrackingId = trackingId;
            LocationId = locationId;
            RouteSpecification = routeSpecification;
            Itinerary = itinerary;
            Delivery = delivery;
        }

        public void SpecifyNewRoute(in RouteSpecification routeSpecification)
        {
            
        }

        public void AssignToRoute(in Itinerary itinerary)
        {

        }

        public void DeriveDeliveryProgress(in HandlingHistory handlingHistory)
        {
            
        }
    }
}