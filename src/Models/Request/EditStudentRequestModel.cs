using System.ComponentModel.DataAnnotations;

namespace SBSC_Challenge.Models.Request
{
    public class EditStudentRequestModel
    {
        public int ID {get; set;}
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should be more than 4 characters")]
        public string Name {get; set;}
        [StringLength(20, MinimumLength = 5, ErrorMessage = "FamilyName should be more than 4 characters")]
        public string FamilyName {get; set;}
        [StringLength(25,MinimumLength = 10, ErrorMessage = "Address should be more than 9 characters")]
        public string Address {get; set;}
        public string CountryOfOrigin {get; set;}
        [EmailAddress(ErrorMessage = "E-mail is invalid")]
        public string EmailAddress {get; set;}
        [Range(18,25, ErrorMessage = "Age should be between 18 and 25 years")]
        public int Age {get; set;}
        public bool Approved {get; set;}
    }
}