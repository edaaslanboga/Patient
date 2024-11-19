using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class SymptomTracker :IEntity
    {   
        public int Id { get; set; }    
       
        public int PatientID { get; set; }
        public DateTime Date { get; set; }
        [StringLength(50)]

        public string SymptomDescription { get; set; } 
        public int Severity { get; set; } // enum
        [StringLength(50)]

        public string Notes { get; set; } 
        public PPatient Patient { get; set; }
    }

}
