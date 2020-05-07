using UniversityPlatformApi.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPlatformApi.Data.Models;
using UniversityPlatformApi.Repository.Interfaces;
using System;

namespace UniversityPlatformApi.Service
{
    public class UserService : IUserService 
    {
        private readonly IUow _uow;

        public UserService(IUow uow)
        {
            _uow = uow;
        }

        public async Task AddUserAsync(User user)
        {
            user.CreatedBy = 1;
            user.CreatedDate = DateTime.Now;

            await _uow.Users.AddAsync(user);

            await _uow.CommitAsync();
        }

        public async Task<User> GetUserByEmailAsync(string emailUserName)
        {
            return await _uow.Users.GetAsync(u => u.Email == emailUserName || u.Username == emailUserName);
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            return _uow.Users.GetAsync(id);
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            return _uow.Users.GetAllAsync();
        }

        public bool IsEmailUniqe(string email)
        {
            var user = _uow.Users.Get(u => u.Email == email);
            return user == null;
        }

        public bool IsUsernameUniqe(string username)
        {
            var user = _uow.Users.Get(u => u.Username == username);
            return user == null;
        }
    }
}
