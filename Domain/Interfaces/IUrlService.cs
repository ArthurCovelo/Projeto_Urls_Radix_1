using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUrlService
    {
        Task<Url> AddAsync(Url url);
        Task DeleteAsync(int id);
        Task<IEnumerable<Url>> ListUrlsAsync();
        Task<Url> GetByIdAsync(int id);
        Task UpdateAsync(Url url);
    }
}