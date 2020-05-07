using UniversityPlatformApi.Data.Models;
using UniversityPlatformApi.ViewModels;

namespace UniversityPlatformApi.Service.Interfaces
{
    public interface IAuthService
    {
        AuthData GetAuthDataAsync(int id);
        string HashPassword(User user, string password);
        bool VerifyPassword(User user, string actualPassword, string hashedPassword);
    }
}
