using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RESTCountries.Services;
using SBSC_Challenge.Data;
using SBSC_Challenge.Entities;
using SBSC_Challenge.Models.Response;

namespace SBSC_Challenge.Services
{
    public class StudentService
    {
        IMapper _mapper;
        ApplicationDbContext _dbContext;
        public StudentService(IMapper mapper, ApplicationDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse> CreateStudents(Student model){
           var result = await RESTCountriesAPI.GetCountryByFullNameAsync(model.CountryOfOrigin);
            if(result == null){
                return new ServiceResponse {status = false, response = "Country name is invalid"};
            }
            else{
                var StudentData =  (await _dbContext.Students.AddAsync(model)).Entity;
            await _dbContext.SaveChangesAsync();
            var ResponseData = _mapper.Map<StudentResponseModel>(StudentData);
            return new ServiceResponse { status = true, data = ResponseData, response = "Student created Successfully"};
            }
        }

        public ServiceResponse GetById(int id){
            var StudentData = _dbContext.Students.Where(x => x.ID == id).FirstOrDefault();
            if(StudentData == null){
                return new ServiceResponse {status = false, response = "failed to retrieve student record"};
            }
            else{
                var ResponseData = _mapper.Map<StudentResponseModel>(StudentData);
                return new ServiceResponse {status = true, response = "student record retrieved successfully", data = ResponseData};
            }
        }

        public ServiceResponse UpdateStudent(Student model){
            //var StudentData = _dbContext.Students.Where(x => x.ID == model.ID).FirstOrDefault();
            // StudentData.Name = model.Name;
            // StudentData.FamilyName = model.FamilyName;
            // StudentData.EmailAddress = model.EmailAddress;
            // StudentData.CountryOfOrigin = model.CountryOfOrigin;
            // StudentData.Approved = model.Approved;
            // StudentData.Age = model.Age;
            // StudentData.Address = model.Address;
            var NewStudentData = _dbContext.Students.Update(model).Entity;
            _dbContext.SaveChanges();
            var ResponseData = _mapper.Map<StudentResponseModel>(NewStudentData);
            return new ServiceResponse {data = ResponseData, status = true, response = "student record updated successfully"};
        }


        public ServiceResponse DeleteStudent(int id){
            var StudentData = _dbContext.Students.Where(x => x.ID == id).FirstOrDefault();
            _dbContext.Students.Remove(StudentData);
            _dbContext.SaveChanges();
            return new ServiceResponse {response = "student record deleted successfully"};
        }
    }
}