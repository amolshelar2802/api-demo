using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Api.Models;

namespace User.Api.DAL.DBContext
{
    public class UserDBContext : DbContext
    {

        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }

        public DbSet<User.Api.Models.User> Users { get; set; }

    }
}
