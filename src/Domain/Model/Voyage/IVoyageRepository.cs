
using System.Threading.Tasks;
using Domain.Shared;

namespace DDDSample.Domain.Model.Voyage
{
    public interface IVoyageRepository : IRepository<Voyage>
    {
        Task<Voyage> GetByVoyageNumberAsync(VoyageNumber voyageNumber);
    }

    
}