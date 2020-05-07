
using AutoMapper;
using UniversityPlatformApi.Controllers;
using UniversityPlatformApi.Data.Models;

namespace UniversityPlatformApi
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, RegisterViewModel>();
            CreateMap<RegisterViewModel, User>(); 
        }
    }
}
