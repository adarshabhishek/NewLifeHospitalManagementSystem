using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLifeHospitalDAL.Models
{
    public class PatientInfoDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string PatientName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(4)]
        public string BloodGroup { get; set; }

        [Required]
        [StringLength(10)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string EmailID { get; set; }
    }
}
