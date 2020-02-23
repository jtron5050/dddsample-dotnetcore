using Domain.Shared;

namespace DDDSample.Domain.Model.Location
{
    public class Location : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public UNLocode Locode { get; private set; }

        public Location(string name, UNLocode locode)
        {
            Name = name;
            Locode = locode;
        }
    }
}