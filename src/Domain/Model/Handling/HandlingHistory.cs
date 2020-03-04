using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Shared;

namespace DDDSample.Domain.Model.Handling
{

    public class HandlingHistory : ValueObject
    {
        public static HandlingHistory Empty = new HandlingHistory(new List<HandlingEvent>());

        public List<HandlingEvent> HandlingEvents { get; private set; }

        public HandlingHistory(List<HandlingEvent> handlingEvents)
        {
            HandlingEvents = handlingEvents;
        }

        public IReadOnlyCollection<HandlingEvent> DistinctEventsByCompletionTime()
        {
            return HandlingEvents.OrderBy(x => x.CompletionTime).ToList().AsReadOnly();
        }

        public HandlingEvent MostRecentlyCompletedEvent()
        {
            return DistinctEventsByCompletionTime()
                .LastOrDefault();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return HandlingEvents;
        }

    }
}