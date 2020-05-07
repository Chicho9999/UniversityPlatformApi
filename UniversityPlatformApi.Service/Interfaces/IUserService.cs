using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPlatformApi.Data.Models;

namespace UniversityPlatformApi.Service.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        bool IsEmailUniqe(string email);
        bool IsUsernameUniqe(string username);
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
    }
}
