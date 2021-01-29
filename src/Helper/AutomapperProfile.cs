using AutoMapper;
using SBSC_Challenge.Entities;
using SBSC_Challenge.Models.Request;
using SBSC_Challenge.Models.Response;

namespace SBSC_Challenge.Helper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Student, CreateStudentRequestModel>().ReverseMap();
            CreateMap<Student, EditStudentRequestModel>().ReverseMap();
            CreateMap<Student, StudentResponseModel>().ReverseMap();
        }
    }
}