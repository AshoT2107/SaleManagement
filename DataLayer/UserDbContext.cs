using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPage.Model;

namespace UserPage.DataLayer
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>option)
            :base(option)
        {}
        public DbSet<User> Users { get; set; }
    }
}
