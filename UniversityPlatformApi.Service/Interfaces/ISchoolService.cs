using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPlatformApi.Models;

namespace UniversityPlatformApi.Service.Interfaces
{
    public interface ISchoolService
    {
        Task<IEnumerable<School>> GetSchoolsAsync();
        Task<School> GetSchoolByIdAsync(int id);
    }
}
