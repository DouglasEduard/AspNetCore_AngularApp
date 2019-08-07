using System.Collections.Generic;
using System.Threading.Tasks;
using EasyDevelopersApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyDevelopersApp.API.Data
{
    public class TalentsRepository : ITalentsRepository
    {
        private readonly DataContext _context;

        public TalentsRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetTalent(int id)
        {
            var talent = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);

            return talent;
        }

        public async Task<IEnumerable<User>> GetTalents()
        {
            var talents = await _context.Users.Include(p => p.Photos).ToListAsync();

            return talents;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}