

namespace ePizza.Domain.Interfaces
{
    public interface IGenericRepository<TDomain> where TDomain : class
    {
        Task<IEnumerable<TDomain>> GetAllAsync();
        Task<TDomain> GetAsync(object id);
    }
}
