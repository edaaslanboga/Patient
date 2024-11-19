using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class LabTest :IEntity

    { 
        public int Id { get; set; }
        public int PatientId { get; set; }  
        public int DoctorId { get; set; }
        [StringLength(50)]

        public string TestName { get; set; }
        public DateTime TestDate { get; set; }
        [StringLength(50)]

        public string Result { get; set; }
        [StringLength(50)]

        public string Status { get; set; }// enum ordered Inprogress completed

        public virtual PPatient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
