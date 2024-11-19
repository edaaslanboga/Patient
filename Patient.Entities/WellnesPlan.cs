using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities 
{
    public class WellnessPlan:IEntity
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        [StringLength(50)]

        public string PlanDescription { get; set; } 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        [StringLength(50)]

        public string Goals { get; set; }  
        public virtual PPatient Patient { get; set; }
    }
}
