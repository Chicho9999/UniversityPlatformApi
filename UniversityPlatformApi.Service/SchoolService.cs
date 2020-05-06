using UniversityPlatformApi.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPlatformApi.Models;
using UniversityPlatformApi.Repository.Interfaces;

namespace UniversityPlatformApi.Service
{
    public class SchoolService : ISchoolService 
    {
        private readonly IUow _uow;

        public SchoolService(IUow uow)
        {
            _uow = uow;
        }
        public Task<IEnumerable<School>> GetSchoolsAsync()
        {
            return _uow.Schools.GetAllAsync();
        }

        public Task<School> GetSchoolByIdAsync(int id)
        {
            return _uow.Schools.GetAsync(id);
        }
    }
}
