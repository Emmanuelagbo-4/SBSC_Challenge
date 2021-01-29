using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SBSC_Challenge.Models.Request;
using Xunit;

namespace SBSC_CHALLENGE.Tests
{
    public class StudentControllerTests
    {
        HttpClient client = new HttpClient();
        [Fact]
        public async Task CreateStudentPost_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            //Arrange
            CreateStudentRequestModel TestStudent = new CreateStudentRequestModel
            {
                Name = "Emmanuel",
                FamilyName = "Agbo-create",
                Address = "Festac Town Lagos",
                CountryOfOrigin = "Nigeria",
                EmailAddress = "agboemmanuel360@gmail.com",
                Age = 24,
                Approved = true
            };

            string JsonStudent = JsonConvert.SerializeObject(TestStudent);

            //Act
            var stringContent = new StringContent(JsonStudent, System.Text.Encoding.UTF8, "application/json");
            
            var response = await client.PostAsync("https://localhost:5001/api/students/create-student", stringContent);

            //Assert
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }


        [Fact]
        public async Task EditStudent_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            //Arrange
            EditStudentRequestModel TestStudent = new EditStudentRequestModel
            {
                ID = 4,
                Name = "Emmanuel",
                FamilyName = "Agbo-edit",
                Address = "Festac Town Lagos",
                CountryOfOrigin = "Nigeria",
                EmailAddress = "agboemmanuel360@gmail.com",
                Age = 24,
                Approved = true
            };

            string JsonStudent = JsonConvert.SerializeObject(TestStudent);

            //Act
            var stringContent = new StringContent(JsonStudent, System.Text.Encoding.UTF8, "application/json");
            
            var response = await client.PutAsync("https://localhost:5001/api/students/edit-student", stringContent);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
