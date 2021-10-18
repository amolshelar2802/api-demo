using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace User.Api.DAL.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User.Api.Models.User>> GetUsers();

    }
}
