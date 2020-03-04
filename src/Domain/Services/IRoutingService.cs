
using System.Collections.Generic;
using DDDSample.Domain.Model.Cargo;

namespace DDDSample.Domain.Services
{
    public interface IRoutingService
    {
        List<Itinerary> GetRoutesForSpecification(RouteSpecification routeSpecification);
    }
}