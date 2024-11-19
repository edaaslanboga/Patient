using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class FamilyHistory :IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string RelativeName { get; set; }
        [StringLength(50)]

        public string Relation { get; set; }
        [StringLength(50)]

        public string Condition { get; set; } 
        public int DiagnosisAge { get; set; } // Teşhis yaşı
        public virtual PPatient Patient { get; set; }
    }

}
