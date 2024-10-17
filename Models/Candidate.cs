using System.ComponentModel.DataAnnotations;

namespace OzanAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="That area is required.")]
        public string? Email {get; set;} = String.Empty;

        [Required(ErrorMessage ="That area is required.")]
        public string? FirstName {get; set;} = String.Empty;
        
        [Required(ErrorMessage ="That area is required.")]
        public string? LastName {get; set;} = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse {get; set;} = String.Empty;
         public DateTime ApplyAt { get; set; }

         public Candidate()
         {
            ApplyAt = DateTime.Now;
         }
    }
}