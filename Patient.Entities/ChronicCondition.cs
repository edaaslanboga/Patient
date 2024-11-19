using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class ChronicCondition : IEntity

    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        [StringLength(50)]

        public string ConditionName { get; set; }
        public DateTime DiagnosisDate { get; set; } //teşhis tarihi
        [StringLength(50)]

        public string Severity { get; set; }    //enum
        [StringLength(50)]

        public string OrgoingTreatment { get; set; }// süregelen tedavi
        public virtual PPatient Patient { get; set; }
    }
}
