using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPage.Model;

namespace UserPage.DataRepository
{
    public interface IUserApiRepository
    {
        public Task<IEnumerable<User>> getall();
        public Task<User> get(int id);
        public Task createuser(User user);
        public Task updateuser(User user);
        public void deleteuser(User user);
        public Task<bool> savechangeasync();

    }
}
