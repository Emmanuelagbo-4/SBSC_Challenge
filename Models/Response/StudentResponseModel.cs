namespace SBSC_Challenge.Models.Response
{
    public class StudentResponseModel
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string FamilyName {get; set;}
        public string Address {get; set;}
        public string CountryOfOrigin {get; set;}
        public string EmailAddress {get; set;}
        public int Age {get; set;}
        public bool Approved {get; set;}
    }
}