﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UniversityPlatformApi.Models;

namespace UniversityPlatformApi.Repository.Interfaces
{
    public interface IUow : IDisposable
    {
        IRepository<University> Universities { get; }
        IRepository<School> Schools { get; }
        void Commit();
        Task CommitAsync();
        Task DisposeAsync();
    }
}