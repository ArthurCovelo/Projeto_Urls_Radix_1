using Domain.Entities;
using Domain.Interfaces;

namespace Service
{
    public class UrlService : IUrlService
    {
        private readonly IUrlRepository _urlRepository;

        public UrlService(IUrlRepository urlRepository)
        {
            _urlRepository = urlRepository;
        }

        public async Task<Url> AddAsync(Url url)
        {
            return await _urlRepository.AddAsync(url);
        }

        public async Task DeleteAsync(int id)
        {
            await _urlRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Url>> ListUrlsAsync()
        {
            return await _urlRepository.ListUrlsAsync();
        }

        public async Task<Url> GetByIdAsync(int id)
        {
            return await _urlRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Url url)
        {
            await _urlRepository.UpdateAsync(url);
        }
    }
}
