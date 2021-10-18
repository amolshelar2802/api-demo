using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Api.DAL.Interfaces;
using User.Api.DAL.DBContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace User.Api.DAL.Implementation
{
    public class UserRepository : IUserRepository
    {

        private UserDBContext _userDBContext;

        public UserRepository(UserDBContext userDBContext)
        {
            _userDBContext = userDBContext;
        }


        public async Task<IEnumerable<User.Api.Models.User>> GetUsers()
        {
            var users = await _userDBContext.Users.ToListAsync();
            return users;
        }

    }
}
