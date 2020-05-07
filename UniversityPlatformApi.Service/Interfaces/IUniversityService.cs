using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPlatformApi.Data.Models;

namespace UniversityPlatformApi.Service.Interfaces
{
    public interface IUniversityService
    {
        Task<IEnumerable<University>> GetUniversities();
        Task<University> GetUniversityByIdAsync(int id);
    }
}
