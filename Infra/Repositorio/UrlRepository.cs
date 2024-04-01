using Domain.Entities;
using Domain.Interfaces;
using Infra.Config;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositorio
{
    public class UrlRepository : IUrlRepository
    {
        private readonly UrlDbContext _dbContext;

        public UrlRepository(UrlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Url> AddAsync(Url url)
        {
            try
            {
                _dbContext.Urls.Add(url);
                await _dbContext.SaveChangesAsync();
                return url;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao adicionar a URL.", ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var url = await _dbContext.Urls.FindAsync(id);
            if (url != null)
            {
                _dbContext.Urls.Remove(url);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Url>> ListUrlsAsync()
        {
            return await _dbContext.Urls.ToListAsync();
        }

        public async Task<Url> GetByIdAsync(int id)
        {
            return await _dbContext.Urls.FindAsync(id);
        }

        public async Task UpdateAsync(Url url)
        {
            try
            {
                _dbContext.Entry(url).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar a URL.", ex);
            }
        }

    }
}
