using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class Visit:IEntity

    { public int Id { get; set; }
        public int PatientId {   get; set; } 
        public int DoctorId { get; set; }   
        public DateTime VisitDate { get; set; }
        [StringLength(50)]

        public string ReasonForVisit { get; set; }
        public Boolean FallowUpRequired { get; set; }
        [StringLength(50)]

        public string VisitNotes { get; set; }
        public virtual PPatient Patient { get; set; }
        public virtual Doctor Doctor { get; set; } 
    }
}
