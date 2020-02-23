
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class Voyage : Entity, IAggregateRoot
    {
        public VoyageNumber VoyageNumber { get; private set; }
        public Schedule Schedule { get; private set; }

        public Voyage(VoyageNumber voyageNumber, Schedule schedule)
        {
            VoyageNumber = voyageNumber;
            Schedule = schedule;
        }
    }
}