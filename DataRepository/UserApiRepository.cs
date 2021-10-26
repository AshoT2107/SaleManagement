using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPage.DataLayer;
using UserPage.Model;

namespace UserPage.DataRepository
{
    public class UserApiRepository : IUserApiRepository
    {
        private readonly UserDbContext _dbcontext;

        public UserApiRepository(UserDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task createuser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            await _dbcontext.Users.AddAsync(user);
        }

        public  void deleteuser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            _dbcontext.Users.Remove(user);
        }

        public async Task<User> get(int id)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<User>> getall()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        public async Task<bool> savechangeasync()
        {
            return await _dbcontext.SaveChangesAsync() >= 0;
        }

        public async Task updateuser(User user)
        {
            ///
        }
    }
}
