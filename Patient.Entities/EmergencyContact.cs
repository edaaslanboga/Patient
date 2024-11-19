using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class EmergencyContact:IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string ContactName { get; set; } // İletişim kurulacak kişi adı
        [StringLength(50)]

        public string Relationship { get; set; } // enum Parent, Spouse, Friend
        [StringLength(50)]

        public string PhoneNumber { get; set; }
        [StringLength(50)]

        public string Email { get; set; }
        public virtual PPatient Patient { get; set; }
    }

}
