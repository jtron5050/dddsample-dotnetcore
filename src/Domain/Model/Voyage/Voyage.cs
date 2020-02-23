
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public class Voyage : Entity, IAggregateRoot
    {
        private VoyageNumber _voyageNumber;
        private Schedule _schedule;  
    }

    
}