using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UniversityPlatformApi.Data.Models;
using UniversityPlatformApi.Repository.Interfaces;

namespace UniversityPlatformApi.Repository
{
    public class Uow : IUow
    {
        private readonly UniversityPlatformDBContext _DBContext;

        private IRepository<University> _Universities;
        private IRepository<School> _Schools;
        private IRepository<User> _Users;

        public IRepository<University> Universities => _Universities ??= new GenericRepository<University>(_DBContext);
        public IRepository<School> Schools => _Schools ??= new GenericRepository<School>(_DBContext);
        public IRepository<User> Users => _Users ??= new GenericRepository<User>(_DBContext);

        public Uow(UniversityPlatformDBContext context)
        {
            _DBContext = context;
        }

        public void Commit()
        {
            _DBContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _DBContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _DBContext.Dispose();
        }

        public async Task DisposeAsync()
        {
            await _DBContext.DisposeAsync();
        }
    }
}
