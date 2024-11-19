using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class Prescripton:IEntity
    { public int Id { get; set; }
       public int  PatientId { get; set; }
       public int DoctorId { get; set; }    
       public DateTime PrescriptonDate { get; set; }
        [StringLength(50)]

        public string Medication { get; set; } 
       public virtual PPatient Patient { get; set; }
       public virtual Doctor Doctor { get; set; }



    }
}
