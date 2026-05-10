using System.ComponentModel.DataAnnotations;

namespace NewLifeHospitalSolution.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string PatientName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        public string BloodGroup { get; set; }

        [Required]
        [Phone]
        [StringLength(10)]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailID { get; set; }
    }
}
