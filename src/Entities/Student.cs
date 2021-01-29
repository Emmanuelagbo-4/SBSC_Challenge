using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBSC_Challenge.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
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