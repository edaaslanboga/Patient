using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class HealthAlert:IEntity
    {   
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string AlertMessage { get; set; } 
        public DateTime AlertDate { get; set; } 
        public bool IsAcknowledged { get; set; } // Uyarı kabul edildi mi 
        public virtual PPatient Patient { get; set; } 
    }

}
