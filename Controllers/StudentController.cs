using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBSC_Challenge.Data;
using SBSC_Challenge.Entities;
using SBSC_Challenge.Models.Request;
using SBSC_Challenge.Models.Response;
using SBSC_Challenge.Services;

namespace SBSC_Challenge.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IMapper _mapper;
        ApplicationDbContext _dbContext;
        StudentService _StudentService;
        public StudentController(IMapper mapper, ApplicationDbContext dbContext, StudentService StudentService)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _StudentService = StudentService;
        }

        /// <summary>
        /// Get student 
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-student/{id}", Name = "ObStudent")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ApiResponse<StudentResponseModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public  IActionResult GetStudent(int id){

            var Result = _StudentService.GetById(id);
            if(!Result.status){
                return NotFound();
            }
            return Ok(new ApiResponse {data = Result.data, message = Result.response});
        }

         /// <summary>
        /// create student 
        /// </summary>
        /// <returns></returns>
        [HttpPost("create-student")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ApiResponse<StudentResponseModel>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequestModel model){
            try
            {
                var StudentModel = _mapper.Map<Student>(model);
                var Result = await _StudentService.CreateStudents(StudentModel);
                if(!Result.status){
                    return BadRequest(new ApiResponse {message = Result.response});
                }
                var Response = new ApiResponse {data = Result.data, message = Result.response};
                var StudentResponseModel = _mapper.Map<Student>(Response.data);
                return CreatedAtRoute("ObStudent", new {id = StudentResponseModel.ID}, Response);
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse {message = "failed to create student" + ex});
            }
        }

         /// <summary>
        /// edit student 
        /// </summary>
        /// <returns></returns>
        [HttpPut("edit-student")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ApiResponse<StudentResponseModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public  IActionResult EditStudent([FromBody] EditStudentRequestModel model){
            try
            {
                var StudentModel = _mapper.Map<Student>(model);
                var Result = _StudentService.UpdateStudent(StudentModel);
                return Ok(new ApiResponse {data = Result.data, message = Result.response});
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse {message = "failed to update student record " + ex});
            }
        }

       

        /// <summary>
        /// delete student 
        /// </summary>
        /// <returns></returns>
        [HttpDelete("delete-student/{id}")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ApiResponse<StudentResponseModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public IActionResult DeleteStudent(int id){
            var Result = _StudentService.DeleteStudent(id);
            return Ok(new ApiResponse{message = Result.response});
        }

        
    }
}