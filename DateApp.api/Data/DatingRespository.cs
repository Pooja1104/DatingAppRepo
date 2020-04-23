using System.Collections.Generic;
using System.Threading.Tasks;
using DateApp.api.Models;
using Microsoft.EntityFrameworkCore;

namespace DateApp.api.Data
{
    public class DatingRespository : IDatingRepository
    {
        public DataContext _context { get; }
        public DatingRespository(DataContext context)
        {
            this._context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            this._context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            this._context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await this._context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await this._context.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
          return await _context.SaveChangesAsync()>0;
        }
    }
}