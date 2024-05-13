using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserApI.Model;

namespace UserApI.Data
{
    public class UserApIContext : DbContext
    {
        public UserApIContext (DbContextOptions<UserApIContext> options)
            : base(options)
        {
        }

        public DbSet<UserApI.Model.User> User { get; set; } = default!;
    }
}
