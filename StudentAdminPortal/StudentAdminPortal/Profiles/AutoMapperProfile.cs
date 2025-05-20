using AutoMapper;
using StudentAdminPortal.DataModels;
using DataModels = StudentAdminPortal.DomainModels;

namespace StudentAdminPortal.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DataModels.Student, Student>()
            .ReverseMap();

            CreateMap<DataModels.Gender, Gender>()
            .ReverseMap();

            CreateMap<DataModels.Address, Address>()
            .ReverseMap();
        }
    }
}
