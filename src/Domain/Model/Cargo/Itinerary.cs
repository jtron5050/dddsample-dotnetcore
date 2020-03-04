using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class Itinerary : ValueObject
    {
        private readonly List<Leg> _legs;
        public IReadOnlyCollection<Leg> Legs => _legs.AsReadOnly();

        public Itinerary(List<Leg> legs)
        {
            if (legs.Count == 0)
                throw new ArgumentException();

            if (legs.Any(leg => leg == null))
                throw new ArgumentException();

            _legs = legs;
        }

        public int InitialDepartureLocation => _legs.First().LoadLocationId;
        public int FinalArrivialLocation => _legs.Last().UnloadLocationId;
        
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return _legs;
        }
    }
}