using System;
using System.Collections.Generic;
using Domain.Shared;

namespace DDDSample.Domain.Model.Cargo
{
    public class Itinerary : ValueObject
    {
        private readonly List<Leg> _legs;
        public IReadOnlyCollection<Leg> Legs => _legs.AsReadOnly();

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }

    public class Leg : ValueObject
    {
        public int VoyageId { get; private set; }
        public int LoadLocationId { get; private set; }
        public int UnloadLocationId { get; private set; }
        public DateTime loadTime { get; private set; }
        public DateTime UnloadTime { get; private set; }

        public Leg(int voyageId, int loadLocationId, int unloadLocationId, DateTime loadTime, DateTime unloadTime)
        {
            VoyageId = voyageId;
            LoadLocationId = loadLocationId;
            UnloadLocationId = unloadLocationId;
            this.loadTime = loadTime;
            UnloadTime = unloadTime;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}