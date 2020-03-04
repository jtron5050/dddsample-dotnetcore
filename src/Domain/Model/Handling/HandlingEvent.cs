using System;
using Domain.Shared;

namespace DDDSample.Domain.Model.Handling
{
    public class HandlingEvent : Entity, IAggregateRoot
    {
        private int _handlingEventTypeId;
        
        public HandlingEventType Type { get; private set; }
        public int VoyageId { get; private set; }
        public int LocationId { get; private set; }
        public DateTime CompletionTime { get; private set; }
        public DateTime RegistrationTime { get; private set; }
        public int CargoId { get; private set; }

        public HandlingEvent(
            int cargoId,
            DateTime completionTime, 
            DateTime registrationTime, 
            int typeId, 
            int locationId, 
            int voyageId )
        {
            _handlingEventTypeId = typeId;
            VoyageId = voyageId;
            LocationId = locationId;
            this.CompletionTime = completionTime;
            RegistrationTime = registrationTime;
            CargoId = cargoId;
        }
    }

    public class HandlingEventType : Enumeration
    {
        public bool VoyageRequired { get; private set; }

        public static HandlingEventType Load = new HandlingEventType(1, nameof(Load).ToLowerInvariant(), true);
        public static HandlingEventType Unload = new HandlingEventType(2, nameof(Unload).ToLowerInvariant(), true);
        public static HandlingEventType Receive = new HandlingEventType(3, nameof(Receive).ToLowerInvariant(), false);
        public static HandlingEventType Claim = new HandlingEventType(4, nameof(Claim).ToLowerInvariant(), false);
        public static HandlingEventType Customs = new HandlingEventType(5, nameof(Customs).ToLowerInvariant(), false);


        protected HandlingEventType(int id, string name, bool voyageRequired) : base(id, name)
        {
            VoyageRequired = voyageRequired;
        }
    }
}