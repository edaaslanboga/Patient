using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Entities
{
    public class LifestyleData: IEntity
    {
        public int Id { get; set; } 
        public int PatientID { get; set; }
        [StringLength(50)]

        public string SmokingStatus { get; set; } // enum? Never, Current, Former
        [StringLength(50)]

        public string AlcoholUse { get; set; } //  enum? Never, Occasional, Frequent
        [StringLength(50)]

        public string ExerciseFrequency { get; set; } // enum? Rarely, Occasionally, Regularly
        [StringLength(50)]

        public string DietDescription { get; set; }  
        public virtual PPatient Patient { get; set; }
    }

}
