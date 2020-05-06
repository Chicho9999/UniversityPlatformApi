using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UniversityPlatformApi.Models;
using UniversityPlatformApi.Repository.Interfaces;
using UniversityPlatformApi.Service.Interfaces;

namespace UniversityPlatformApi.Service
{
    public class UniversityService : IUniversityService 
    {
        private readonly IUow _uow;

        public UniversityService(IUow uow)
        {
            _uow = uow;
        }
        public Task<IEnumerable<University>> GetUniversities()
        {
            return _uow.Universities.GetAllAsync();
        }

        public Task<University> GetUniversityByIdAsync(int id)
        {
            return _uow.Universities.GetAsync(id);
        }
    }
}
