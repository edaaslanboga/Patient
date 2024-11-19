using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class ImmunizationRecord:IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string VaccineName { get; set; } // Aşı adı
        public DateTime DateAdministered { get; set; } // Aşının yapıldığı tarih
        [StringLength(50)]

        public string AdministeredBy { get; set; } // Aşıyı uygulayan kişi
        [StringLength(50)]

        public string Dosage { get; set; } // Aşı dozu
        public DateTime? NextDoseDate { get; set; } //  (nullable)
        public virtual PPatient Patient { get; set; } 
    }

}
