using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class PPatient : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        public int DoctorId { get; set; }   

        public string FirstName { get; set; }
        [StringLength(50)]

        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(50)]

        public string Gender { get; set; }
        [StringLength(50)]

        public string PhoneNumber { get; set; }
        [StringLength(50)] 

        public string Adress { get; set; }
        [StringLength(50)]

        public string MedicalHistory { get; set; }
        public virtual Doctor Doctor { get; set; } 


    }
}
