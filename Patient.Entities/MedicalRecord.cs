using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public  class MedicalRecord:IEntity
         
    { 
        public int Id { get; set; }
        public int PatiendId { get; set; }
        public int DoctorId { get; set; }
        public DateTime RecordDate { get; set; }   
        [StringLength(50)]

        public string Diagnosis { get; set; }   //tanı
        [StringLength(50)]

        public string TreatmentPlan { get; set; }
        [StringLength(50)]

        public string Notes { get; set; }
        public virtual PPatient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
