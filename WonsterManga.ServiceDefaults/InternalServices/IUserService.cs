using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.DTOs;
using WonsterManga.Domain.Utilities;

namespace WonsterManga.ServiceDefaults.InternalServices
{
    internal interface IUserService
    {
        internal Task<User> GetUser(int id);
        internal Task<IEnumerable<User>> GetUsers();
        internal Task<User> AddUser(User user);
        internal Task<Result<User>> UpdateUser(User user);
        internal Task<Result<User>> DeleteUser(int id);
        internal Task<User> Login(LoginDTO loginDTO);
    }
}
